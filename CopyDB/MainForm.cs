using CopyDB.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CopyDB
{
    public partial class MainForm : Form
    {
        public Dictionary<string, bool> selectedDatabaseNames = new Dictionary<string, bool>();
        public List<string> userDatabaseNames = new List<string>();
        public List<string> databaseNamesFull = new List<string>();

        private DatabaseExporter _dbExporter;
        private DatabaseImporter _dbImporter;
        //private List<string> _serverTypeNames = new List<string>() { "Azure SQL Database", "Microsoft SQL Server (Local)", "Microsoft SQL Server (Remote)" };
        internal readonly List<string> _serverTypeNames = new List<string>() { "Microsoft SQL Server (Local)" };
        private readonly List<string> _systemDatabaseNames = new List<string>() { "master", "msdb", "model", "resource", "tempdb" };

        private string _backupFolderPath = "";
        private string _sourceFolderPath = "";

        public MainForm()
        {
            InitializeComponent();
            FormControls _controls = new FormControls(this);

            picBx_loadingicon.Visible = false;
            btn_cancel.Visible = false;
            btn_start.Enabled = false;

            FormControls.GetExportSettings();
            FormControls.GetImportSettings();

            _backupFolderPath = $"{txtbx_export_output_folder.Text}\\";

            if (!string.IsNullOrEmpty(_backupFolderPath))
            {
                _dbExporter = new DatabaseExporter(_backupFolderPath);
                _dbImporter = new DatabaseImporter(_backupFolderPath);
            }
        }

        //Starts the process of exporting and importing.
        private async void btn_start_Click(object sender, EventArgs e)
        {
            List<string> databaseNames = new List<string>();

            FormControls.ClearOutputToApp();

            for (int i = 0; i < checkedListBox_databases.CheckedItems.Count; i++)
            {
                databaseNames.Add(checkedListBox_databases.CheckedItems[i].ToString());
            }

            string exportConnection = _dbExporter.GetExportConnectionString();
            string importConnection = _dbImporter.GetImportConnectionString();

            if (!await Utilities.TestConnection(exportConnection) || !await Utilities.TestConnection(importConnection))
                return;

            if (await _dbExporter.ExportDatabases(databaseNames, exportConnection))
                await _dbImporter.ImportDatabases(databaseNames, importConnection);

            FormControls.ToggleAllElements(true);
        }

        #region Export Click Events

        //Connects tp the given server to get the database names.
        private async void btn_export_connect_Click(object sender, EventArgs e)
        {
            FormControls.EnableLoadingIcon();

            string exportConnectionString = _dbExporter.GetExportConnectionString();

            if (await Utilities.TestConnection(exportConnectionString, true))
                databaseNamesFull = await _dbExporter.GetDatabaseNames(exportConnectionString);

            userDatabaseNames = databaseNamesFull.Where(x => !_systemDatabaseNames.Contains(x.ToLower())).ToList();

            if (userDatabaseNames.Count == 0)
                return;

            Config.AddUpdateSetting("Export_ServerName", txtbx_export_server_name.Text);
            Config.AddUpdateSetting("Export_Username", txtbx_export_username.Text);
            Config.AddUpdateSetting("Export_Password", txtbx_export_password.Text);

            //Clear the database items that are currently showing.
            FormControls.UpdateDatabasesCheckedList(userDatabaseNames);
            FormControls.EnableLoadingIcon(false);
        }

        //Lets the user choose a folder to export to.
        private void btn_export_browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            if (browser.ShowDialog() == DialogResult.OK)
            {
                txtbx_export_output_folder.Text = browser.SelectedPath;
                txtbx_import_source_folder.Text = browser.SelectedPath;
                Config.AddUpdateSetting("Export_OutputFolder", browser.SelectedPath);
                _backupFolderPath = $"{browser.SelectedPath}\\";
                _dbExporter = new DatabaseExporter(_backupFolderPath);
                _dbImporter = new DatabaseImporter(_backupFolderPath);
            }
        }

        //When checked selected all of the non-system databases.
        private void chckbx_select_all_non_system_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = chckbx_select_all_non_system.Checked;
            CheckedListBox.ObjectCollection items = checkedListBox_databases.Items;

            for (int i = 0; i < items.Count; i++)
            {
                string itemName = items[i].ToString();

                if (!userDatabaseNames.Contains(itemName))
                    continue;

                checkedListBox_databases.SetItemChecked(i, isChecked);

                //Select all non-system databases.
                if (selectedDatabaseNames.ContainsKey(itemName))
                    selectedDatabaseNames[itemName] = isChecked;
                else
                    selectedDatabaseNames.Add(items[i].ToString(), isChecked);
            }

            btn_start.Enabled = selectedDatabaseNames.Any(x => x.Value == true);
        }

        //When checked shows all of the system databases.
        private void chckbx_show_system_databases_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbx_show_system_databases.Checked)
                FormControls.UpdateDatabasesCheckedList(databaseNamesFull);
            else
                FormControls.UpdateDatabasesCheckedList(userDatabaseNames);
        }

        //Handles when a database items is clicked.
        private void checkedListBox_databases_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> currentItemsDisplayed = new List<string>();
            CheckedListBox list = checkedListBox_databases;
            int index = list.SelectedIndex;
            bool isChecked = list.GetItemChecked(index);
            string itemName = list.Items[index].ToString();

            for (int i = 0; i < list.Items.Count; i++)
            {
                currentItemsDisplayed.Add(list.Items[i].ToString());
            }

            if (selectedDatabaseNames.ContainsKey(itemName))
                selectedDatabaseNames[itemName] = isChecked;
            else
                selectedDatabaseNames.Add(itemName, isChecked);

            btn_start.Enabled = selectedDatabaseNames.Any(x => x.Value == true);
            //chckbx_select_all_non_system.Checked = _selectedDatabaseNames.Where(x => _userDatabaseNames.Contains(x.Key)).All(x => x.Value == true);
        }

        //Handles when the server name to export from is changed.
        private void txtbx_export_server_name_TextChanged(object sender, EventArgs e)
        {
            FormControls.ClearCheckedDatabases();
        }

        //Allows the user to cancels all processes.
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            SQLPackage.EndProcess();
        }

        #endregion

        #region Import Click Events

        //Used to test the connection to the import server.
        private async void btn_import_connect_Click(object sender, EventArgs e)
        {
            FormControls.EnableLoadingIcon();

            if (!await Utilities.TestConnection(_dbImporter.GetImportConnectionString()))
                return;

            Config.AddUpdateSetting("Import_ServerType", cmbbx_import_server_type.SelectedItem.ToString());
            Config.AddUpdateSetting("Import_ServerName", txtbx_import_server_name.Text);
            Config.AddUpdateSetting("Import_Username", txtbx_import_username.Text);
            Config.AddUpdateSetting("Import_Password", txtbx_import_password.Text);
        }

        //Used to select the import folder containing the database bacpacs.
        private void btn_import_browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            if (browser.ShowDialog() == DialogResult.OK)
            {
                txtbx_export_output_folder.Text = browser.SelectedPath;
                Config.AddUpdateSetting("Import_SourceFolder", browser.SelectedPath);
                _sourceFolderPath = $"{browser.SelectedPath}\\";
            }
        }

        //Used to handle when the import server type dropdown is changed.
        private void cmbbx_import_server_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemName = cmbbx_import_server_type.SelectedItem.ToString();

            FormControls.ToggleUserDetailsFields(true);
            txtbx_import_username.Text = "";
            txtbx_import_password.Text = "";

            switch (itemName)
            {
                case "Azure SQL Database":
                    break;

                case "Microsoft SQL Server (Local)":
                    FormControls.ToggleUserDetailsFields(false);
                    break;

                case "Microsoft SQL Server (Remote)":
                    break;

                default:
                    break;
            }
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyDB.Classes
{
    class FormControls
    {
        public static MainForm form { get; set; }

        public FormControls() {}

        public FormControls(MainForm _form)
        {
            form = _form;
        }
        
        //Gets the appsettings for the export input fields.
        public static void GetExportSettings()
        {
            //Export Settings
            form.txtbx_export_server_name.Text = Config.ReadSetting("Export_ServerName");
            form.txtbx_export_username.Text = Config.ReadSetting("Export_Username");
            form.txtbx_export_password.Text = Config.ReadSetting("Export_Password");
            form.txtbx_export_output_folder.Text = Config.ReadSetting("Export_OutputFolder");
        }

        //Gets the appsettings for the import input fields.
        public static void GetImportSettings()
        {
            //Import Settings
            form.cmbbx_import_server_type.Items.AddRange(form._serverTypeNames.ToArray());
            int index = form._serverTypeNames.FindIndex(x => x == Config.ReadSetting("Import_ServerType"));

            form.cmbbx_import_server_type.SelectedIndex =  index >= 0 ? index : 0;
            form.txtbx_import_server_name.Text = Config.ReadSetting("Import_ServerName");
            form.txtbx_import_username.Text = Config.ReadSetting("Import_Username");
            form.txtbx_import_password.Text = Config.ReadSetting("Import_Password");
            form.txtbx_import_source_folder.Text = Config.ReadSetting("Export_OutputFolder");
        }

        //Enables and disables the loading icon when the application is processing.
        public static void EnableLoadingIcon(bool val = true)
        {
            form.picBx_loadingicon.Visible = val;
            form.btn_cancel.Visible = val;
        }

        //Used to output debug content to the windows form application.
        public static void OutputToApp(string text = "")
        {
            TextBox output = form.txtbx_output;

            output.Invoke(new Action(() =>
            {
                if (string.IsNullOrEmpty(output.Text))
                    output.AppendText($"{DateTime.Now.ToString("HH:mm:ss")} {text}");
                else
                    output.AppendText($"{Environment.NewLine}{DateTime.Now.ToString("HH:mm:ss")} {text}");
            }));
        }

        //Clears the output textbox on the windows form application.
        public static void ClearOutputToApp()
        {
            form.txtbx_output.Invoke(new Action(() =>
            {
                form.txtbx_output.Clear();
            }));
        }

        //Enables and disables the username and password fields.
        public static void ToggleUserDetailsFields(bool val)
        {
            //txtbx_import_server_name.Enabled = true;
            form.txtbx_import_username.Enabled = val;
            form.txtbx_import_password.Enabled = val;
        }

        //Updates the CheckedList to include items based on the checkboxes.
        public static void UpdateDatabasesCheckedList(List<string> names)
        {
            CheckedListBox listbox = form.checkedListBox_databases;

            listbox.Items.Clear();
            listbox.Items.AddRange(names.ToArray());

            if (form.selectedDatabaseNames.Count == 0)
                return;

            CheckedListBox.ObjectCollection items = listbox.Items;

            for (int i = 0; i < items.Count; i++)
            {
                if (form.selectedDatabaseNames.ContainsKey(items[i].ToString()))
                    listbox.SetItemChecked(i, form.selectedDatabaseNames[items[i].ToString()]);
            }
        }

        //Clears the selected databases from the checkedlist element.
        public static void ClearCheckedDatabases()
        {
            form.checkedListBox_databases.Items.Clear();
            form.selectedDatabaseNames.Clear();
            form.databaseNamesFull.Clear();
            form.userDatabaseNames.Clear();
        }

        //Toggles all elements while the application is processing.
        public static void ToggleAllElements(bool val)
        {
            EnableLoadingIcon(!val);
            form.tbcntrl_tabs.Enabled = val;
        }

        //Toggles the start button.
        public static void ToggleStartButton(bool val)
        {
            form.btn_start.Enabled = val;
        }
    }
}

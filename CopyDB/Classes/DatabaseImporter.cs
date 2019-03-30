using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyDB.Classes
{
    class DatabaseImporter
    {
        public static string _backupFolderPath;

        public DatabaseImporter() { }

        public DatabaseImporter(string backupFolderPath)
        {
            _backupFolderPath = backupFolderPath;
        }
        
        //Used to import the backups from the specified backup folder.
        public async Task ImportDatabases(List<string> databases, string connectionString)
        {
            string folderPath = $"{_backupFolderPath}{ DateTime.Now.ToString("dd-MM-yyyy")}\\";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    //Try to open the server connection.
                    conn.Open();
                    FormControls.OutputToApp("Importing databases...");

                    for (int i = 0; i < databases.Count; i++)
                    {
                        //Setup command for sql.
                        FormControls.OutputToApp($"Dropping database: {databases[i]}");
                        string sqlCommand = $"DROP DATABASE IF EXISTS {databases[i]}";
                        SqlCommand cmd = new SqlCommand(sqlCommand, conn);
                        cmd.ExecuteNonQuery();

                        await SQLPackage.Run("Import", databases[i], connectionString, folderPath);
                    }
                }
            }
            catch (Exception e)
            {
                FormControls.OutputToApp($"Error: {e}");
            }

            FormControls.OutputToApp("Finished Importing");
        }

        //Gets the combined connection string for importing.
        public string GetImportConnectionString()
        {
            string connectionString = "";

            if (FormControls.form.cmbbx_import_server_type.SelectedItem.ToString() == "Microsoft SQL Server (Local)")
                connectionString = $"Data Source = {FormControls.form.txtbx_import_server_name.Text}; Integrated Security = SSPI; Connection Timeout = 5;";
            else
                connectionString = $"Data Source = {FormControls.form.txtbx_import_server_name.Text}; User ID = {FormControls.form.txtbx_import_username.Text}; Password = {FormControls.form.txtbx_import_password.Text}; Connection Timeout = 5;";

            return connectionString;
        }
    }
}

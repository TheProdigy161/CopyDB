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
    class DatabaseExporter
    {
        public static string _backupFolderPath;

        public DatabaseExporter() { }

        public DatabaseExporter(string backupFolderPath)
        {
            _backupFolderPath = backupFolderPath;
        }

        //Gets the available databases that can be exported.
        public async Task<List<string>> GetDatabaseNames(string connectionString)
        {
            List<string> databaseNames = new List<string>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    //Try to open the server connection.
                    await conn.OpenAsync();

                    //Set the command to be called by the server and set the datareader.
                    SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases", conn);
                    SqlDataReader reader = await cmd.ExecuteReaderAsync();

                    //Loop through all of the database names and select the ones that are Randox Health specific.
                    while (reader.Read())
                    {
                        Console.WriteLine($"Database name: {reader[0].ToString()}");

                        databaseNames.Add(reader[0].ToString());
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            databaseNames.Sort();
            return databaseNames;
        }

        //Used to export the database backup from LIVE to a local folder.
        public async Task<bool> ExportDatabases(List<string> databases, string connectionString)
        {
            string folderPath = $"{_backupFolderPath}{DateTime.Now.ToString("dd-MM-yyyy")}\\";
            FormControls.ToggleAllElements(false);
            Directory.CreateDirectory(folderPath);


            for (int i = 0; i < databases.Count; i++)
            {
                if (!await SQLPackage.Run("Export", databases[i], connectionString, folderPath))
                {
                    FormControls.ClearOutputToApp();
                    return false;
                }
            }
            
            FormControls.OutputToApp("------------------");
            FormControls.OutputToApp("Finished Exporting");

            return true;
        }

        //Gets the combined connection string for importing.
        public string GetExportConnectionString()
        {
            string connectionString = $"Data Source = {FormControls.form.txtbx_export_server_name.Text}; User ID = {FormControls.form.txtbx_export_username.Text}; Password = {FormControls.form.txtbx_export_password.Text}; Connection Timeout = 5;";

            return connectionString;
        }
    }
}

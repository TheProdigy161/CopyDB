using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyDB.Classes
{
    class Utilities
    {
        //Tests the given connection string to see whether a connection can be made with the SQL Server.
        public static async Task<bool> TestConnection(string connectionString, bool silent = false, bool popup = false)
        {
            //Gets the server name from the connection string, but only if the data source is at the start of the string.
            string serverName = connectionString.Split(';')[0].Split('=')[1].Trim();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    await conn.OpenAsync();
                    if (!silent)
                    {
                        if (!popup)
                            FormControls.OutputToApp($"Connection to \"{serverName}\" successful!");
                        else
                            MessageBox.Show($"Connection to \"{serverName}\" successful!");
                    }
                    FormControls.ToggleAllElements(true);
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Connection to \"{serverName}\" failed. {e.Message}");
                FormControls.ToggleAllElements(true);
                FormControls.ToggleStartButton(true);
                FormControls.ClearOutputToApp();
                return false;
            }
        }
    }
}
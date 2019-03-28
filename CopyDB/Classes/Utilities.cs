using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyDB.Classes
{
    class Utilities
    {
        //Tests the given connection string to see whether a connection can be made with the SQL Server.
        public static async Task<bool> TestConnection(string connectionString, bool silent = false)
        {
            FormControls.ToggleAllElements(false);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    await conn.OpenAsync();
                    if (!silent) FormControls.OutputToApp("Connection successful!");
                    FormControls.ToggleAllElements(true);
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Connection failed. {e.Message}");
                FormControls.ToggleAllElements(true);
                return false;
            }
        }
    }
}

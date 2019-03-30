using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Management;

namespace CopyDB.Classes
{
    static class SQLPackage
    {
        private static Process process;

        //Used to run sqlpackage.exe which is needed to export/import databases.
        public static async Task<bool> Run(string action, string database, string connectionString, string backupFolderPath)
        {
            return await Task.Run(() =>
            {
                //Make sure that the action string is in the right format.
                action = action.First().ToString().ToUpper() + action.Substring(1).ToLower();

                string[] templates = { "tf", "scs" };

                if (!action.ToUpper().Equals("IMPORT") && !action.ToUpper().Equals("EXPORT"))
                    return false;

                if (action.ToUpper().Equals("IMPORT"))
                {
                    templates[0] = "sf";
                    templates[1] = "tcs";
                }

                string command = $"SqlPackage.exe /a:{action} /{templates[0]}:\"{backupFolderPath}{database}.bacpac\" /{templates[1]}:\"{connectionString}; Initial Catalog={database}\"";

                Console.WriteLine($"{action}ing database: {database}");

                ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", @"/c cd C:\Program Files\Microsoft SQL Server\150\DAC\bin & " + command);

                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.RedirectStandardInput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true; //makes the window visible when false.

                using (process = new Process())
                {
                    try
                    {
                        process.StartInfo = procStartInfo;
                        process.Start();

                        FormControls.OutputToApp(process.Id.ToString());

                        while (!process.StandardOutput.EndOfStream)
                        {
                            string line = process.StandardOutput.ReadLine();
                            // do something with line
                            Console.WriteLine(line);
                            FormControls.OutputToApp(line);
                        }
                        // Add this: wait until process does its work
                        process.WaitForExit();

                        // and only then read the result
                        string result = process.StandardOutput.ReadToEnd();
                        Console.WriteLine(result);

                        //process.Dispose();

                        if (process.ExitCode == 0)
                            return true;
                        else
                            return false;
                    }
                    catch (Exception e)
                    {
                        FormControls.OutputToApp("Failed to export.");
                        return false;
                    }
                }
            });
        }

        //Ends the process for exporting/importing the databases.
        public static void EndProcess()
        {
            //Contained within a try/catch incase the user presses the cancel button too many times.
            try
            {
                Process[] sqlP = Process.GetProcessesByName("SqlPackage");

                foreach (Process p in sqlP)
                {
                    p.Kill();
                    p.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

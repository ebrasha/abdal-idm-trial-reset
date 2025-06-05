using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdal_Security_Group_App.Core
{
    internal class ProcessTerminator
    {
        // This method continuously tries to kill specific processes until none of them remain
        public static void KillProcessesUntilGone()
        {
            // List of target process names (without ".exe")
            string[] processNames = new string[]
            {
            "IDMan",
            "IDMIntegrator64",
            "IDMGrHlp",
            "IDMMsgHost",
            "idmBroker",
            "IEMonitor",
            "MediumILStart"
            };

            // Loop until all specified processes are terminated
            while (true)
            {
                bool anyProcessKilled = false;

                foreach (string procName in processNames)
                {
                    Process[] running = Process.GetProcessesByName(procName);

                    foreach (Process proc in running)
                    {
                        try
                        {
                            proc.Kill();
                            proc.WaitForExit();
                            anyProcessKilled = true;
                            //Console.WriteLine($"[INFO] Process {proc.ProcessName} (ID: {proc.Id}) was terminated.");
                        }
                        catch (Exception ex)
                        {
                            //Console.WriteLine($"[ERROR] Failed to terminate {proc.ProcessName}: {ex.Message}");
                        }
                    }
                }

                // Check if all processes are gone
                bool allGone = processNames.All(name => Process.GetProcessesByName(name).Length == 0);

                if (allGone)
                {
                    //Console.WriteLine("[INFO] All target processes have been terminated.");
                    break;
                }

                // Short delay before checking again
                Thread.Sleep(500);
            }
        }
    }
}

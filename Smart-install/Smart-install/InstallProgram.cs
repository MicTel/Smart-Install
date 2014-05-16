using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading;
using System.Collections.Generic;

namespace Smart_install
{
    /// <summary>
    /// Shell for the sample.
    /// </summary>
    class InstallProgram
    {
        private MenuInstall _parent;
        public void StartInstallPrograms(List<programInformation> programList)
        {

            foreach (programInformation CurrentSetup in programList)
            {
                try
                {
                    Process p = Process.Start(control.getExtractProgram(CurrentSetup));
                    while (!p.HasExited)
                    {
                        //Console.WriteLine("Uruchomiony " + CurrentSetup.Name);
                        Thread.Sleep(1000);
                    }
                }
                catch
                { }
                if (_parent.InvokeRequired)
                    _parent.Invoke(new Action(_parent.ChangeStatus));
                else
                    _parent.ChangeStatus();
            }

            //return koncowy dla Natalii
        }

        public InstallProgram(MenuInstall menu)
        {
            _parent = menu;
        }

    }
}
using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading;
using System.Collections.Generic;

namespace MyProcessSample
{
    /// <summary>
    /// Shell for the sample.
    /// </summary>
    class InstallProgram
    {

        void StartInstallPrograms(List<programInformation> programList)
        {

            foreach (programInformation CurrentSetup in programList)
            { 
                Process.Start(control.getExtractProgram(CurrentSetup)); 
                while (Process.GetProcessesByName(CurrentSetup.Name).Length != 0)
                {
                    //Console.WriteLine("Uruchomiony " + CurrentSetup.Name);
                    Thread.Sleep(1000);
                }

                //return po kazdym programie

            }

            //return koncowy dla Natalii
        }


    }
}
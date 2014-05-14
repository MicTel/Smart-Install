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



        void StartInstallPrograms()
        {

            List<String> programList = new List<String>();

            programList.Add("notepad");
            programList.Add("mspaint");
            programList.Add("calc");

            foreach (String CurrentSetup in programList)
            {
                Process.Start(CurrentSetup);
                while (Process.GetProcessesByName(CurrentSetup).Length != 0)
                {
                    Console.WriteLine("Uruchomiony " + CurrentSetup);
                    Thread.Sleep(1000);
                }

            }
        }


    }
}
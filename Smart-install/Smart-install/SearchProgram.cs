using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Smart_install
{
    class SearchProgram
    {

        /*public static void Main()
        {
            //GetProgramList();
            foreach (String item in GetProgramList())
                Console.WriteLine(item);
        }*/

        public static List<string> GetProgramList()
        {
            List<string> ProgramsList = new List<string>();
            string displayName;
            RegistryKey key;

            // poszukiwanie: CurrentUser
            key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
            foreach (String keyName in key.GetSubKeyNames())
            {
                RegistryKey subkey = key.OpenSubKey(keyName);
                displayName = subkey.GetValue("DisplayName") as string;
                if (displayName != null)
                    ProgramsList.Add(displayName);
            }

            // poszukiwanie: LocalMachine_32
            key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
            foreach (String keyName in key.GetSubKeyNames())
            {
                RegistryKey subkey = key.OpenSubKey(keyName);
                displayName = subkey.GetValue("DisplayName") as string;
                if (displayName != null)
                    ProgramsList.Add(displayName);
            }

            // poszukiwanie: LocalMachine_64
            key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall");
            foreach (String keyName in key.GetSubKeyNames())
            {
                RegistryKey subkey = key.OpenSubKey(keyName);
                displayName = subkey.GetValue("DisplayName") as string;
                if (displayName != null)
                    ProgramsList.Add(displayName);
            }

            // NOT FOUND
            return ProgramsList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Diagnostics;

namespace Smart_install
{
    class SearchProgram
    {
        public struct InstallProgram
        {
            public string displayName;
            public string displayVersion;
            public string comments;
            public string contact;
            public string helpLink;
            public string installDate;
            public string installLocation;
            public string language;
            public string modifyPath;
        }

        //public static void Main()
        //{
        //    //GetProgramList();
        //    foreach (InstallProgram item in GetProgramList())
        //    {
        //        Console.WriteLine("DisplayName: " + item.displayName);
        //        Console.WriteLine("DisplayVersion: " + item.displayVersion);
        //        Console.WriteLine("Comments: " + item.comments);
        //        Console.WriteLine("Contact: " + item.contact);
        //        Console.WriteLine("HelpLink: " + item.helpLink);
        //        Console.WriteLine("InstallDate: " + item.installDate);
        //        Console.WriteLine("InstallLocation: " + item.installLocation);
        //        Console.WriteLine("Language: " + item.language);
        //        Console.WriteLine("ModifyPath: " + item.modifyPath);
        //        Console.WriteLine("----------------------------------------------");
        //    }

        //    //Na temat wersji programu
        //    string tmpFileName = "G:\\FirefoxDownloads\\Alcohol52.exe";
        //    AboutProgram(tmpFileName);

        //    Console.Read();
        //}

        //pobieranie ikon
        public static void GetIcon()
        {
            int i = 0;
            //dir - zmienna przechowująca director z ktorego ma być wyciągana ikona (wyciąga wszystkie pliki!)
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\\Windows\\");
            foreach (System.IO.FileInfo file in dir.GetFiles())
            {
                Icon ico = Icon.ExtractAssociatedIcon(file.FullName);
                Bitmap bmp = ico.ToBitmap(); //transformacja do bitmapy (lepsza jakośc niz z ico)
                bmp.Save("C:\\Ikony\\" + i + ".png"); // zapis bitmapy (i - nazwa pliku)
                i++;
            }
        }

        //wywoływanie informacji z .exe
        public static programInformation AboutProgram(string fileName)
        {
            FileVersionInfo AboutThisFile = FileVersionInfo.GetVersionInfo(fileName);
            //wypisanie na ekran do testu;
            //odwołanie jest przez zmienna AboutThisFile + metoda, jeżeli potrzeba innych to piszcie
            //Console.WriteLine("InternalName: " + AboutThisFile.InternalName);
            //Console.WriteLine("FileVersion: " + AboutThisFile.FileVersion);
            //Console.WriteLine("FileDescription: " + AboutThisFile.FileDescription);
            //Console.WriteLine("Product: " + AboutThisFile.ProductName);

            string name;
            try
            {
                name = ((string[])
                    (AboutThisFile.OriginalFilename.Split(new char[] { '.' })))[0];
            }
            catch
            {
                name = ((string[])
                    (AboutThisFile.FileName.Split(new char[] {'\\'}))).Last();
                name = ((string[])
                    (name.Split(new char[] { '.' })))[0];
            }

            programInformation progr = new programInformation()
            {
                Version = AboutThisFile.ProductVersion,
                Description = AboutThisFile.FileDescription,
                Path = fileName,
                Language = AboutThisFile.Language,
                Name = name
            };
            return progr;
        }

        //wywoływanie infomracji z rejestru
        public static List<InstallProgram> GetProgramList()
        {
            List<RegistryKey> key = new List<RegistryKey>();
            List<InstallProgram> ProgramsList = new List<InstallProgram>();
            string displayName;
            InstallProgram tmpInstallProgram = new InstallProgram();

            key.Add(Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall"));
            key.Add(Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall"));
            key.Add(Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall"));

            for (int i = 0; i < 3; i++)
                foreach (String keyName in key[i].GetSubKeyNames())
                {
                    RegistryKey subkey = key[i].OpenSubKey(keyName);
                    displayName = subkey.GetValue("DisplayName") as string;

                    if (displayName != null)
                    {
                        tmpInstallProgram.displayName = subkey.GetValue("DisplayName") as string;
                        tmpInstallProgram.displayVersion = subkey.GetValue("DisplayVersion") as string;
                        tmpInstallProgram.comments = subkey.GetValue("Comments") as string;
                        tmpInstallProgram.contact = subkey.GetValue("Contact") as string;
                        tmpInstallProgram.helpLink = subkey.GetValue("HelpLink") as string;
                        tmpInstallProgram.installDate = subkey.GetValue("InstallDate") as string;
                        tmpInstallProgram.installLocation = subkey.GetValue("InstallLocation") as string;
                        tmpInstallProgram.language = subkey.GetValue("Language") as string;
                        tmpInstallProgram.modifyPath = subkey.GetValue("ModifyPath") as string;
                    }
                    ProgramsList.Add(tmpInstallProgram);
                }
            return ProgramsList;
        }
    }
}

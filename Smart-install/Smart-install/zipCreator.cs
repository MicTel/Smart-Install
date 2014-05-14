using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Smart_install
{
    /// <summary>
    /// Klasa służąca do obsługi archiw(tworzenie, rozszerzanie, usuwanie)
    /// </summary>
    static class zipCreator
    {
        /// <summary>
        /// Metoda tworząca archiwum.
        /// </summary>
        /// <param name="name">Nazwa archiwum</param>
        /// <param name="destinyPath">Scieżka, gdzie zostanie utworzone archwium</param>
        /// <param name="filePath">Nazwa utworzonego archiwum zip</param>
        public static void createArchive(string destinyPath, string filePath)
        {
            DirectoryInfo direct = Directory.CreateDirectory("Archiwum");
            System.IO.File.Copy(filePath, direct.FullName + "\\" + filePath, true);

            ZipFile.CreateFromDirectory(direct.FullName, destinyPath, CompressionLevel.NoCompression, false);
            direct.Delete(true);
        }

        /// <summary>
        /// Metoda dodająca plik do archiwum.
        /// </summary>
        /// <param name="toAdd">Plik dodawany</param>
        /// <param name="whereAdd">Scieżka do archwium, do którego zostanie dodany plik</param>
        /// <param name="name">Nazwa pliku</param>
        public static void addToArchive(string toAdd, string whereAdd, string name)
        {
            using (ZipArchive archive = ZipFile.Open(whereAdd, ZipArchiveMode.Update))
            {
                archive.CreateEntryFromFile(toAdd,name);
            }
        }

        /// <summary>
        /// Metoda usuwająca wskazany plik z dysku
        /// </summary>
        /// <param name="path">Scieżka do usuwanego pliku</param>
        public static void deleteFile(string path)
        {
            File.Delete(path);
        }

        /// <summary>
        /// Metoda służąca do rozpakowania archiwum zip.
        /// </summary>
        /// <param name="filePath">Nazwa utworzonego archiwum zip</param>
        /// <param name="extractPath">nazwa po rozpakowaniu</param>
        public static void unzipFileFromArchive(string filePath, string extractPath)
        {
            ZipFile.ExtractToDirectory(filePath, extractPath);
        }

        /// <summary>
        /// Metoda służąca do rozpakowania i zwracania adresu rozpakowywanego pliku.
        /// </summary>
        /// <param name="path">Ścieżka do archiwum zip</param>
        /// <returns></returns>
        internal static string getXML(string path)
        {
            using (ZipArchive archive = ZipFile.Open(path, ZipArchiveMode.Read))
            {
                ZipArchiveEntry entry = archive.Entries.First(x => x.Name.Split(new char[] { '.' }).Last() == "xml");
                return getFile(path, entry.Name);
            } 
        }

        /// <summary>
        /// Metoda służąca do rozpakowania pliku.
        /// </summary>
        /// <param name="path">Scieżka do archiwum zip</param>
        /// <param name="name">Nazwa wyodrębnionego pliku</param>
        /// <returns></returns>
        public static string getFile(string path, string name)
        {
            string tempDirectory = Path.GetTempPath();
            using (ZipArchive archive = ZipFile.Open(path, ZipArchiveMode.Read))
            {
                ZipArchiveEntry zipEntry = archive.GetEntry(name);
                string newPath = Path.Combine(tempDirectory,name);
                zipEntry.ExtractToFile(newPath);

                return newPath;
            }   
        }

        /// <summary>
        /// Metoda służąca do kopiowania jednego z archiwum do drugiego.
        /// </summary>
        /// <param name="destinyPath">Scieżka archiwum, do którego kopiujemy</param>
        /// <param name="sourcePath">Źródło archwium do któego kopiujemy</param>
        /// <param name="sourceFile">Nazwa pliku archwium źródłowego</param>
        /// 

        
        public static void copyBetweenArchive(string destinyPath, string sourcePath, string sourceFile)
        {
            string sourceFileExtracted = getFile(sourcePath, sourceFile);
            addToArchive(sourceFileExtracted, destinyPath, sourceFile);
            deleteFile(sourceFileExtracted);
        }


    
    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Smart_install
{
    class zipCreator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Nazwa archiwum</param>
        /// <param name="destinyPath">Gdzie ma powstać</param>
        /// <param name="filePath">nazwa zip</param>
        public static void createArchive(string destinyPath, string filePath)
        {
            DirectoryInfo direct = Directory.CreateDirectory("Archiwum");
            System.IO.File.Copy(filePath, direct.FullName + "\\" + filePath, true);

            ZipFile.CreateFromDirectory(direct.FullName, destinyPath, CompressionLevel.NoCompression, false);
            direct.Delete(true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="toAdd">co dodajemy</param>
        /// <param name="whereAdd">gdzie dodajemy</param>
        /// <param name="name">nazwa pliku</param>
        public static void addToArchive(string toAdd, string whereAdd, string name)
        {
            using (ZipArchive archive = ZipFile.Open(whereAdd, ZipArchiveMode.Update))
            {
                archive.CreateEntryFromFile(toAdd,name);
            }
        }

        /// <summary>
        /// Usuwa wskazy plik z dysku
        /// </summary>
        /// <param name="path">sciezka do usuwanego pliku</param>
        public static void deleteFile(string path)
        {
            File.Delete(path);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath">nazwa zip</param>
        /// <param name="extractPath">nazwa po rozpakowaniu</param>
        public static void unzipFileFromArchive(string filePath, string extractPath)
        {
            ZipFile.ExtractToDirectory(filePath, extractPath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path">sciezka do archiwum</param>
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
        /// 
        /// </summary>
        /// <param name="path">sciezka do archiwum</param>
        /// <param name="name">nazwa wyodrebnionego pliku</param>
        /// <returns></returns>
        public static string getFile(string path, string name)
        {
            using (ZipArchive archive = ZipFile.Open(path, ZipArchiveMode.Read))
            {
                ZipArchiveEntry zipEntry = archive.GetEntry(name);
                zipEntry.ExtractToFile(Path.GetTempPath());
                return Path.GetTempPath() + "." + name;
            }   
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="destinyPath">sciezka archiwum, do którego kopiujemy</param>
        /// <param name="sourcePath">źródło archwium do któego kopiujemy</param>
        /// <param name="sourceFile">nazwa pliku archwium źródłowego</param>
        public static void copyBetweenArchive(string destinyPath, string sourcePath, string sourceFile)
        {
            string sourceFileExtracted = getFile(sourcePath, sourceFile);
            addToArchive(sourceFileExtracted, destinyPath, sourceFile);
            deleteFile(sourceFileExtracted);
        }


    
    
    }
}

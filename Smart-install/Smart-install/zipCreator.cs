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
        public static void createArchive(string name, string destinyPath, string filePath)
        {
            ZipFile.CreateFromDirectory(filePath, destinyPath, CompressionLevel.NoCompression, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="toAdd">co dodajemy</param>
        /// <param name="whereAdd">gdzie dodajemy</param>
        /// <param name="name">nazwa pliku</param>
        public static void addToArchive(List<string> toAdd, string whereAdd, List<string> name)
        {
            foreach (string newFile in toAdd)
            {
                using (ZipArchive archive = ZipFile.Open(whereAdd, ZipArchiveMode.Update))
                {
                    archive.CreateEntryFromFile(newFile, "name");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pathArchive">sciezka do archiwum</param>
        public static void deleteArchive(string pathArchive)
        {
            File.Delete(pathArchive);
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
    }
}

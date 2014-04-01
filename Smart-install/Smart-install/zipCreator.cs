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

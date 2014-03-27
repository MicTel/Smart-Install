using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_install
{

    /// <summary>
    /// Klasa reprezentująca informację na temat archiwum uzyskiwane od urzytkownika
    /// </summary>
    public class archiveInformation
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
    }

    /// <summary>
    /// Klasa reprezentująca informację na temat programu uzyskiwane od urzytkownika
    /// </summary>
    public class programInformation
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public string HelpLink { get; set; }
        public string URLUpdate { get; set; }
        public string Publisher { get; set; }
        public string Path { get; set; }
        public string Icon { get; set; }

        public string Language { get; set; }
        public string systemType { get; set; }
        public List<string> Tags { get; set; }
    }

    public class control
    {
        /// <summary>
        /// Zwraca listę wszystkich tagów z bazy danych
        /// </summary>
        /// <returns></returns>
        public static List<string> getTags()
        {
            ArchiveBaseEntities2 database = new ArchiveBaseEntities2();
            List<Tag> tags = database.Tags.ToList();
            List<string> tagList = new List<string>();
            foreach (Tag tag in tags)
            {
                tagList.Add(tag.TagName.ToString());
            }

            return tagList;
        }

        /// <summary>
        /// Zwraca true jesżeli któryś tag z fromProg jest zawarty w fromUser
        /// </summary>
        /// <param name="fromProg">Tagi jakie zawiera program</param>
        /// <param name="fromUser">Nazwy tagów szukanych</param>
        /// <returns></returns>
        private static bool _checkTag(List<Tag> fromProg, List<string> fromUser)
        {
            foreach (Tag tag in fromProg)
            {
                if (fromUser.Exists(x => x==tag.TagName))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Zwraca listę programów które należą do poszczególnych kategorii
        /// </summary>
        /// <param name="selectedTags">wybrane przez użytkownika komponenty</param>
        /// <returns></returns>
        public static List<string> getPrograms(List<string> selectedTags)
        {
            ArchiveBaseEntities2 database = new ArchiveBaseEntities2();
            var prog = from p in database.Progs
                              where _checkTag(p.Tags.ToList<Tag>(), selectedTags)
                              select p.Name;
            
            List<string> progString = new List<string>();
            foreach (var p in prog)
            {
                progString.Add(p.ToString());
            }

            return progString;
        }

        /// <summary>
        /// Funkcja dodająca tagi
        /// </summary>
        /// <param name="tagName">Nazwa tagu</param>
        public static void addTags(string tagName)
        {

            ArchiveBaseEntities2 database = new ArchiveBaseEntities2();
            Tag p = database.Tags.OrderByDescending(c => c.Id).FirstOrDefault();
            int newId = (null == p ? 0 : p.Id) + 1;
            Tag tag = new Tag()
            {
                Id = newId,
                TagName = tagName
            };
            database.Tags.Add(tag);
            try
            {
                database.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        
        //public static Prog checkProgram(string path)
        //{
        //    return SearchProgram.findInformationAboutSetup(path);
        //}


        /// <summary>
        /// Dodawanie programu do bazy danych (bez wiązania z archiwum)
        /// </summary>
        /// <param name="toDatabase">Dane o programie</param>
        /// <param name="path">Ścieżka do programu</param>
        public static void addProgram(programInformation toDatabase)
        {
            ArchiveBaseEntities2 database = new ArchiveBaseEntities2();
            Prog p = database.Progs.OrderByDescending(c => c.Id).FirstOrDefault();
            int newId = (null == p ? 0 : p.Id) + 1;
            Prog program = new Prog()
            {
                Id = newId,
                Description = toDatabase.Description,
                HelpLink = toDatabase.HelpLink,
                Name = toDatabase.Name,
                Publisher = toDatabase.Publisher,
                Icon = toDatabase.Icon,
                URLUpdate = toDatabase.URLUpdate,
                Version = toDatabase.Version
            };
            database.Progs.Add(program);
            try
            {
                database.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void createArchive(List<programInformation> programs, string name, string pathArchive)
        {
            string fullArchiveName = pathArchive + name;
            zipCreator.createArchive(pathArchive, programs[0].Path);
            
            ArchiveBaseEntities2 database = new ArchiveBaseEntities2();
            
            foreach (programInformation p in programs)
            {
                addProgram(p);
            }
            database.SaveChanges();
        }
        
    }
}

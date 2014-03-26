using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_install
{
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

            database.Archives.ToList();
            return prog.ToList<string>();
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
        public static void addProgram(Prog toDatabase, string path )
        {
            ArchiveBaseEntities2 database = new ArchiveBaseEntities2();
            database.Progs.Add(toDatabase);
            database.SaveChanges();
        }

        public static void createArchive(List<Prog> programs, List<string> pathsPrograms, string name, string pathArchive)
        {
            zipCreator.createArchive(name, pathArchive, pathsPrograms[0]);
            pathsPrograms.RemoveAt(0);
            //zipCreator.addToArchive(

            ArchiveBaseEntities2 database = new ArchiveBaseEntities2();
            
            foreach (Prog p in programs)
            {
                database.Progs.Add(p);
            
            }
            database.SaveChanges();
        
        }
        
    }
}

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
        /// 
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
        /// 
        /// </summary>
        /// <param name="fromProg"></param>
        /// <param name="fromUser"></param>
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

            return prog.ToList<string>();
        }

        /// <summary>
        /// Funkcja dodająca tagi
        /// </summary>
        /// <param name="tagName">Nazwa tagu</param>
        public static void addTags(string tagName)
        {
            ArchiveBaseEntities2 database = new ArchiveBaseEntities2();
            Tag tag = new Tag()
            {
                TagName = tagName
            };
            database.Tags.Add(tag);
            database.SaveChanges();
        }
    }
}

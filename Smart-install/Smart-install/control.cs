using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Smart_install
{

    /// <summary>
    /// Klasa reprezentująca informację na temat archiwum uzyskiwane od urzytkownika
    /// </summary>
    public class archiveInformation
    {
        public string fullPath { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
    }

    /// <summary>
    /// Klasa reprezentująca informację na temat programu uzyskiwane od urzytkownika
    /// </summary>
    public class programInformation
    {
        public int? Id;
        public bool isChecked { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public string HelpLink { get; set; }
        public string URLUpdate { get; set; }
        //public string Publisher { get; set; }
        public string Icon { get; set; }

        private string _Path;

        public string Path
        {
            get { return _Path; }
            set 
            {   
                _Path = value;
                Id = null;
            }
        }
        
        
        public string Language { get; set; }
        public string systemType { get; set; }
        public List<string> Tags { get; set; }

        public programInformation()
        {
        }

        public programInformation(Prog progr)
        {
            Name = progr.Name;
            Version = progr.Version;
            Description = progr.Description;
            HelpLink = progr.HelpLink;
            URLUpdate = progr.URLUpdate;
            //Publisher = progr.Publisher;
            Path = null;
            Id = progr.Id;
            Language = progr.Language.Language1;
            systemType = progr.systemType.systemType1;
            Tags = new List<string>();
            foreach (Tag tag in progr.Tags)
            {
                Tags.Add(tag.TagName);
            }
        }

        public XElement getXElement()
        {
            XElement[] tags = new XElement[Tags.Count()];
            for (int i = 0; i < Tags.Count; i++)
                tags[i] = new XElement("Tag",
                    new XAttribute("id", i),
                    Tags[i]);
            XElement x = new XElement("Program",
                new XElement("Id", Id),
                new XAttribute("Name", Name),
                new XElement("Description", Description),
                new XElement("Version", Version),
                new XElement("HelpLink", HelpLink),
                new XElement("URLUpdate", URLUpdate),
                new XElement("Language", Language),
                new XElement("systemType", systemType),
                tags);
            return x;
        }
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
        private static bool _checkTag(List<Tag> fromProg, string fromUser)
        {
            foreach (Tag tag in fromProg)
            {
                if (fromUser==tag.TagName)
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
        public static List<string> getPrograms(string selectedTag)
        {
            ArchiveBaseEntities2 database = new ArchiveBaseEntities2();
            var prog = from p in database.Progs
                              where _checkTag(p.Tags.ToList<Tag>(), selectedTag)
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
        /// Dodawanie programu do bazy danych, a następnie dodaje go do archiwum
        /// </summary>
        /// <param name="toDatabase">Dane o programie</param>
        /// <param name="arch">Nowe archiwum</param>
        public static void addNewProgram(programInformation toDatabase, archiveInformation arch)
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
                //Publisher = toDatabase.Publisher,
                Icon = toDatabase.Icon,
                URLUpdate = toDatabase.URLUpdate,
                Version = toDatabase.Version
            };
            database.Progs.Add(program);
            try
            {
                database.SaveChanges();
                //zipCreator.addToArchive(toDatabase.Path, arch.fullPath, toDatabase.Name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
            
        /// <summary>
        /// NIE DZIAŁA
        /// 
        /// </summary>
        /// <param name="programInf"></param>
        /// <param name="arch"></param>
        public static void addOldProgram(programInformation programInf, archiveInformation arch)
        {
            ArchiveBaseEntities2 database = new ArchiveBaseEntities2();
            Prog progr = (from p in database.Progs
                            where p.Id == programInf.Id
                            select p).First();
            int i=0;
            //while(!zipCreator.copyBetweenArchive(progr.Archives.,arch.fullPath))
            {
                i++;
            }
        }


        /// <summary>
        /// Inicjuje archiwum, poprzez stworzenie go oraz zamieszczenie w nim plik
        /// informacyjnego, na temat jest zawartości.
        /// </summary>
        /// <param name="arch">Inicjonowane archiwum</param>
        public static void startArchive(archiveInformation arch,List<programInformation> programs)
        {
            string fileName = arch.Name + ".xml";
            XDocument xml = new XDocument(new XElement("Archiwum"));
            XElement root = xml.Root;
            foreach (programInformation p in programs)
                root.Add(p.getXElement());
            xml.Save(fileName);
            zipCreator.createArchive(arch.fullPath, fileName);
            zipCreator.deleteArchive(fileName);
        }

        /// <summary>
        /// Tworzenie archiwum i wrzucenie do niego programów.
        /// </summary>
        /// <param name="programs">Lista programów które mają znaleźć się w archiwum.</param>
        /// <param name="arch">Archiwum które ma zostać stworzone.</param>
        public static void createArchive(archiveInformation arch,List<programInformation> programs)
        {
            startArchive(arch,programs);  
            foreach (programInformation p in programs)
            {
                if (p.Id==null)
                    addNewProgram(p, arch);
                else
                    addOldProgram(p, arch);
            }
        }        
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
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
        public List<programInformation> programList;
    }

    /// <summary>
    /// Klasa reprezentująca informację na temat programu uzyskiwane od użytkownika
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
        public Bitmap Icon { get; set; }

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
            isChecked = false;
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
            //Language = progr.Language.Language1;
            //systemType = progr.systemType.systemType1;
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

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Version.GetHashCode() ^ Language.GetHashCode() ^ systemType.GetHashCode();
        }
    }

    public static class control
    {
        /// <summary>
        /// Dodaje jednorazowo tagi do bazy danych
        /// </summary>
        public static void addTagOnce(int many=0)
        {
            try
            {
                ArchiveBaseEntities2 database = new ArchiveBaseEntities2();
                Tag p = database.Tags.OrderByDescending(c => c.Id).FirstOrDefault();
                if (p == null)
                {
                    addTags("System");
                    addTags("Sterowniki");
                    addTags("Narzędzia");
                    addTags("Bezpieczeństwo");
                    addTags("Internet");
                    addTags("Gry");
                    addTags("Biuro");
                    addTags("Grafika");
                    addTags("Multimedia");
                    addTags("Projektowanie");
                    addTags("Programowanie");
                }
            }
            catch
            {
                many++;
                if (many > 1000)
                    throw new Exception("Problem z połączenia z bazą");
                else
                {
                    System.Threading.Thread.Sleep(1000);
                    addTagOnce(many);
                }
            }
        }

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
        public static List<programInformation> getPrograms()
        {
            ArchiveBaseEntities2 database = new ArchiveBaseEntities2();
            var prog = database.Progs;
                              //where _checkTag(p.Tags.ToList<Tag>(), selectedTag)
                              //select p;

            List<programInformation> progInf = new List<programInformation>();
            programInformation newP = null;
            foreach (Prog p in prog)
            {
                newP = new programInformation(p);
                progInf.Add(newP);
            }

            return progInf;
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
                //Icon = toDatabase.Icon,
                URLUpdate = toDatabase.URLUpdate,
                Version = toDatabase.Version
            };

            var tags = database.Tags;
            foreach (string tag in toDatabase.Tags)
            {
                foreach (Tag tagInData in tags)
                {
                    if (tagInData.TagName == tag)
                    {
                        program.Tags.Add(tagInData);
                        break;
                    }
                } 
            }

            database.Progs.Add(program);
            try
            {
                database.SaveChanges();
                zipCreator.addToArchive(toDatabase.Path, arch.fullPath, toDatabase.Name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
            
        /// <summary>
        /// NIE DZIAŁA!!
        /// Kopije program z jednego archiwum do drugiego (nie działa update bazy danych)
        /// </summary>
        /// <param name="programInf">Program do skopiowania</param>
        /// <param name="arch">archiwum do którego kopiujemy</param>
        public static void addOldProgram(programInformation programInf, archiveInformation arch)
        {
            ArchiveBaseEntities2 database = new ArchiveBaseEntities2();
            Prog progr = database.Progs.First(x => x.Id == programInf.Id);
            zipCreator.copyBetweenArchive(arch.fullPath, progr.Archives.First().Path, programInf.Name);
            //database.Entry(database.Progs).State = Enty
        }


        /// <summary>
        /// Inicjuje archiwum, poprzez stworzenie go oraz zamieszczenie w nim plik
        /// informacyjnego, na temat jest zawartości.
        /// </summary>
        /// <param name="arch">Inicjonowane archiwum</param>
        public static void startArchive(archiveInformation arch)
        {
            ArchiveBaseEntities2 database = new ArchiveBaseEntities2();
            Archive arc = database.Archives.OrderByDescending(c => c.Id).FirstOrDefault();
            int newId = (null == arc ? 0 : arc.Id) + 1;
            Archive archive = new Archive()
            {
                Id = newId,
                Description = arch.Description,
                Name = arch.Name,
                //Publisher = toDatabase.Publisher,
                CreateDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Path = arch.fullPath
            };
            database.Archives.Add(archive);
            try
            {
                database.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            string fileName = arch.Name + ".xml";
            XDocument xml = new XDocument(new XElement("Archiwum"));
            XElement root = xml.Root;
            XElement xArch = new XElement("Archive",
                new XElement("Name", archive.Name),
                new XElement("Description", archive.Description),
                new XElement("Id", archive.Id));
            root.Add(xArch);
            foreach (programInformation p in arch.programList)
                root.Add(p.getXElement());
            xml.Save(fileName);
            zipCreator.createArchive(arch.fullPath, fileName);
            zipCreator.deleteFile(fileName);
        }

        /// <summary>
        /// Tworzenie archiwum i wrzucenie do niego programów.
        /// </summary>
        /// <param name="programs">Lista programów które mają znaleźć się w archiwum.</param>
        /// <param name="arch">Archiwum które ma zostać stworzone.</param>
        public static void createArchive(archiveInformation arch,List<programInformation> programs)
        {
            arch.programList = programs;
            startArchive(arch);  
            foreach (programInformation p in arch.programList)
            {
                if (p.Id==null)
                    addNewProgram(p, arch);
                else
                    addOldProgram(p, arch);
            }
        }


        /// <summary>
        /// Otwiera archiwum i pobiera z niego informacje
        /// </summary>
        /// <param name="path">ścieżka do archiwum</param>
        /// <returns>Informacje o archiwum</returns>
        public static archiveInformation getArchiveInformaction(string path)
        {
            string newPath = zipCreator.getXML(path);
            XDocument xdoc = XDocument.Load(newPath);
            XElement xelement = xdoc.Root;
            IEnumerable<XElement> programs = xelement.Elements("Program");
            
            // Read the entire XML
            List<programInformation> progs = new List<programInformation>();
            foreach (var p in programs)
            {
                List<string> tags = new List<string>();
                tags.Add(p.Element("Tag").Value);
                programInformation prog = new programInformation()
                {
                    Description = p.Element("Description").Value,
                    Name = p.Attribute("Name").Value,
                    HelpLink = p.Element("HelpLink").Value,
                    Version = p.Element("Version").Value,
                    URLUpdate = p.Element("URLUpdate").Value,
                    Language = p.Element("Language").Value,
                    systemType = p.Element("systemType").Value,
                    Tags = tags
                };
                progs.Add(prog);
            }
            XElement xArch = xelement.Element("Archive");
             
            archiveInformation arch = new archiveInformation()
            {
                Name = xArch.Element("Name").Value,
                fullPath = path,
                programList = progs,
                Description = xArch.Element("Description").Value
            };

            zipCreator.deleteFile(newPath);
            return arch;
        }


        /// <summary>
        /// Zwraca listę archiw i ich zawartości z bazy danych
        /// </summary>
        /// <returns>Lista archiw</returns>
        public static List<archiveInformation> getArchiveFromDatabase()
        {
            ArchiveBaseEntities2 database = new ArchiveBaseEntities2();
            var archives = database.Archives;

            List<archiveInformation> result = new List<archiveInformation>();

            foreach (Archive a in archives)
            {
                try
                {
                    result.Add(getArchiveInformaction(a.Path));
                }
                catch
                {
                }
            }

            return result;
        }

        public static string getExtracrProgram(programInformation prog)
        {

        }
    }
}

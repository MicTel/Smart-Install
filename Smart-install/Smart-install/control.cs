using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_install
{
    public class control
    {
        public List<string> getTags()
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
    }
}

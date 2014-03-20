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
            DatabaseArchiveEntities database = new DatabaseArchiveEntities();
            List<Tag> tags = database.Tags.ToList();
            List<string> tagList = new List<string>(); 
            foreach (Tag tag in tags)
            {
                tagList.Add(tag.Name.ToString());
            }

            return tagList;
        }
    }
}

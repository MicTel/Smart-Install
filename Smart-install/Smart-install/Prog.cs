//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Smart_install
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prog
    {
        public Prog()
        {
            this.Archives = new HashSet<Archive>();
            this.Tags = new HashSet<Tag>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public string HelpLink { get; set; }
        public string URLUpdate { get; set; }
        public string Publisher { get; set; }
        public string Icon { get; set; }
        public Nullable<int> LanguageID { get; set; }
        public Nullable<int> SystemID { get; set; }
    
        public virtual Language Language { get; set; }
        public virtual systemType systemType { get; set; }
        public virtual ICollection<Archive> Archives { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
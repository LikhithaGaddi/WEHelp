//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEHelp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Institution
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<int> City { get; set; }
        public Nullable<int> InstitutionType { get; set; }
    
        public virtual City City1 { get; set; }
        public virtual ScholorshipType ScholorshipType { get; set; }
        public virtual InstitutionsType InstitutionsType { get; set; }
    }
}
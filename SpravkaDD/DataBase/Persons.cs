//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Persons
    {
        public int Id { get; set; }
        public string login { get; set; }
        public string pass { get; set; }
        public string name { get; set; }
        public string fam { get; set; }
        public int raion { get; set; }
    
        public virtual raion raion1 { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.MyDb
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeHorse
    {
        public int ID { get; set; }
        public int IdEmployee { get; set; }
        public int IdHorse { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Horse Horse { get; set; }
    }
}

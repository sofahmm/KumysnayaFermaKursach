//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KumysnayaFermaKursach.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Horse
    {
        public Horse()
        {
            this.EmployeeHorse = new HashSet<EmployeeHorse>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> IdBreed { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> IdGender { get; set; }
        public Nullable<int> IdType { get; set; }
    
        public virtual Breed Breed { get; set; }
        public virtual ICollection<EmployeeHorse> EmployeeHorse { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Gender Gender1 { get; set; }
        public virtual HorseType HorseType { get; set; }
    }
}

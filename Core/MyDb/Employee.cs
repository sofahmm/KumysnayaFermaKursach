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
    
    public partial class Employee
    {
        public Employee()
        {
            this.EmployeeHorse = new HashSet<EmployeeHorse>();
            this.User = new HashSet<User>();
        }
    
        public int ID { get; set; }
        public Nullable<int> AmountHours { get; set; }
        public string Photo { get; set; }
        public Nullable<int> IdPost { get; set; }
        public string FirstName { get; set; }
        public string Name { get; set; }
    
        public virtual Post Post { get; set; }
        public virtual ICollection<EmployeeHorse> EmployeeHorse { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}

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
    
    public partial class Product
    {
        public Product()
        {
            this.Order = new HashSet<Order>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> IdProductCategory { get; set; }
    
        public virtual ICollection<Order> Order { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
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
    
    public partial class Order
    {
        public int ID { get; set; }
        public string FullNameCustomer { get; set; }
        public Nullable<int> IdProduct { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Sum { get; set; }
        public Nullable<int> IdSposobOplat { get; set; }
        public Nullable<int> IdStatusOrder { get; set; }
        public Nullable<int> IdUnit { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<bool> Oformlenie { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual SposobOplati SposobOplati { get; set; }
        public virtual StatusOrder StatusOrder { get; set; }
        public virtual Unit Unit { get; set; }
    }
}

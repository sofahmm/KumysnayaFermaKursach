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
    
    public partial class StatusSbora
    {
        public StatusSbora()
        {
            this.SborMilk = new HashSet<SborMilk>();
        }
    
        public int ID { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<SborMilk> SborMilk { get; set; }
    }
}

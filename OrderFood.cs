//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sarasi_HMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderFood
    {
        public string orderID { get; set; }
        public string foodID { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<double> total { get; set; }
    
        public virtual Food Food { get; set; }
    }
}

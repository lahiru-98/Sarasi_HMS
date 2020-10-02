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
    
    public partial class Food
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Food()
        {
            this.OrderFoods = new HashSet<OrderFood>();
        }
    
        public string foodCode { get; set; }
        public string categoryID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Nullable<float> sellingPrice { get; set; }
        public Nullable<float> disountRate { get; set; }
        public byte[] foodImage { get; set; }
    
        public virtual FoodCategory FoodCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderFood> OrderFoods { get; set; }
    }
}

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
    
    public partial class Cleaner
    {
        public string cleanerid { get; set; }
        public string ctype { get; set; }
    
        public virtual Cleaner Cleaner1 { get; set; }
        public virtual Cleaner Cleaner2 { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Praksa_V2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Positions
    {
        [Display(Name = "ID pozicije")]
        public int id_position { get; set; }
        [Display(Name = "Latituda")]
        public string latitude { get; set; }
        [Display(Name = "Longituda")]
        public string longitude { get; set; }
        [Display(Name = "Status ta�ke")]
        public string status { get; set; }
        [Display(Name = "ID vozila")]
        public int id { get; set; }
    
        public virtual Cars Cars { get; set; }
    }
}

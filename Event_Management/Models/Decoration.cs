//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Event_Management.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Decoration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Decoration()
        {
            this.Book_Event = new HashSet<Book_Event>();
        }
    
        public int Dec_id { get; set; }
        public string Dec_Type { get; set; }
        public int Range_of_Guest { get; set; }
        public int Dec_Price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book_Event> Book_Event { get; set; }
    }
}

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
    
    public partial class ADD_ON_ITEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ADD_ON_ITEM()
        {
            this.Book_Event = new HashSet<Book_Event>();
        }
    
        public int item_ID { get; set; }
        public string item_Type { get; set; }
        public int Item_Price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book_Event> Book_Event { get; set; }
    }
}

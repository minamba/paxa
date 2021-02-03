//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SinisterWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class Countries
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Countries()
        {
            this.Sites = new HashSet<Sites>();
            this.Users = new HashSet<Users>();
            this.Sinisters = new HashSet<Sinisters>();
        }
    
        public int CountryId { get; set; }
        public string Code { get; set; }
        [DisplayName("Country")]
        public string Name { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> Fictive { get; set; }
        public string ISOCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sites> Sites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Users> Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sinisters> Sinisters { get; set; }
    }
}

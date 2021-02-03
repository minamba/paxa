using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SinisterWebApp.Models.utils_models
{
    public class SinisterStatusViewModel
    {
        public SinisterStatusViewModel()
        {
            this.Sinisters = new HashSet<Sinisters>();
        }

        public int SinisterStatusId { get; set; }

        [DisplayName("Status")]
        public string Name { get; set; }

        public virtual ICollection<Sinisters> Sinisters { get; set; }
    }


    ///////////////////////////////
        public partial class Currencies_
    {
    public Currencies_()
    {
        this.Sinisters = new HashSet<Sinisters>();
    }

    public int CurrencyId { get; set; }
    [DisplayName("Curerncy")]
    public string Name { get; set; }
    public Nullable<bool> Active { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Sinisters> Sinisters { get; set; }
}

    ///////////////////////////////////////////////
    public partial class Countries_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Countries_()
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

    //////////////////////////////////////////////////////////////
    public partial class Sites_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sites_()
        {
            this.Sinisters = new HashSet<Sinisters>();
        }

        public int SiteId { get; set; }
        public string Code { get; set; }
        public Nullable<int> Clientid { get; set; }
        public Nullable<int> CountryId { get; set; }

        [DisplayName("Site")]
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public virtual Clients Clients { get; set; }
        public virtual Countries Countries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sinisters> Sinisters { get; set; }
    }
    ////////////////////////////////////////////////////////
    public partial class SinisterTypes_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SinisterTypes_()
        {
            this.Keywords = new HashSet<Keywords>();
            this.Sinisters = new HashSet<Sinisters>();
        }

        public int SinisterTypeId { get; set; }

        [DisplayName("Type of sinister")]
        public string Name { get; set; }
        public Nullable<int> LobId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Keywords> Keywords { get; set; }
        public virtual Lobs Lobs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sinisters> Sinisters { get; set; }
    }

    //////////////////////////////////////////////////////
    public partial class DestructionLevels_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DestructionLevels_()
        {
            this.Sinisters = new HashSet<Sinisters>();
        }

        public int DestructionLevelId { get; set; }

        [DisplayName("Level of destruction")]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sinisters> Sinisters { get; set; }
    }

    ///////////////////////////////////////
    public partial class ActivitySectors_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ActivitySectors_()
        {
            this.Sinisters = new HashSet<Sinisters>();
        }

        public int ActivitySectorId { get; set; }

        [DisplayName("Activity sector")]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sinisters> Sinisters { get; set; }
    }
}
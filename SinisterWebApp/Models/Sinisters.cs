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
    using System.ComponentModel.DataAnnotations;

    public partial class Sinisters
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sinisters()
        {
            this.SinisterKeywords = new HashSet<SinisterKeywords>();
            this.SinisterLob = new HashSet<SinisterLob>();
        }
    
        public int SinisterId { get; set; }
        public Nullable<int> Clientid { get; set; }
        public Nullable<int> SiteId { get; set; }
        public Nullable<int> SinisterTypeId { get; set; }
        public Nullable<int> ActivitySectorId { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<int> DestructionLevelId { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<int> LoBId { get; set; }
        public string Consequence { get; set; }
        [DisplayName("File origine")]
        public string FileOrigine { get; set; }
        [DisplayName("File name by")]
        public string FileName { get; set; }

        [DisplayName("Aggravating factor")]
        public string AggravatingFactor { get; set; }
        public Nullable<decimal> Amount { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public Nullable<System.DateTime> CreateDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public Nullable<System.DateTime> EditDate { get; set; }
        public Nullable<int> CreateUserId { get; set; }
        public Nullable<int> EditUserId { get; set; }
        public Nullable<int> DocumentId { get; set; }
        public Nullable<int> SinisterStatusId { get; set; }
    
        public virtual ActivitySectors ActivitySectors { get; set; }
        public virtual Clients Clients { get; set; }
        public virtual Countries Countries { get; set; }
        public virtual Currencies Currencies { get; set; }
        public virtual DestructionLevels DestructionLevels { get; set; }
        public virtual Documents Documents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SinisterKeywords> SinisterKeywords { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SinisterLob> SinisterLob { get; set; }

       
        public virtual SinisterStatus SinisterStatus { get; set; }
        public virtual SinisterTypes SinisterTypes { get; set; }
        public virtual Sites Sites { get; set; }
        public virtual Users Users { get; set; }

        public List<Clients> ListClient { get; set; }
        public List<Sites> ListSite { get; set; }
        public List<SinisterTypes> ListSinisterType { get; set; }
        public List<Countries> ListCountries { get; set; }
        public List<Lobs> ListLob { get; set; }
        public List<ActivitySectors> ListActivitySector { get; set; }
        public List<DestructionLevels> ListDestructionLevel { get; set; }
        public List<Currencies> ListCurrency { get; set; }
        public List<Keywords> ListKeyword { get; set; }
        public List<SinisterKeywords> ListSinisterKeyword { get; set; }
        public List<CheckBoxViewModel> CheckBoxList { get; set; }
        public List<SinisterStatus> ListSinisterStatus { get; set; }

        [DisplayName("Created by")]
        public string CompleteUserNameForCreate { get; set; }

        [DisplayName("Edited by")]
        public string CompleteUserNameForEdit { get; set; }
        public Sites Site { get; set; }

        [DisplayName("Lob")]
        public string LobName { get; set; }





    }
}

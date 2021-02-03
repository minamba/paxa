using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinisterWebApp.Models
{    
    public class SinisterViewModel
    {
        sinisterEntities db = new sinisterEntities();

        public List<Clients> ListClient { get; set; }
        public List<Sites> ListSite { get; set; }
        public List<SinisterTypes> ListSinisterType { get; set; }
        public List<Countries> ListCountries {get;set;}
        public List<Lobs> ListLob { get; set; }
        public List<ActivitySectors> ListActivitySector { get; set; }
        public List<DestructionLevels> ListDestructionLevel { get; set; }
        public List<Currencies> ListCurrency { get; set; }
        public List<Keywords> ListKeyword { get; set; }
        public List<SinisterKeywords> ListSinisterKeyword { get; set; }
        public List<SinisterStatus> ListSinisterStatus { get; set; }
        public List<CheckBoxViewModel> CheckBoxList { get; set; }
        public Sites Site { get; set; }

        public Sinisters Sinister { get; set; }
    }
}
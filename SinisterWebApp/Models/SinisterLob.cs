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
    
    public partial class SinisterLob
    {
        public int SinisterLobId { get; set; }
        public Nullable<int> SinisterId { get; set; }
        public Nullable<int> LobId { get; set; }
    
        public virtual Lobs Lobs { get; set; }
        public virtual Sinisters Sinisters { get; set; }
    }
}

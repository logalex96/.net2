//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceAutoLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comanda
    {
        public System.Guid ComandaId { get; set; }
        public StareComanda StareComanda { get; set; }
        public System.DateTime DataSystem { get; set; }
        public System.DateTime DataProgramare { get; set; }
        public System.DateTime DataFinalizare { get; set; }
        public int KmBord { get; set; }
        public string Descriere { get; set; }
        public decimal ValoarePiese { get; set; }
    }
}

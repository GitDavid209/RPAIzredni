//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BazaNaprej.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Dijak
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dijak()
        {
            this.DijakPodročje = new HashSet<DijakPodročje>();
            this.IzvedbaDijak = new HashSet<IzvedbaDijak>();
            this.PlanDijak = new HashSet<PlanDijak>();
        }
    //*Potrebno vnesti nad sprejemljivko "public string DijIme".
        public int DijID { get; set; }
        [Display(Name="Ime")] //*
        public string DijIme { get; set; }
        [Display(Name = "Priimek")]
        public string DijPriimek { get; set; }
        [Display(Name = "Razred")]
        public string DijRazred { get; set; }
        [Display(Name = "Datum Rojstva")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyy}")]
        public Nullable<System.DateTime> DijDatumRojstva { get; set; }
        public byte[] DijaSlika { get; set; }
        [Display(Name = "Datum rojstva")]
        public Nullable<System.DateTime> DijIDNadDatum { get; set; }
        public string DijIDNadUstanova { get; set; }
        public Nullable<System.DateTime> DijIDNadPotrditev { get; set; }
        [Display(Name = "Ime mame")]
        public string DijMati { get; set; }
        [Display(Name = "Ime očeta")]
        public string DijOče { get; set; }
        public Nullable<System.Guid> UserID { get; set; }
    
        public virtual Razredniki Razredniki { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DijakPodročje> DijakPodročje { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IzvedbaDijak> IzvedbaDijak { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanDijak> PlanDijak { get; set; }
    }
}

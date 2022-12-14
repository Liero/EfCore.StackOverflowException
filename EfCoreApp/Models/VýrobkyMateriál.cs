// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace EfCoreApp.Models
{
    public partial class VýrobkyMateriál
    {
        public VýrobkyMateriál()
        {

        }
        public VýrobkyMateriál(ČíselníkVýrobkyMateriál m)
        {
            IdMateriálu = m.IdMateriálu;
            Množstvo = m.Množstvo;
            Poznámka = m.Poznámka;
            Index = m.Index;
            Strana = m.Strana;
        }

        public int Id { get; set; }
        public int? IdVýrobku { get; set; }
        public int? IdMateriálu { get; set; }
        public double? Množstvo { get; set; }
        public string Poznámka { get; set; }
        public bool? Výpočet { get; set; }
        public short? Index { get; set; }


        /// <summary>
        /// A, B, or A+B or "" or null
        /// </summary>
        public string Strana { get; set; }

        public virtual ČíselníkMateriál Material { get; set; }
        public virtual Výrobky InternalOrder { get; set; }
    }
}
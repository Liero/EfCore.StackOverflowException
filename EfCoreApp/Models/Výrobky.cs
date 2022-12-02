
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

#nullable disable

namespace EfCoreApp.Models;

public partial class Výrobky
{
    public Výrobky()
    {
        MaterialItems = new List<VýrobkyMateriál>();
    }

    public int Id { get; set; }
    public string Kód { get; set; } 
    public int? Podset { get; set; }

    public virtual ICollection<Výrobky> Subsets { get; set; } = new List<Výrobky>();
    public virtual ICollection<VýrobkyMateriál> MaterialItems { get; set; }




}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;

namespace EfCoreApp.Models;


public partial class ČíselníkVýrobky
{

    public ČíselníkVýrobky()
    {
        MaterialItems = new List<ČíselníkVýrobkyMateriál>();
    }

    public int Id { get; set; }
    public string Kód { get; set; }


    public virtual ICollection<ČíselníkVýrobkyMateriál> MaterialItems { get; set; }



   

}

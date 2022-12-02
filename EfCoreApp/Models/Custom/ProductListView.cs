using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EfCoreApp.Models.Custom;

public partial class ProductListView
{
    public int Id { get; set; }
    public string Kód { get; set; }


    [Display(AutoGenerateField = false)]
    public virtual IReadOnlyCollection<ČíselníkVýrobkyMateriál> MaterialItems { get; private set; }

    [Display(AutoGenerateField = false)]
    public virtual IReadOnlyCollection<Výrobky> InternalOrders { get; private set; }
}

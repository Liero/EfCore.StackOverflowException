﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

#nullable disable

namespace EfCoreApp.Models
{
    public partial class ČíselníkMateriál
    {
        public const string HISTORY_OBJECT = "ČíselníkMateriál";
        public const int PN_LENGTH = 8;

       

        public ČíselníkMateriál()
        {
           
        }

        public int Id { get; set; }

        [Display(ShortName = "PN")]
        public string KódMateriálu { get; set; }

        public string Popis { get; set; }

    }
}
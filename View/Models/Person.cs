using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace View.Models
{
    public class Person
    {

        [Display(Name = "Navn på person")]
        public string Navn { get; set; }

        [Display(Name = "Alder på person")]
        public int Alder { get; set; }
        public bool ErILive { get; set; }
        public Køn Køn { get; set; }
    }

    public enum Køn
    {
        Mand,
        Kvinde
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTPMQLbtl.Models
{
    [Table("Chitietdonhang")]
    public class Chitietdonhang
    { 
        [Key]
        public string Machitietdonhang { get; set; }
        [AllowHtml]
        public string Madonhang { get; set; }
        public string Mathang { get; set; }
        public decimal Dongia { get; set; }
        public int Soluong { get; set; }

    }
}
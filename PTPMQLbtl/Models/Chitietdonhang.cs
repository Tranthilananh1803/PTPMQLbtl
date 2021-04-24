using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace PTPMQLbtl.Models
{
    [Table("Chitietdonhang")]
    public class Chitietdonhang
    { 
        [Key]
        public string Machitietdonhang { get; set; }
      
        public string Madonhang { get; set; }
        public string Mathang { get; set; }
        public string Dongia { get; set; }
        public int Soluong { get; set; }

    }
}
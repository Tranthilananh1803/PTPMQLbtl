using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQLbtl.Models
{
    [Table("Donhanghoa")]
    public class Donhanghoa
    {
        [Key]
        public string Madonhang { get; set; }

        public string Tendonhang { get; set; }
        
        public int Sodonhang { get; set; }
        [StringLength(200)]
        public string Yeucau { get; set; }

    }
}
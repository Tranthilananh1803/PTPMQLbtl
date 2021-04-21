using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQLbtl.Models
{
    [Table("Danhmuchang")]
    public class Danhmuchang
    {
        [Key]

        public int Mathang { get; set; }

      
        [StringLength(50)]
        public string Tenhang { get; set; }
        

        [StringLength(30)]
        public string Donvitinh { get; set; }

        
        public decimal? Dongia { get; set; }


     
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTPMQLbtl.Models
{
    [Table("Danhmuchang")]
    public class Danhmuchang
    {
		

		[Key]
       
        public int Mathang { get; set; }

      
        [StringLength(50)]
        [AllowHtml]
        public string Tenhang { get; set; }
       
         
        public int Manhomhang { get; set; }
        public string Donvitinh { get; set; }

        
        public decimal Dongia { get; set; }
		
	}
}
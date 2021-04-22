using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTPMQLbtl.Models
{
    [Table("Khachhang")]
    public partial class Khachhang
    {
        
        [Key]

        public int Makhachhang { get; set; }

        [StringLength(50)]
        public string Hodem { get; set; }
        [AllowHtml]
      
        [StringLength(20)]
        public string Ten { get; set; }

        [StringLength(200)]

        public string Diachi { get; set; }

        [StringLength(20)]
        public string Sodienthoai { get; set; }
     


    }

}
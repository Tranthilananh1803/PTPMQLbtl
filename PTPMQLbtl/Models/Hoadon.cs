using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTPMQLbtl.Models
{
    [Table("Hoadon")]
    public class Hoadon
    {
        [Key]
        public int Sohoadon { get; set; }
       [AllowHtml]
        public DateTime Ngayban { get; set; }
        public int Makhachhang { get; set; }
        public string Tenkhachhang { get; set; }
    }
}
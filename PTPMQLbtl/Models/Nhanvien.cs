using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTPMQLbtl.Models
{
    [Table("Nhanvien")]
    public class Nhanvien
    {
        [Key]
        public string MaNV { get; set; }
        [AllowHtml]
        public string TenNV { get; set; }

    }
}
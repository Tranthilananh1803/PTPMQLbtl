using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTPMQLbtl.Models
{
    [Table ("Nhacungcap") ]
    public class Nhacungcap
    {
        [Key]
        public string MaNCC { get; set; }
        [AllowHtml]
        public string TenNCC { get; set; }

        [StringLength(100)]
        public string Diachi { get; set; }

        [StringLength(25)]
        public string Sodienthoai { get; set; }

    }
}
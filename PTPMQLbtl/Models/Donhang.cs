﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTPMQLbtl.Models
{
    [Table("Donhang")]
    public partial class Donhang
    {
        
        [Key]

        public int Madonhang { get; set; }
        [AllowHtml]
        
        public int Makhachhang { get; set; }
        public DateTime Ngaydathang { get; set; }

    


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQLbtl.Models
{
    [Table("Nhomhang")]
    public partial class Nhomhang
    {     
        [Key]

        public int Manhomhang { get; set; }

      
        [StringLength(50)]
        public string Tennhomhang { get; set; }

        [StringLength(200)]
     
        public string Mota { get; set; }

    }
}

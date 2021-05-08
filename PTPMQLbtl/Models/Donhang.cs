using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQLbtl.Models
{
    [Table("Donhang")]
    public class Donhang
    {
        [Key]
        public string Madonhang { get; set; }
        public string Chitiethang { get; set; }
        public DateTime Ngaydathang { get; set; }
        
    }
}
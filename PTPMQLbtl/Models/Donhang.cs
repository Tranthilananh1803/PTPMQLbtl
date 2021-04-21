using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQLbtl.Models
{
    [Table("Donhang")]
    public partial class Donhang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Madonhang { get; set; }

        

        public DateTime Ngaydathang { get; set; }

       

        
    }
}

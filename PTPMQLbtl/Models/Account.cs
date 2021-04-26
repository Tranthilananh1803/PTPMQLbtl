using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQLbtl.Models
{
    [Table("Account")]
    public class Account
    {
      [Key]
        [Required(ErrorMessage = "User name is required.")]
        public string Usename { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
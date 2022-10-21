using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;

namespace softSys_1.Models
{
    public class delivs
    {
        public int delivsID {get; set;}
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string DriverName {get; set;}
        public string address {get; set;}
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;

namespace softSys_1.Models
{
    public class users
    {
        public int usersID {get; set;}
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string Name {get; set;}
    }
}
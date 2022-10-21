using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;

namespace softSys_1.Models
{
    public class Stores
    {
        public int StoresID {get; set;}
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string StoreName {get; set;}
        public string food {get; set;}
        public string address {get; set;}
    }

    public class DelivStore
    {
        public int StoresID {get; set;}
        public int delivsID {get; set;}
        public Stores Store {get; set;}
        public delivs drivers {get; set;}
    }
}
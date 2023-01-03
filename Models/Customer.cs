using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoustomWebApi.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public string CustomerAddress { get; set; }

        public int CustomAge { get; set; }

        public long CustomerPhone { get; set; }
    }
}

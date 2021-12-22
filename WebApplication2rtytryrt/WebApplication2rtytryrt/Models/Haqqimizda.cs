using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2rtytryrt.Models
{
    public class Haqqimizda
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(5000)]
        public string Context { get; set; }
        [MaxLength(200)]
        public string Aderss { get; set; }
        [MaxLength(30)]
        public string Telefon1 { get; set; }
        [MaxLength(30)]
        public string Telefon2 { get; set; }
        [MaxLength(50)]
        public string Mail { get; set; }


    }
}

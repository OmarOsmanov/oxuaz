using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2rtytryrt.Models
{
    public class reklam
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(5000)]
        public string Context { get; set; }
        [MaxLength(200)]
        public string Adress { get; set; }
        [MaxLength(30)]
        public string PressTelefon { get; set; }
        [MaxLength(50)]
        public string PressMail { get; set; }
        [MaxLength(50)]
        public string BarnerMail { get; set; }
        [MaxLength(50)]
        public string BarnerMobilePhone { get; set; }
        [MaxLength(50)]
        public string BarnerElaqePhone { get; set; }
       

    }
}

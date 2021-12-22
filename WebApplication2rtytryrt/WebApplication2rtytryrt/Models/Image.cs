using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2rtytryrt.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public int Name { get; set; }
        public int NewsId { get; set; }

    }
}

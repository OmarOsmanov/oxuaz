using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2rtytryrt.Models
{
    public class CategoryToNews
    {
        [Key]
        public int Id { get; set; }
        public int NewsId { get; set; }
        public int CategoryId { get; set; }

    }
}

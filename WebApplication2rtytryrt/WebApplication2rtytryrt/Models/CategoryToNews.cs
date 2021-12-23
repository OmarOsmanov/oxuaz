using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2rtytryrt.Models
{
    public class CategoryToNews
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("News")]
        public int NewsId { get; set; }
        public News News { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}

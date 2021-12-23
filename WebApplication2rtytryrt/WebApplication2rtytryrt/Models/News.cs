using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2rtytryrt.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        
        public string Content { get; set; }
        [MaxLength(200)]
        public string CoverImage { get; set; }

        public int OxumaSayi { get; set; }

        public int Like { get; set; }
        public int UnLike { get; set; }
        public DateTime Createdate { get; set; }
        public List<Image> Images { get; set; }
        public List<CategoryToNews> CategoryToNews { get; set; }
        public List<MuellifToNews> MuellifToNews { get; set; }

    }
}

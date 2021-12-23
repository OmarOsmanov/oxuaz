using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2rtytryrt.Models;

namespace WebApplication2rtytryrt.Data
{
    public class AppDbContext: DbContext 
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryToNews> CategoryToNewss { get; set; }
        public DbSet<Dil> Dils { get; set; }
        public DbSet<Haqqimizda> Haqqimizdas { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Muellif> Muellifs { get; set; }
        public DbSet<MuellifToNews> MuellifToNewss { get; set; }
        public DbSet<News> Newss { get; set; }
        public DbSet<reklam> Reklams { get; set; }
        public DbSet<Settings> Settingss { get; set; }
        public DbSet<Sosial> Sosials { get; set; }
    }
}

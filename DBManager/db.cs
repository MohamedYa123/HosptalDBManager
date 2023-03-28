using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManager
{
    public class db:DbContext
    {
        public DbSet<user> users { get; set; }
        public DbSet<position> positions { get; set; }
        public DbSet<work> work { get; set; }
        public DbSet<category> category { get; set; }
        public DbSet<Post> posts { get; set; }
        protected override  void OnConfiguring(DbContextOptionsBuilder options)
        {
           // options.UseSqlServer(@"Server=MOHAMEDYASSER\SQLEXPRESS;Database=hospitalDB;TrustServerCertificate=True;Trusted_Connection=True");
            options.UseSqlServer(@"Data Source=SQL8005.site4now.net;Initial Catalog=db_a96cf2_medo;User Id=db_a96cf2_medo_admin;Password=Doublemedo123;TrustServerCertificate=True");//website

        }
    }
}

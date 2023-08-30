using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hcodef
{
    public class modelDBContext : DbContext//ورثنه من مكتبه entity
    {
        public modelDBContext()
        {
        }

        public virtual DbSet<card> Cards { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; } //خاص بكلاس الاستاذ اي بنعرفة في قاعدة البيانات 
        public virtual DbSet<student> Students { get; set; }
                
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//داله تمكنا من الاتصال مع قاعده البانات
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-I50J9K9\SQLEXPRESS01;Initial Catalog=Testhcodef;Integrated Security=True");
        }
      /*  protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<student>()
                .HasAnnotation()
        }*/
    }
}

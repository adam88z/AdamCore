using System;
using Microsoft.EntityFrameworkCore; 


namespace AdamCore.Models
{

    public partial class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }



        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Database=localdb;server=127.0.0.1;port=53784;User Id=azure;Password=6#vWHD_$");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("user");
        }



        //public MySQLDatabaseContext()
        //{ }


    } 

}

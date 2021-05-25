using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Data;

namespace AdamCore.Models
{

    public partial class MySQLDatabaseContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public MySQLDatabaseContext(DbContextOptions<MySQLDatabaseContext> options) : base(options)
        { }

        //public MySQLDatabaseContext()
        //{ }


    }

}

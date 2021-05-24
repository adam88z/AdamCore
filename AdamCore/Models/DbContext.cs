using System;
using Microsoft.EntityFrameworkCore;

namespace AdamCore.Models
{

    public partial class MySQLDatabaseContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public MySQLDatabaseContext(DbContextOptions<MySQLDatabaseContext> options) : base(options)
        { }

        public MySQLDatabaseContext()
        { }


    }

}

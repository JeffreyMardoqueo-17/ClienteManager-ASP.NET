﻿using Microsoft.EntityFrameworkCore;
using RegistroClientesEN;  // Donde está tu clase `Clientes`

namespace RegistrarClientesDAL
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        public DbSet<Clientes> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}

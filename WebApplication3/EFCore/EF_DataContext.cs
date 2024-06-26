﻿using Microsoft.EntityFrameworkCore;

namespace WebApplication3.EFCore
{
    public class EF_DataContext : DbContext
    {
        public EF_DataContext(DbContextOptions<EF_DataContext> options) : base(options) { }

        public DbSet<Books> Books { get; set; }
    }
}

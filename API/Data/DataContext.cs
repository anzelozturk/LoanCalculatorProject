﻿using Microsoft.EntityFrameworkCore;

namespace MyProjectAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<KrediTipi> KrediTipleri { get; set; }

    
}
}

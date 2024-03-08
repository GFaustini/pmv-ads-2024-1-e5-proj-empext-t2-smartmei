﻿using Microsoft.EntityFrameworkCore;

namespace Smartmei.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Projeto> Projetos { get; set; }
    }
}
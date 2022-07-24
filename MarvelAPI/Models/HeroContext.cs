﻿using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace MarvelAPI.Models
{
    public class HeroContext : DbContext
    {
        public HeroContext(DbContextOptions<HeroContext> options)
                    : base(options)
        {
        }

        public DbSet<Hero> Heroes { get; set; } = null!;
    }
}

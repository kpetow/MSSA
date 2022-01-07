#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Challenge_Cinema.Models;

namespace Challenge_Cinema.Data
{
    public class Challenge_CinemaContext : DbContext
    {
        public Challenge_CinemaContext (DbContextOptions<Challenge_CinemaContext> options)
            : base(options)
        {
        }

        public DbSet<Challenge_Cinema.Models.Movies> Movies { get; set; }
    }
}

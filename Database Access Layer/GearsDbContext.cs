/////////////////////////////////////////////////////////////////////////////////////////////////
//
// Gears API
// Copyright (c) 2012, Credisoluciones. Todos los derechos reservados.
// Este archivo es confidencial de Credisoluciones. No distribuir.
// Miguel iván Lua Montes
using Microsoft.EntityFrameworkCore;
using ProyectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ProyectAPI.Database_Access_Layer
{
    public class GearsDbContext : DbContext, IApplicationDbContext
    {
        /// <summary>
        /// Guns
        /// </summary>
        public DbSet<GearsGun> GearsGuns { get; set; }
        /// <summary>
        /// Characters
        /// </summary>
        public DbSet<GearsCharacter> GearsCharacters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=GearsAPIDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
        public GearsDbContext(DbContextOptions<GearsDbContext> options)
            : base(options)
        {

        }
    }
    
}

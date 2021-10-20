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
using System.Threading.Tasks;

namespace ProyectAPI.Database_Access_Layer
{
    public interface IApplicationDbContext
    {
        /// <summary>
        /// Guns
        /// </summary>
        public DbSet<GearsGun> GearsGuns { get; set; }
        /// <summary>
        /// Characters
        /// </summary>
        public DbSet<GearsCharacter> GearsCharacters { get; set; }
    }
}

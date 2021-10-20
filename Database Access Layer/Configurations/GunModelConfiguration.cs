/////////////////////////////////////////////////////////////////////////////////////////////////
//
// Gears API
// Copyright (c) 2012, Credisoluciones. Todos los derechos reservados.
// Este archivo es confidencial de Credisoluciones. No distribuir.
// Miguel iván Lua Montes
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectAPI.Database_Access_Layer.Configurations
{
    public class GunModelConfiguration : IEntityTypeConfiguration<GearsGun>
    {
        public void Configure(EntityTypeBuilder<GearsGun> builder)
        {
            // int GunID 
            builder.ToTable("GearsGuns");
            builder.HasKey(c => c.GunID);
            // string GunName
            builder.Property(c => c.GunName)
                .HasMaxLength(50);
            // string GunDesc 
            builder.Property(c => c.GunDesc)
                .HasMaxLength(500);
            // int GunDamage 
            builder.Property(c => c.GunDamage)
                .HasMaxLength(20);
            // int GunShots 
            builder.Property(c => c.GunShots)
                .HasMaxLength(20);
            // string GunImage 
            builder.Property(c => c.GunImage)
                .HasMaxLength(1000);
        }
    }
}

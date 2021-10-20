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
    public class CharacterModelConfiguration : IEntityTypeConfiguration<GearsCharacter>
    {
        public void Configure(EntityTypeBuilder<GearsCharacter> builder)
        {
            //int CharacterID 
            builder.ToTable("GearsCharacters");
            builder.HasKey(c => c.CharacterID);

            // string CharacterName
            builder.Property(c => c.CharacterName)
                .HasMaxLength(50);
            //string CharacterDesc
            builder.Property(c => c.CharacterDesc)
                .HasMaxLength(500);
            // int CharacterAge 
            builder.Property(c => c.CharacterAge)
                .HasMaxLength(20);
            // string CharacterImage 
            builder.Property(c => c.CharacterImage)
                .HasMaxLength(1000);
        }
    }
}

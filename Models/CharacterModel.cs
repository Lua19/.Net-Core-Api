/////////////////////////////////////////////////////////////////////////////////////////////////
//
// Gears API
// Copyright (c) 2012, Credisoluciones. Todos los derechos reservados.
// Este archivo es confidencial de Credisoluciones. No distribuir.
// Miguel iván Lua Montes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectAPI.Models
{
    public class GearsCharacter
    {
        public int CharacterID { get; set; }
        public string CharacterName { get; set; }
        public string CharacterDesc { get; set; }
        public int CharacterAge { get; set; }
        public string CharacterImage { get; set; }
    }
}

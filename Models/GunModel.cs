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
    public class GearsGun
    {
        public int GunID { get; set; }
        public string GunName { get; set; }
        public string GunDesc { get; set; }
        public int GunDamage { get; set; }
        public int GunShots { get; set; }
        public string GunImage { get; set; }
    }
}

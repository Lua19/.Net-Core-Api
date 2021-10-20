/////////////////////////////////////////////////////////////////////////////////////////////////
//
// Gears API
// Copyright (c) 2012, Credisoluciones. Todos los derechos reservados.
// Este archivo es confidencial de Credisoluciones. No distribuir.
// Miguel iván Lua Montes
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectAPI.Database_Access_Layer;
using ProyectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GunsController : ControllerBase
    {
        private readonly GearsDbContext gearsDb;

        public GunsController(GearsDbContext gearsDb)
        {
            this.gearsDb = gearsDb;
        }

        /// <summary>
        /// Return all the valid guns
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<GearsGun> Get()
        {
            return gearsDb.GearsGuns.ToList();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public GearsGun Get(int id)
        {
            var gun = gearsDb.GearsGuns.Find(id);
            return gun;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult Post([FromBody] GearsGun value)
        {
            try
            {
                gearsDb.GearsGuns.Add(value);
                gearsDb.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
            
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] GearsGun value)
        {
            if (value.GunID == id)
            {
                gearsDb.Entry(value).State = EntityState.Modified;
                gearsDb.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var gun = gearsDb.GearsGuns.Find(id);
            if (gun != null)
            {
                gearsDb.GearsGuns.Remove(gun);
                gearsDb.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}

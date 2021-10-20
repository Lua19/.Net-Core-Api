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
    public class CharactersController : ControllerBase
    {
        private readonly GearsDbContext gearsDb;

        public CharactersController( GearsDbContext gearsDb)
        {
            this.gearsDb = gearsDb;
        }

        // GET: api/<CharactersController>
        [HttpGet]
        public IEnumerable<GearsCharacter> Get()
        {
            return gearsDb.GearsCharacters.ToList();
        }

        // GET api/<CharactersController>/5
        [HttpGet("{id}")]
        public GearsCharacter Get(int id)
        {
            var person = gearsDb.GearsCharacters.Find(id);
            return person;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult Post([FromBody] GearsCharacter value)
        {
            try
            {
                gearsDb.GearsCharacters.Add(value);
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
        public ActionResult Put(int id, [FromBody] GearsCharacter value)
        {
            if (value.CharacterID == id)
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
            var person = gearsDb.GearsCharacters.Find(id);
            if (person != null)
            {
                gearsDb.GearsCharacters.Remove(person);
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

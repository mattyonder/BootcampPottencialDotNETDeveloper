using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModuloAPI.Entities;
using ModuloAPI.Context;

namespace ModuloAPI.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly DiaryContext _context;
        public ContactController(DiaryContext context)
        {
            _context = context;
        }

        [HttpPost()]
        public IActionResult Create(Contact contact)
        {
            _context.Add(contact);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = contact.Id }, contact);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var contact = _context.Contact.Find(id);

            if (contact == null)
                return NotFound();

            return Ok(contact);
        }

        [HttpGet("ObterPorNome")]
        public IActionResult GetBytName(string name)
        {
            var contacts = _context.Contact.Where(x => x.Name.Contains(name));
            return Ok(contacts);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Contact contact)
        {
            var contactBase = _context.Contact.Find(id);

            if (contactBase == null)
                return NotFound();

            contactBase.Name = contact.Name;
            contactBase.Phone = contact.Phone;
            contactBase.Active = contact.Active;

            _context.Contact.Update(contactBase);
            _context.SaveChanges();

            return Ok(contactBase);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var contactBase = _context.Contact.Find(id);
            
            if (contactBase == null)
                return NotFound();

            _context.Contact.Remove(contactBase);
            _context.SaveChanges();

            return NoContent();
        }


    }
}
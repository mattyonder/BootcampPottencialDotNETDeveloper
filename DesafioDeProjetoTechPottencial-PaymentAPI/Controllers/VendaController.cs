using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioDeProjetoTechPottencial_PaymentAPI.Context;
using DesafioDeProjetoTechPottencial_PaymentAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesafioDeProjetoTechPottencial_PaymentAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        private OrganizadorContext _context { get; set; }

        public VendaController(OrganizadorContext context)
        {
            this._context = context;
        }

        [HttpPost]
        public IActionResult RegistrarVenda(Venda venda)
        {

            venda.Status = "Aguardando pagamento";
            _context.Vendas.Add(venda);
            _context.SaveChanges();
            return Created("Venda registrada",venda);
        }

        [HttpGet("{id}")]
        public IActionResult BuscarVenda(int id)
        {
            var venda = _context.Vendas.Find(id);

            if (venda == null)
                return NotFound();

            return Ok(venda);
        }

    }
}
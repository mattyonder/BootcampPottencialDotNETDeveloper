using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDeProjetoTechPottencia___Payment_API.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public Vendedor VendedorId { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }

        public List<Item> Itens { get; set; }


    }
}
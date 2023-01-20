using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemploExplorando.Models
{
    public class Sale
    {   
        /// <summary>
        ///  O construtor foi comentado 
        /// </summary>
        // public Sale(int id, string product, decimal price, DateTime saleDate)
        // {
        //     Id = id;
        //     Product = product;
        //     Price = price;
        //     SaleData = saleDate;
        // }
        public int Id { get; set; }

        // Independente da propriedade Json ter um nome diferente da propriedade daqui
        // Por conta do JsonProperty eu consigo associar uma a outra
        [JsonProperty("Product_Name")]
        public string Product { get; set; }

        public decimal Price { get; set; }
        public DateTime SaleData { get; set; }
        public decimal? Discount { get; set; }
    }
}
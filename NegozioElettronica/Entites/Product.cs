using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica.Entites
{
    class Product
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Quantita { get; set; }
        public int? Id { get; set; }

        public Product()
        {

        }

        public Product(string marca, string modello, int quant, int? id)
        {
            Marca = marca;
            Modello = modello;
            Quantita = quant;
            Id = id;
        }

        public virtual void Print()
        {
            Console.WriteLine( $"Marca: {Marca} - Modello: {Modello} - Quantità: {Quantita}");
        }
    }
}

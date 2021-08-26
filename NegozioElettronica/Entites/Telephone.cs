using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica.Entites
{
    class Telephone : Product
    {
        public int Memoria { get; set; }

        public Telephone()
        {

        }
        public Telephone(string marca, string modello, int quant, int memoria, int? id)
            : base( marca, modello, quant, id)
        {
            Memoria = memoria;
        }
        public override void Print()
        {
            Console.WriteLine($"Marca: {Marca} - Modello: {Modello} - Quantità: {Quantita} - Memoria: {Memoria}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica.Entites
{
    class Tv: Product
    {
        public int Pollici { get; set; }

        public Tv()
        {

        }
        public Tv(string marca, string modello, int quant,int pollici, int? id)
            :base (marca, modello, quant, id)
        {
            Pollici = pollici;
        }

        public override void Print()
        {
            Console.WriteLine($"Marca: {Marca} - Modello: {Modello} - Quantità: {Quantita} - Pollici: {Pollici}");
        }
    }
}

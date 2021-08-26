using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica.Entites
{
    class Pc : Product
    {
        public EnumSistema SistemaOperativo { get; set; }
        public bool IsTouch { get; set; }

        public Pc()
        {

        }
        public Pc(string marca, string modello, int quant, EnumSistema sistemaOperativo, bool touch, int? id)
            :base (marca, modello, quant, id)
        {
            SistemaOperativo = sistemaOperativo;
            IsTouch = touch;
        }

        public override void Print()
        {
            Console.WriteLine($"Marca: {Marca} - Modello: {Modello} - Quantità: {Quantita} - Sistema Operativo: {SistemaOperativo} - Touch: {IsTouch}");
        }
    }
    public enum EnumSistema
    {
        Windows= 1,
        Linux= 2,
    }
}

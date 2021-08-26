using NegozioElettronica.Entites;
using NegozioElettronica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica.ListRepository
{
    class PcListRepository : IPcRepository
    {
        public static List<Pc> computer = new List<Pc>
        {
            new Pc("Acer", "Nitro5", 70, EnumSistema.Windows, false, null ),
            new Pc("Huawei", "MateBook 14", 110, EnumSistema.Windows, true, null ),
            new Pc("Lenovo ", "Thinkpad X230", 30, EnumSistema.Linux, false, null ),
        };

        public List<Pc> Fetch()
        {
            return computer;
        }

        public void Insert(Pc pc)
        {
            computer.Add(pc);
        }
    }
}

using NegozioElettronica.Entites;
using NegozioElettronica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica.ListRepository
{
    class TelephoneListRepository : ITelephoneRepository
    {
        public static List<Telephone> cell = new List<Telephone>
        {
            new Telephone("IPhone", "X", 200, 256, null),
            new Telephone("Samsung", "a51", 110, 128, null),
            new Telephone("Oppo", "Reno2 Z", 90, 128, null),
            new Telephone("Xiaomi", "Mi 11", 250, 256, null),
            new Telephone("Nokia", "XR20", 50, 64, null),
        };

        public List<Telephone> Fetch()
        {
            return cell;
        }

        public void Insert(Telephone cells)
        {
            cell.Add(cells);
        }
    }
}

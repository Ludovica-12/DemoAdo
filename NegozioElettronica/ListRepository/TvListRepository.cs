using NegozioElettronica.Entites;
using NegozioElettronica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica.ListRepository
{
    class TvListRepository : ITvRepository
    {
        public List<Tv> tvs = new List<Tv>
        {
            new Tv("Samsung", "Q60R", 250, 49, null),
            new Tv("Sony", "KD65AG9", 120, 75, null),
            new Tv("LG", "55SM8500", 200, 55, null),
            new Tv("Hisense", "H55U7BE", 50, 65, null),
        };

        public List<Tv> Fetch()
        {
            return tvs;
        }

        public void Insert(Tv tv)
        {
            tvs.Add(tv);
        }
    }
}

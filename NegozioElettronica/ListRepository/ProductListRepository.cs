using NegozioElettronica.Entites;
using NegozioElettronica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica.ListRepository
{
    class ProductListRepository : IProductRepository
    {
        static List<Product> products = new List<Product>();

        static TelephoneListRepository telephoneRepository = new TelephoneListRepository();
        static TvListRepository tvRepository = new TvListRepository();
        static PcListRepository pcRepository = new PcListRepository();

        public List<Product> Fetch()
        {
            products.AddRange(telephoneRepository.Fetch());
            products.AddRange(tvRepository.Fetch());
            products.AddRange(pcRepository.Fetch());


            return products;

        }

        public void Insert(Product t)
        {
            throw new NotImplementedException();
        }
    }
}

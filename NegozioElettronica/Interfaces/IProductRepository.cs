using NegozioElettronica.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica.Interfaces
{
    interface IProductRepository : IDbRepository<Product>
    {
    }
}

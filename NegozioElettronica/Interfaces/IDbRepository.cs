using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica.Interfaces
{
    interface IDbRepository<T>
    {
        public List<T> Fetch();
        public void Insert(T t);
    }
}

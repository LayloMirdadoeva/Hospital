using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.DataProvider
{
    internal class IDataProvider<T>
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}

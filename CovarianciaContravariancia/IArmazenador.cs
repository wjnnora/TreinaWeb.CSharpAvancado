using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianciaContravariancia
{
    interface IArmazenador<T>
    {
        void Armazenador(T item);
    }
}

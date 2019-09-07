using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianciaContravariancia
{
    public class ManipuladorFTP<T> : IArmazenador<T>, IRecuperador<T>
    {
        private List<T> _lista = new List<T>();
        public void Armazenador(T item)
        {
            this._lista.Add(item);
        }

        public T Recuperador(int id)
        {
            return _lista[id];
        }
    }
}

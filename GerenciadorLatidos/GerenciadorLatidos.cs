using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLatidos
{
    public class GerenciadorLatidos
    {
        private int _intensidadeLatido;
        public delegate void ExcessoDecibeisHandler(object obj, EventArgs e);
        public event ExcessoDecibeisHandler ExcessoDecibeisEvent;

        public GerenciadorLatidos()
        {
            _intensidadeLatido = 0;
        }

        public int Latir()
        {
            _intensidadeLatido += 10;
            if (_intensidadeLatido > 80)
            {
                OnExcessoDecibeis(new EventArgs());
            }
            return _intensidadeLatido;
        }

        protected virtual void OnExcessoDecibeis(EventArgs e)
        {
            if (ExcessoDecibeisEvent != null)
            {
                ExcessoDecibeisEvent(this, e);
            }
        }
    }
}

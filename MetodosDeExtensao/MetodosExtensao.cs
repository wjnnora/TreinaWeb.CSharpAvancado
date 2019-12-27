using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeExtensao
{
    public static class MetodosExtensao
    {
        public static string AplicaEspaco (this string arg)
        {
            string novaString = arg.Replace(" ", "-");
            return novaString;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianciaContravariancia
{
    interface IRecuperador<T>
    {
        T Recuperador(int id);
    }
}

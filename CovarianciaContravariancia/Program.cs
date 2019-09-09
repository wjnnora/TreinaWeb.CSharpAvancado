using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianciaContravariancia
{
    public class Program
    {
        static void Main(string[] args)
        {
            ManipuladorFTP<Nivel2> ftp = new ManipuladorFTP<Nivel2>();

            IArmazenador<Nivel3> armazenador = ftp;
            IRecuperador<Nivel1> recuperador = ftp;

            armazenador.Armazenador(new Nivel3());

            Console.WriteLine(recuperador.Recuperador(0));
            
            Console.ReadKey();
        }
    }
}

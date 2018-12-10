using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_Binaria
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                    Binario binario = new Binario();//Creación del objeto de la clase binario.
                    binario.Menu();//Llamada del metodo Buscar.
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}

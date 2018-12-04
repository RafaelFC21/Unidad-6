using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_secuencial
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Busqueda busqueda = new Busqueda();//Se crea objeto de la clase
                Console.WriteLine("-----------Busqueda Secuencial-----------");
                busqueda.Menu();//Llamada del metodo Menu
            }
            catch(Exception e)//Excepción por si llega a exisistir un error.
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}

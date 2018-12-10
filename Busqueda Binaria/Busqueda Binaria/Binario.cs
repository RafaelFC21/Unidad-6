using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_Binaria
{
    class Binario
    {
        public void Ejemplo_1()
        {
            //Se crea el arreglo donde se ingresan valores predefinidos.
            int[] valores = { 3, 6, 7, 9, 14, 134, 563, 523, 2114, 4542, 23545 };
            //Declaración de variables
            int search;
            int inferior = 0;
            int superior = (valores.Length - 1);
            int centro = (inferior + superior) / 2;
            bool cierre = false;
            Console.Write("Ingrese valor que desea buscar en el arreglo: ");
            search = int.Parse(Console.ReadLine());
            for (int i = 0; i < valores.Length; i++)//Por cada incremento en el contador menor al largo del arreglo...
            {
                if (valores[i] == search)//Si el valor de esa posicion del arreglo es igual al numero buscado...
                {
                    Console.WriteLine("Valor encontrado!");//Despliega que el valor si existe en el arreglo.
                    cierre = true;//Cambia la variable cierre a true para que no se imprima que no se encontró el valor.
                    break;//Termina el for para no seguir buscando.
                }
                else if (valores[i] > search)//Si el valor de esa posición del arreglo es mayor al numero buscado...
                    superior = centro - 1;//Se actualiza el valor superior por el del centro - 1.
                else if (valores[i] < search)//Si el valor de esa posición del arreglo es menor al numero buscado...
                    inferior = centro + 1;//Se actualiza el valor inferior por el del centro + 1.
            }
            if (cierre == false)//Si el cierre continua en falso...
                Console.WriteLine("El numero no fue encontrado...");//Despliega que el numero no fue encontrado.
            Console.WriteLine("Presione <ENTER> para salir...");
            Console.ReadKey();
        }
        public void Ejemplo_2()
        {
            //Creción de una lista.
            List<int> valores = new List<int>();
            //Ingreso de valores predeterminados.
            valores.Add(5);
            valores.Add(7);
            valores.Add(23);
            valores.Add(30);
            valores.Add(24);
            valores.Add(53);
            valores.Add(67);
            valores.Add(124);
            valores.Add(234);
            valores.Add(2345);
            //Declaración de variables
            int search;
            int inferior = 0;
            int superior = (valores.Count - 1);
            int centro = (inferior + superior) / 2;
            bool cierre = false;
            Console.Write("Ingrese valor que desea buscar en el arreglo: ");
            search = int.Parse(Console.ReadLine());
            for (int i = 0; i < valores.Count; i++)//Por cada incremento en el contador menor al largo del arreglo...
            {
                if (valores[i] == search)//Si el valor de esa posicion del arreglo es igual al numero buscado...
                {
                    Console.WriteLine("Valor encontrado!");//Despliega que el valor si existe en el arreglo.
                    cierre = true;//Cambia la variable cierre a true para que no se imprima que no se encontró el valor.
                    break;//Termina el for para no seguir buscando.
                }
                else if (valores[i] > search)//Si el valor de esa posición del arreglo es mayor al numero buscado...
                    superior = centro - 1;//Se actualiza el valor superior por el del centro - 1.
                else if (valores[i] < search)//Si el valor de esa posición del arreglo es menor al numero buscado...
                    inferior = centro + 1;//Se actualiza el valor inferior por el del centro + 1.
            }
            if (cierre == false)//Si el cierre continua en falso...
                Console.WriteLine("El numero no fue encontrado...");//Despliega que el numero no fue encontrado.
            Console.WriteLine("Presione <ENTER> para salir...");
            Console.ReadKey();
        }
        public void Menu()
        {
            int temp;
            do
            {
                Console.Write("A que ejemplo desea acceder" +
                    "\n1.- Ejemplo 1" +
                    "\n2.- Ejemplo 2" +
                    "\nIngrese opción: ");
                int opc = int.Parse(Console.ReadLine());//Ingreso de la opción a ejecutar en el switch.
                temp = opc;
                if (opc == 1)
                    Ejemplo_1();
                else if (opc == 2)
                    Ejemplo_2();
                else
                    Console.WriteLine("Opción incorrecta");
            }
            while (temp != 1 && temp != 2);
        }
    }
}

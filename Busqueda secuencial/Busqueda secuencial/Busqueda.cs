using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_secuencial
{
    class Busqueda
    {
        //Arreglos predefinidos para cada ejemplo.
        int[] ejemplo1 = { 6, 5, 1, 5, 8, 9, 245, 35, 14, 6457, 42 };
        string[] ejemplo2 = { "Hola", "Hello", "Kon'nichiwa", "Salam", "Salut", "Hallo" };
        public void Buscar_Numero()//Metodo que hace la busqueda de un numemro en el arreglo 1
        {
            bool encontrado = false;
            int i = 0;
            Console.Write("Escriba un numero a buscar en el arreglo: ");
            int search = int.Parse(Console.ReadLine());
            Console.Clear();
            while (i < ejemplo1.Length && encontrado == false)//Mientras el contador sea menor a el largo del arreglo y encontrado sea falso...
            {
                if (ejemplo1[i] == search)//Si el numero en el arreglo es igual al numero buscado
                {
                    Console.WriteLine("El numero fue encontrado!");//Se despliega que el numero fue encotrado
                    encontrado = true;//El false se convierte a true para acabar con el while
                }
                else
                    i++;//Si no seguirá incrementando el contador
            }
            if (encontrado==false)
                Console.WriteLine("El numero no existe en el arreglo.");//Si el while termina en false se desplegará que no se encontro lo buscado.
            
        }
        public void Buscar_Saludo()
        {
            int i = 0;
            bool encontrado = false;
            Console.Write("Escriba un saludo a buscar en el arreglo: ");
            string search = Console.ReadLine();
            Console.Clear();
            while (i < ejemplo2.Length && encontrado == false)//Mientras el contador sea menor a el largo del arreglo y encontrado sea falso...
            {
                if (ejemplo2[i] == search)//Si el numero en el arreglo es igual al numero buscado
                {
                    Console.WriteLine("El saludo fue encontrado!");//Se despliega que el numero fue encotrado
                    encontrado = true;//El false se convierte a true para acabar con el while
                }
                else
                    i++;//Si no seguirá incrementando el contador
            }
            if(encontrado==false)
                Console.WriteLine("El saludo no existe en el arreglo.");//Si el while termina en false se desplegará que no se encontro lo buscado.
        }
        public void Menu()
        {
            int temp;//Temporal para el ciclo del programa
            do
            {
                Console.WriteLine("A que ejemplo desea acceder" +
                    "\n1.- Ejemplo 1" +
                    "\n2.- Ejemplo 2" +
                    "\nOtro.- Salir");
                int opc = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                temp = opc;
                if (opc == 1)//Si la opción es 1 se desplegará el metodo Buscar_Numero
                {
                    Buscar_Numero();
                }

                else if (opc == 2)//Si la opción es 2 se desplegará el metodo Buscar_Saludo
                {
                    Buscar_Saludo();
                }
                else
                    Environment.Exit(0);//Si no, saldra del programa
                Console.WriteLine("Presione <ENTER> para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            while (temp == 1 || temp == 2);//Mientras sigas eligiendo 1 o 2 permaneceras en el programa
        }
    }
}

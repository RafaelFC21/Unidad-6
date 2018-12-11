using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_Hash
{
    class Funciones
    {
        public void Hash()
        {
            //Creación de variables y arreglos.
            string data;
            byte[] fuenteTemp;
            byte[] hashTemp;
            byte[] newTempHash;
            Console.Write("Ingrese una oración: ");
            data = Console.ReadLine();//Ingreso del primer valor a convertir y comparar
            //Crea una matriz de bytes de los datos de origen
            fuenteTemp = ASCIIEncoding.ASCII.GetBytes(data);
            //Calcula hash a partir de los datos de origen
            hashTemp = new MD5CryptoServiceProvider().ComputeHash(fuenteTemp);
            Console.WriteLine(ByteArrayToString(hashTemp));
            Console.Write("Ingrese 2da oración para comparar valores: ");
            data = Console.ReadLine();//Ingreso del segundo valor a convertir y comparar
            fuenteTemp = ASCIIEncoding.ASCII.GetBytes(data);
            newTempHash = new MD5CryptoServiceProvider().ComputeHash(fuenteTemp);
            Console.WriteLine(ByteArrayToString(newTempHash));
            bool igual = false;
            if (newTempHash.Length == hashTemp.Length)//Si es la misma longitud del dato original y el temporal.
            {
                int contador = 0;
                while ((contador < newTempHash.Length) && (newTempHash[contador] == hashTemp[contador]))//Mientras que el contador sea menor a la longitud del arreglo temporal
                {
                    contador += 1;
                }
                if (contador == newTempHash.Length)
                {
                    igual = true;
                }
            }

            if (igual)//Si la conversión da el mismo resultado entonces se desplegará que son iguales.
                Console.WriteLine("Los dos valores de hash son iguales");
            else//Si no, se desplegará que no son iguales.
                Console.WriteLine("Los dos valores de hash no son iguales");
            Console.ReadLine();
        }
        static string ByteArrayToString(byte[] entrada)
        {
            StringBuilder salida = new StringBuilder(entrada.Length);//Se asigna la entrada en hexadecimal a salida
            for (int contador = 0; contador < entrada.Length - 1; contador++)
            {
                salida.Append(entrada[contador].ToString("X2"));//Asignación como hexadecimal
            }
            return salida.ToString();
        }
    }
}

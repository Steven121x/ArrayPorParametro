using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Elementos = LeerDatos();
            Console.Clear();
            Console.WriteLine("Imprimiendo datos desde el main\n\n");
            foreach(int i in Elementos)
            {
                Console.WriteLine(i);
            }
        }

        static int[] LeerDatos()
        {
            Console.WriteLine("Cuantos elementos quieres que tenga el array");
            string respuesta = Console.ReadLine();
            int ElementosRespuesta = int.Parse(respuesta);

            int[] datos = new int[ElementosRespuesta];

            for (int i = 0; i < ElementosRespuesta; i++)
            {
                Console.WriteLine($"Que datos quieres que se almacene en la pos {i}");
                respuesta = Console.ReadLine();
                int RespuestaDato = int.Parse(respuesta);
                datos[i] = RespuestaDato;

            }
            return datos;
        }
       
    }
}

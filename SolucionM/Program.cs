using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionM
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] separacion;
            Console.WriteLine("Ingrese una palabra o oracion para volverla en su contra parte espejo");
            string palabra = Console.ReadLine();
            char[] caracterArray = palabra.ToCharArray();
            Array.Reverse(caracterArray);

            string union = new string(caracterArray);
            separacion = union.Split(' ');
            Array.Reverse(separacion);

            
            for (int i = 0; i < separacion.Length; i++)
            {
                Console.Write(separacion[i]+" ");
            }
            Console.ReadKey();
            Console.WriteLine("");
            
        


            




        }
    }
}

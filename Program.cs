using System;
using System.Threading;

namespace AppSinHilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El Main Thread comienza aquí.");

            DotrabajoPesado();

            Dialogo();

            Console.WriteLine("El Main thread termina aquí");
            Console.WriteLine("Presione cualquier tecla para terminar...");
            Console.ReadKey(true);   
        }

        public static void Dialogo()
        {
            Console.WriteLine("Dialogo: Oye! Haciendo algo aquí!");
            for (int i=0; i<20; i++)
            {
                Console.WriteLine($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine("Dialogo: Ya terminé");
        }

        public static void DotrabajoPesado()
        {
            Console.WriteLine("DotrabajoPesado: Estoy levantando un camión!");
            Thread.Sleep(1000);
            Console.WriteLine("DotrabajoPesado: Cansado!, Necesito siesta de 3 seg.");
            Thread.Sleep(1000);
            Console.WriteLine("DotrabajoPesado: 1...");
            Thread.Sleep(1000);
            Console.WriteLine("DotrabajoPesado: 2...");
            Thread.Sleep(1000);
            Console.WriteLine("DotrabajoPesado: 3...");
            Console.WriteLine("DotrabajoPesado: Ya desperté.");
        }
    }
}


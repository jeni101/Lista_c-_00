using System;
using SomatorioApp;

namespace SomatorioApp
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Digiete ate que numero deseja somar: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int resultado = Somatoria.Somatorio(numero);
            Console.Clear();
            Console.WriteLine($"a somatoria final foi de: {resultado}");

        }
    }
}
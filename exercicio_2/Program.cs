using System;
using RelogioApp;


namespace RelogioApp{

    public class Mensagem
    {
        public static void Main()
        {
            Console.WriteLine("digite o horario que deseja para a conversao: ");
            Console.WriteLine("Horas: ");
            int horas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Minutos: ");
            int minutos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("segundos: ");
            int segundos = Convert.ToInt32(Console.ReadLine());

           // istanciar p chamar 
           Relogio  relogio = new Relogio();

           relogio.Verificacao(horas, minutos, segundos);
           

           long CalculoMilisegundos = relogio.CalculoMilisegundos();

            Console.WriteLine($"O resultado da conversao foi de: {CalculoMilisegundos}");
        }
    }
}

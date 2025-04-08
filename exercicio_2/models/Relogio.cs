using System;

namespace RelogioApp
{
    public class Relogio
    {
        public int Horas {get; set;}

        public int Minutos {get; set;}

        public int Segundos {get; set;}

        public void Verificacao(int horas, int minutos, int segundos)
        {
            Horas = horas;
            Minutos = minutos;
            Segundos = segundos;



            if (horas > 23 || horas < 0)
            {
                Console.WriteLine("Horas inválidas");
                return;
            }

            if (minutos > 59 || minutos < 0)
            {
                Console.WriteLine("Minutos inválidos. Minutos válidos: 0-59");
                return;
            }

            if (segundos > 59 || segundos < 0)
            {
                Console.WriteLine("Segundos inválidos. Segundos válidos: 0-59");
                return;
            }

        }
        public long CalculoMilisegundos()
        {
            return (Horas * 3600 + Minutos * 60 + Segundos) * 1000;
        }
    }
}
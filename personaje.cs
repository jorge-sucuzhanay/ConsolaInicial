using System;
 
namespace DragonBallz
 
{
    class Goku
    {
        public void DatosGoku()
        {
            Console.WriteLine("¿Cuál es nombre real de Goku?");
            var nombreGoku = Console.ReadLine();
            Console.WriteLine("¿Cuáles son los familiares de Goku?");
            var nombresfamiliares = Console.ReadLine();
            Console.WriteLine("¿Que estatura tiene Goku?");
            float estaturaGoku1;
            while (true)
            {
                string estaturaGoku = Console.ReadLine();
                if (!float.TryParse(estaturaGoku, out estaturaGoku1))
                {
                    Console.Write("Ingrese un valor numérico: ");
                }
                else
                {
                    break;
                };
 
            };

            Console.WriteLine("¿Cúal es el abuelo de Goku?");
            var nombreAbuelo = Console.ReadLine();
            Console.WriteLine("¿Cuántos años se quedo Goku en el planta tierra?");
            int aniosTierra1;
            while (true)
            {
                string aniosTierra = Console.ReadLine();
                if (!int.TryParse(aniosTierra, out aniosTierra1))
                {
                    Console.Write("Ingrese un valor numerico: ");
                }
                else
                {
                    break;
                };
 
            };
            Console.WriteLine("¿Cuál es la novia de Goku?");
            var nombreNovia = Console.ReadLine();
            Console.WriteLine("¿Cuál es la familia de Goku?");
            var familiaGoku = Console.ReadLine();
            Console.WriteLine("¿Quién fue el  que cortó la cola a Goku ?");
            var nombreEnemigo = Console.ReadLine();
            Console.WriteLine("¿Cómo se llama la mamá de Goku?");
            var nombreMama = Console.ReadLine();
            Console.WriteLine("¿Cómo se llama la  papá de Goku?");
            var nombrePapa = Console.ReadLine();
            
            
            
        }
    }
 
    
}
 

using System;

namespace DragonBallz

{
    class Personajes
    {
        public void Informacion()
        {
            Console.WriteLine("¿Cuál es el personaje mas vendido de Dragonball?");
            var personajeVendido = Console.ReadLine();

            Console.WriteLine("¿Cuantos diseños de Dragonball existen?");
            var numeroDiseño = Console.ReadLine();
            int numeroDiseño1;
            while (true)
            {
                string numeroDiseno = Console.ReadLine();
                if (!int.TryParse(numeroDiseno, out numeroDiseño1))
                {
                    Console.Write("Ingrese un valor numérico: ");
                }
                else
                {
                    break;
                };

            };


            Console.WriteLine("¿Dónde se creó la serie de Dragonball?");
            var lugar = Console.ReadLine();

            Console.WriteLine("¿Cuanto tiempo duró en salir la serie de Dragonball?");
            int tiempoDuracion1;
            while (true)
            {
                string tiempoDuracion = Console.ReadLine();
                if (!int.TryParse(tiempoDuracion, out tiempoDuracion1))
                {
                    Console.Write("Ingrese un valor numérico: ");
                }
                else
                {
                    break;
                };

            };


            Console.WriteLine("¿Cuáles son los personajes importantes en Dragonball?");
            var personajesImportante = Console.ReadLine();

            Console.WriteLine("¿Cómo era la serie de DragonBall ?");
            var caracteristicaSerie = Console.ReadLine();


            Console.WriteLine("¿Qué era lo más importante en toda la serie de Dragonball?");
            var importanciaEnSerie = Console.ReadLine();

            Console.WriteLine("¿Qué ocasionó la serie de Dragonball en los niños?");
            var importanciaDragonball = Console.ReadLine();

            Console.WriteLine("¿Cuál es el nombre del guionista de la serie Dragonball?");
            var nombreGuionista = Console.ReadLine();

            Console.WriteLine("¿Cuál es la mejor escena de Dragonball?");
            var mejorEscena = Console.ReadLine();

        }
    }
}

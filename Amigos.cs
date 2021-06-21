using System;

namespace DragonBallz

{

    class Amigos
    {

        public void AmigosGoku()
        {
            Console.WriteLine("¿Cuál es el mejor amigo de Goku? ");
            var nombreAmigo = Console.ReadLine();
            Console.WriteLine("¿Que hicieron Goku y Krilin cuando se fueron al desierto? ");
            var gokuKrilinDesierto = Console.ReadLine();
            Console.WriteLine("¿Cuántos años tiene el mejor amigo de Goku? ");
            int edadAmigo1;
            while (true)
            {
                string edadAmigo = Console.ReadLine();
                if (!int.TryParse(edadAmigo, out edadAmigo1))
                {
                    Console.Write("Ingrese un valor numérico: ");
                }
                else
                {
                    break;
                };

            };
            Console.WriteLine("¿Cuanto tiempo se conocen Goku y Krilin? ");
            int aniosAmistad1;
            while (true)
            {
                string aniosAmistad = Console.ReadLine();
                if (!int.TryParse(aniosAmistad, out aniosAmistad1))
                {
                    Console.Write("Ingrese un valor numerico: ");
                }
                else
                {
                    break;
                };

            };

            var raza = Console.ReadLine();
            Console.WriteLine("¿Cuál es la amiga de Goku? ");
            var amigaGoku = Console.ReadLine();
            Console.WriteLine("¿Qué ropa utilizaba Goku? ");
            var ropaGoku = Console.ReadLine();
            Console.WriteLine("¿Cuál era el enemigo del Maestro Roshi ? ");
            var enemigoRoshi = Console.ReadLine();
            Console.WriteLine("¿Cuál es la amiga de Launch? ");
            var amigaLaunch = Console.ReadLine();
            Console.WriteLine("¿Cuánto pesa Yajirobe?  ");
            float peso1;
            while (true)
            {
                string pesoYajirobe = Console.ReadLine();
                if (!float.TryParse(pesoYajirobe, out peso1))
                {
                    Console.Write("Ingrese un valor numérico: ");
                }
                else
                {
                    break;
                };

            };
            Console.WriteLine("¿Qué estatura tiene Yajirobe, el amigo de Goku?  ");
            float estatura1;
            while (true)
            {
                string estatura = Console.ReadLine();
                if (!float.TryParse(estatura, out estatura1))
                {
                    Console.Write("Ingrese un valor numérico: ");
                }
                else
                {
                    break;
                };

            };

        }

    }

}


using System;

namespace DragonBallz

{

    class Anime
    {
        static void Main(string[] args)
        {
            Inicio(args);

            Goku datosPersonales = new Goku();
            datosPersonales.DatosGoku();
            Amigos amistades = new Amigos();
            amistades.AmigosGoku();
            Personajes anime = new Personajes();
            anime.Informacion();         
            Enemigos informacion = new Enemigos();
            informacion.Datos();
    
        }

        static void Inicio(string[] args)
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Conteste las siguientes preguntas: ");
            Console.WriteLine("¿Cuál es el nombre completo de Goku? ");
            var nombreCompleto = Console.ReadLine();
            Console.WriteLine("¿Recuerdan a Vegeta con bigote en Dragon Ball GT? ");
            var bigoteDeVegeta = Console.ReadLine();
            Console.WriteLine("¿Cuántos años de transmisión de DragonBallZ? ");
            int aniosTrasmision1;
            while (true)
            {
                string aniosTrasmision = Console.ReadLine();
                if (!int.TryParse(aniosTrasmision, out aniosTrasmision1))
                {
                    Console.Write("Ingrese un valor numerico: ");
                }
                else
                {
                    break;
                };

            };
            Console.WriteLine("¿A quién regaló Goku la nube mágica al final del manga? ");
            var regaloDeNubeMagica = Console.ReadLine();
            Console.WriteLine("¿Cual era el director de la serie de DragonBallz? ");
            var nombreDirector = Console.ReadLine();
            Console.WriteLine("¿Quién hacia  la voz de Goku? ");
            var nombreDeInterpretadorVoz = Console.ReadLine();
            Console.WriteLine("¿En que paises nomas  se transmitia la serie de DragonBallz? ");
            var nombrePaises = Console.ReadLine();
            Console.WriteLine("¿Qué hacia  Goku en la serie? ");
            var interpretacionGoku = Console.ReadLine();
            Console.WriteLine("¿Cuáles son los amigos de Goku?  ");
            var nombresAmigosGoku = Console.ReadLine();
            Console.WriteLine("¿Dónde vivia Goku según la serie?  ");
            var ubicacionDeGoku = Console.ReadLine();
            
        }
       
    }
    
}

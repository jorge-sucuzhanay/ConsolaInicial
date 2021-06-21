using System;
 
namespace DragonBallz
 
{
    class Enemigos
    {
        public void Datos()
        {
            Console.WriteLine("¿Cúal fue el primer enemigo que Gokú no pudo derrotar?");
            var enemigoDeGoku = Console.ReadLine();
 
            Console.WriteLine("¿Cómo fue la peléa de Goku y Vegeta?");
            var peleaGokuVegeta = Console.ReadLine();
 
            Console.WriteLine("¿Cúal era una de las peleas más anticipadas de la Saga de Cell?");
            var peleaAnticipada = Console.ReadLine();
            
            Console.WriteLine("¿Cuantos enemigos tenia Goku?");
            int numEnemigos1;
            while (true)
            {
                string numEnemigos = Console.ReadLine();
                if (!int.TryParse(numEnemigos, out numEnemigos1))
                {
                    Console.Write("Ingrese un valor numérico: ");
                }
                else
                {
                    break;
                };
 
            };
            
            Console.WriteLine("¿Cúando perdió la primera pelea Goku?");
            var peleaPerdidaGoku = Console.ReadLine();
            
            Console.WriteLine("¿Quién amenazaba en destruir  el planeta?");
            var nombreAmenazante = Console.ReadLine();
 
            Console.WriteLine("¿Quién  le dejo bien herido a Goku?");
            var nombreEnemigoGoku = Console.ReadLine();
 
            Console.WriteLine("¿Por qué Piccolo acabó siendo defensor de la Tierra y mentor de Son Gohan?");
            var picoroDefensorMentor = Console.ReadLine();
            
            Console.WriteLine("¿Cuál es el nombre del segundo enemigo de Goku que no pudo vencer?");
            var nombreSegundoEnemigo = Console.ReadLine();
 
            Console.WriteLine("¿Cuando murio Goku?");
            var muerteGoku = Console.ReadLine();
            
        }
    }  
}

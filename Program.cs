using System;

namespace InformacionPersonal
{
    class Program
    {
        static void Main(string[] args)
        {
            SaludoInicial(args);

            Console.WriteLine("Bienvenido");

            Console.Write("Ingrese su nombre: ");
            var nombre=Console.ReadLine();

            int edad= IngreseEdad();

            Console.Write("Su peso es: ");
            float peso1;

            while (true)
            {
                string peso=Console.ReadLine(); 
                if (!float.TryParse(peso, out peso1))
                {
                    Console.Write("Ingrese un valor numerico: ");
                }
                else
                {
                    break;
                };
            };

            Console.Write("Te gusta la películas: ");
            bool verPelicula = Console.ReadLine().ToUpper() == "Si";

            Console.Write("¿Cúal es su necha de nacimiento?: ");
            DateTime fecha1;
            while (true)
            {
                string fecha=Console.ReadLine(); 
                if (!DateTime.TryParse(fecha, out fecha1))
                {
                    Console.Write("Ingrese un valor numerico: ");
                }
                else
                {
                    break;
                };
            };
            
            Console.Write("¿Cúal es su estatura?: ");
            float estatura1;
            while (true)
            {
                string estatura = Console.ReadLine(); 
                if (!float.TryParse(estatura, out estatura1))
                {
                    Console.Write("Ingrese un valor numerico: ");
                }
                else
                {
                    break;
                };
            };

            Console.Write("¿Cúal es tu deporte favorito?: ");
            string deporte = Console.ReadLine();

            Console.Write("¿Cúal es su pasatiempo favorito?: ");
            string pasatiempo = Console.ReadLine();

            Console.Write("¿Cuál es su sueldo?: ");
            double sueldo1;
            while (true)
            {
                string sueldo = Console.ReadLine(); 
                if (!double.TryParse(sueldo, out sueldo1))
                {
                    Console.Write("Ingrese un valor numerico: ");
                }
                else
                {
                    break;
                };
            };
            Console.Write("¿En qué semestre está?: ");
            string semestre = Console.ReadLine();

            var persona = new Persona
            {
                nombre = nombre,
                edad = edad,
                peso = peso1,
                verPelicula = verPelicula,
                fechaNacimiento = fecha1,
                estatura = estatura1,
                deporteFavorito = deporte,
                pasatiempo = pasatiempo,
                sueldoMensual = sueldo1,
                semestre = semestre

            };

            Console.WriteLine("Su información es la siguiente: ");
            Console.Write($" Su nombre es: {persona.nombre} ");
            Console.Write($" Su edad es: {persona.edad} ");
            Console.Write($" Su peso es: {persona.peso} ");
            Console.Write($" Te gusta ver la pelicula: {persona.verPelicula} ");
            Console.Write($" Su fecha de nacimientoes: {persona.fechaNacimiento} ");
            Console.Write($" Su estarura es: {persona.estatura} ");
            Console.Write($" Su deporte fovorito es: {persona.deporteFavorito} ");
            Console.Write($" Su pasatiempo favorito es: {persona.pasatiempo} ");
            Console.Write($" Su sueldo mensual es: {persona.sueldoMensual} ");
            Console.Write($" En que semestre estas: {persona.semestre} ");
            Console.WriteLine("Gracias por participar :) ");
            Console.ReadKey();

        }
        
        static void SaludoInicial(string[] args)
        {
            if (args.Length >3)
            {
                Console.WriteLine("Hola!" + args[0] + ' ' + args[1] + ' '+ args[2] + ' '+ args[3]);
            }
            else
            {
                Console.WriteLine("Hola desconocido!");
            }
            Console.WriteLine("¿Comó estas?");
            var estado = Console.ReadLine();
            Console.WriteLine("mmm, entiendo");
            Console.ReadKey();

        }
        static int IngreseEdad()
        {
            Console.WriteLine("Ingrese la edad: ");
            int edad1; 
            while (true)
            {
                string edad=Console.ReadLine(); 
                if (!int.TryParse(edad, out edad1))
                {
                    Console.Write("Ingrese un valor numerico: ");
 
                }
                else
                {
                    break;
                };
                
            };  
            return edad1; 

        }


    }
}

using System;

namespace MiPrimerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Stalyn";
            persona.Apellido = "Vasquez";
            persona.Saludar();
            Console.WriteLine("Su nombre es:" + persona.Nombre);
            Console.WriteLine("Su apellido es:" + persona.Apellido);
            Console.WriteLine(persona.Saludar());
            persona.Dormir();




        }
    }
}

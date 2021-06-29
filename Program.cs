using System;
using System.Collections.Generic;

namespace NumeroHabitantes
{
    class Program
    {
         public static void Main(string[] args)
        {
            Pais pais1 = new Pais
            {
                Nombre = "Ecuador",
                PaisId = 1 

            };
            pais1.Provincias = new List<Provincia>();
            var provincia1 = new Provincia();
            provincia1.Nombre = "Pichincha";
            var provincia2 =  new Provincia();
            provincia2.Nombre = "Azuay";
            pais1.Provincias = new List<Provincia>()
            {
                provincia1,
                provincia2
            };
            var canton1 = new Canton();
            canton1.Nombre = "Quito";
            var canton2 = new Canton();
            canton2.Nombre = "Cuenca";
            provincia2.Cantones = new List<Canton>();
            provincia2.Cantones.Add(canton1);
            provincia2.Cantones.Add(canton2);
            var parroquia1 = new Parroquia();
            parroquia1.Nombre = "Quitumbe";
            var parroquia2 = new Parroquia();
            parroquia2.Nombre = "Santa Rosa";
            parroquia1.Habitantes = 50;
            parroquia2.Habitantes = 20;
            canton1.Parroquias = new List<Parroquia>();
            canton1.Parroquias.Add(parroquia1);
            canton1.Parroquias.Add(parroquia2);

            Console.WriteLine($"El resultado de los habitantes totales de las dos parroquias es: {pais1.ConseguirNumeroHabitantes()}");

        }
    }
}

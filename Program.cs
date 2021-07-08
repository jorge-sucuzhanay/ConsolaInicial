using System;
using Ninject;
using Unity;

namespace DependenciaInyecciones
{
    class Program
    {
        static UtilizarArchivo UtilizarArchivo;
        static void Main(string[] args)
        {
            Init();
            Libro libros = new ()
            {
                Nombre = "Igualdad Raza",
                Autor = "Jordy Martinez",
                Edicion = new DateTime(2000, 02, 13),
                Precio = 13f

            };
            Console.WriteLine($" Con Unity => {UtilizarArchivo.ProducirArchivo(libros)}");
            Ninject.Modules.INinjectModule modulo = new InyectorNinject();
            IReadOnlyKernel  centroPrincipal = new KernelConfiguration(modulo).BuildReadonlyKernel();

            var utilizarArchivo = centroPrincipal.Get<UtilizarArchivo>();
            Console.WriteLine($" Con Ninject => {utilizarArchivo.ProducirArchivo(libros)}");
            Console.ReadKey();

        }
        static void Init()
        {
            try
            {
                var contenedor = new UnityContainer();
                contenedor.RegisterType<Producir, ProducirArchivoTxt>();
                UtilizarArchivo = contenedor.Resolve<UtilizarArchivo>();
            }
            catch (Exception e)
            {
                if (UtilizarArchivo == null)
                {
                    System.Diagnostics.Trace.TraceError(e.Message);
                    Console.WriteLine("Archivo no inyectado");
                }
            }
        }
    }
}

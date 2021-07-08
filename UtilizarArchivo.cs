using Ninject;
using System;

namespace DependenciaInyecciones
{
    public class UtilizarArchivo
    {
        public UtilizarArchivo()
        {

        }
        [Inject]
        public UtilizarArchivo(Producir produciendoArchivo)
        {
            ProduciendoArchivo = produciendoArchivo;
        }
        public Producir ProduciendoArchivo
        {
            get; set;
        }
        public string ProducirArchivo(Libro libro)
        {
            return ProduciendoArchivo.ProduciendoArchivo(libro);
        }



    }
}

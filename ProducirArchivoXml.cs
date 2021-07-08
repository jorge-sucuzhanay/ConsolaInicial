
namespace DependenciaInyecciones
{

    public class ProducirArchivoXml : Producir
    {
        public override string ProduciendoArchivo(Libro libro)
        {
            return $"Produciendo archivo de: {libro.Nombre}.Xml {libro.Precio}.Xml {libro.Autor}.Xml {libro.Edicion}.Xml ";
        }
    }
}

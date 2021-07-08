
namespace DependenciaInyecciones
{
    public class ProducirArchivoTxt : Producir
    {
        public override string ProduciendoArchivo(Libro libro)
        {
            return $"Produciendo archivo de: {libro.Nombre}.Txt {libro.Precio}.Txt {libro.Autor}.Txt {libro.Edicion}.Txt ";
        }
    }
}

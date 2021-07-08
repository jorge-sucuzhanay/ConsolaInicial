using System;

namespace DependenciaInyecciones
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string Nombre { get; set; }
        public float Precio
        {
            get; set;
        }
        public string Autor
        {
            get; set;
        }
        public DateTime Edicion { get; set; }
    }
}

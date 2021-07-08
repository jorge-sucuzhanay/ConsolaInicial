using System.Collections.Generic;

namespace DependenciaInyecciones
{
    class RegistroLibro
    {
        public int RegistroId { get; set; }
        public string Url { get; set; }
        public List<Libro> Libros { get; set; } = new List<Libro>();
        public Producir PublicarArchivo1 { get; set; }

    }
}

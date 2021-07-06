using System;

namespace AlumnoPrograma1
{
    public class Profesor:Persona
    {
        public Profesor():base("Stalyn", "Vazquez") 
        {

        }
        public int ProfesorId { get; set; }
        public string Especialidad { get; set; }
    }
}
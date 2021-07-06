using System;

namespace AlumnoPrograma1
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona1 = new Profesor()
            {
                Nombre = "Veronica",
                Apellido = "Vasquez",
                Especialidad = "Calculo"

            };
            Console.WriteLine(persona1.Saludar());
            Asignatura asignaturas = new Asignatura()
            {
                Nombre = "Biologia"
            };
            Asignatura asignaturas2 = new Asignatura()
            {
                Nombre = "Quimica"
            };
            Asignatura asignaturas3 = new Asignatura()
            {
                Nombre = "Historia"
            };
            Estudiante estudiantes = new Estudiante()
            {
                Nombre = "Violeta",
                Apellido = "Vazquez"
            };
            Estudiante estudiantes2 = new Estudiante()
            {
                Nombre = "Monica",
                Apellido = "Vazquez"
            };
            Console.WriteLine($"Datos profesor: {persona1.Nombre}{persona1.Apellido}{persona1.Especialidad}");
            Console.WriteLine($"Datos estudiantes: {estudiantes.Nombre}{estudiantes.Apellido}");
            Console.WriteLine($"Datos estudiantes: {estudiantes2.Nombre}{estudiantes2.Apellido}");
            Console.WriteLine($"Asignaturas1: " + asignaturas2.Nombre);
            Console.WriteLine($"Asignaturas2: " + asignaturas3.Nombre);




        }
    }
}

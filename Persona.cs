﻿using System;

namespace MiPrimerApp
{
    internal class Persona
    {
        public string Nombre { get { return _nombre1; } set { _nombre1 = value; } }
        public string Apellido { get; set; }
        public string estado1;
        public string _nombre1;
        public string GetEstado() { return estado1; }
        public void SetEstado(string estado) { this.estado1 = estado; }
        public string Saludar()
        {
            return $"Hola me llamo: {this.Nombre}, espero que te encuentres bien";
        }
       public void Dormir() { estado1 = "Estoy durmiendo"; Console.WriteLine(estado1); }

}
}

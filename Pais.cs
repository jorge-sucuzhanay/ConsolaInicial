using System.Collections.Generic;

namespace NumeroHabitantes
{
    class Pais
    {
        public int PaisId { get; set; }
        public string Nombre { get; set; }
        public List<Provincia> Provincias { get; set; } = new List<Provincia>();
        public int ConseguirNumeroHabitantes()
        {
            int acumulador = 0;
            foreach (Provincia actual in Provincias)
            {
               acumulador = acumulador + actual.ConseguirNumeroHabitantes(); 
            }
            return acumulador;
             
        }   
    }
}

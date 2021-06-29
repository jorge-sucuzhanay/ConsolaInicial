﻿using System.Collections.Generic;

namespace NumeroHabitantes
{
    class Provincia
    {
        public int ProvinciaId{get; set;}
        public string Nombre{get; set;}
        public List<Canton> Cantones {get; set;} = new List<Canton>();
        public int ConseguirNumeroHabitantes()
        {
            int acumulador = 0; 
            foreach (Canton actual in Cantones)
            {
                acumulador = acumulador + actual.ConseguirNumeroHabitantes();  
            }
            return acumulador;

        }
    }
}

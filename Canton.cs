﻿using System.Collections.Generic;

namespace NumeroHabitantes
{
    class Canton
    {
        public int CantonId {get; set;}
        public string Nombre {get; set;}
        public List<Parroquia> Parroquias {get; set;} = new List<Parroquia>();
        public int ConseguirNumeroHabitantes() 
        {
            int acumulador = 0; 
            
            foreach(Parroquia actual in Parroquias)
            {
                acumulador = acumulador + actual.Habitantes;
            }
            return acumulador;
        }
    }
}

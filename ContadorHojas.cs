using System.Collections.Generic;
using System.Linq;

namespace Arboles
{
    internal class VerificadorArbol
    {
        internal int CalcularNodo(Nodo principal)
        {
            int i = 0;
            i += principal.padreNodo + principal.Hijos.Count();

            foreach (Nodo actual in principal.Hijos)
            {
                i += actual.Hijos.Count();
            }
            return i;
        }

        internal int CalcularHojas(Nodo principal)
        {
            int i = 0;
            foreach (Nodo actual in principal.Hijos)
            {
                i += actual.Hijos.Count();
            }
            return i;
        }
        internal int CalcularNiveles(Nodo principal)
        {
            int i = 0;
            foreach (Nodo actual in principal.Hijos)
            {
                i += actual.Valor.Count();
            }
            return i;
        }
        public string ArbolInfijo(Nodo principal)
        {
            if (!principal.Hijos.Any())
                return principal.Valor;

            return $"( {ArbolInfijo(principal.Hijos[0])} {principal.Valor} {ArbolInfijo(principal.Hijos[1])})";

        }
        public string ArbolSegundoInfijo(Nodo principal)
        {
            if (!principal.Hijos.Any())
                return principal.Valor;

            return $"( {ArbolSegundoInfijo(principal.Hijos[1])} {principal.Valor} {ArbolSegundoInfijo(principal.Hijos[0])})";

        }
        public string ArbolPrefijo(Nodo principal)
        {
            if (!principal.Hijos.Any())
                return principal.Valor;

            return $" {principal.Valor}({ArbolPrefijo(principal.Hijos[0])}  {ArbolPrefijo(principal.Hijos[1])})";

        }
        public string Arbol2Prefijo(Nodo principal)
        {
            if (!principal.Hijos.Any())
                return principal.Valor;

            return $" {principal.Valor}({Arbol2Prefijo(principal.Hijos[1])}  {Arbol2Prefijo(principal.Hijos[0])})";

        }
        public string Arbol3Prefijo(Nodo principal)
        {
            if (!principal.Hijos.Any())
                return principal.Valor;

            return $" ({Arbol3Prefijo(principal.Hijos[1])}  {Arbol3Prefijo(principal.Hijos[0])}){principal.Valor}";

        }





    }

}
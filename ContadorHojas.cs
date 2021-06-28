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

    }

}
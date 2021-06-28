using System;

namespace Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo raiz = new Nodo()
            {
                Valor = "*",
                altura = 0,
                Hijos =
                {
                    new Nodo
                    {
                        Valor = "+",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "2",
                            },
                            new Nodo
                            {
                                Valor = "2"
                            }
                        }
                    },
                    new Nodo
                    {
                        Valor = "-",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "1",
                            },
                            new Nodo
                            {
                                Valor = "6"
                            }
                        }
                    },
                    new Nodo
                    {
                        Valor = "/",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "5",
                            },
                            new Nodo
                            {
                                Valor = "7"
                            }
                        }
                    }
                }
            };
            VerificadorArbol verificadorArbol = new VerificadorArbol();
            Console.WriteLine($"El número de hojas del árbol son: {verificadorArbol.CalcularHojas(raiz)}");
            Console.WriteLine($"El número de nodos del árbol son: {verificadorArbol.CalcularNodo(raiz)}");
            Console.WriteLine($"El número de niveles del árbol son: {verificadorArbol.CalcularNiveles(raiz)}");

        }
    }
}

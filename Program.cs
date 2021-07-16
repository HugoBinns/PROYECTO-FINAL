using System;
using System.Collections.Generic;


namespace PROYECTO_FINAL
{
    class Program
    {


        static List<string> nodos = new List<string>() { "A", "B", "C", "D", "E", "F" };
        static List<string> recorrido = new List<string>();
        static string BEA(string n)
        {
            int i, canti;
            String recorridoAux = "";
            Boolean encontrado = false;
            canti = nodos.Count-1;

            while (encontrado != true)
            {
                foreach (string nodo in nodos)
                {
                    if(n != nodo)
                    {
                        recorrido.Add(nodo);
                        encontrado = false;
                    }
                    else
                    {
                        recorrido.Add(nodo);
                        encontrado = true;
                    }
                }
            }

            foreach (string nodo in recorrido)
            {
                recorridoAux = recorrido + nodo + " ";
            }

            return recorridoAux;
        }

        static void BEP()
        {

        }
        static void Main(string[] args)
        {
            int s, r, s2;
            String a;
            s = 0;
            s2 = 0;
            r = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("PROYECTO DE GRAFOS - HUGO Y MOISÉS");
                Console.WriteLine("\nSeleccione una opción: ");
                Console.WriteLine("1. Búsqueda en Anchura\n2. Búsqueda en profundidad\n3. Notaciones\n4. Salir");
                r = int.Parse(Console.ReadLine());
                switch (r)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("BÚSQUEDA EN ANCHURA");

                        } while (s2 != 1);


                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("BÚSQUEDA EN PROFUNDIDAD");

                        } while (s2 != 1);

                        break;
                    case 3:

                        do
                        {
                            Console.WriteLine("NOTACIONES");

                        } while (s2 != 1);

                        break;
                    case 4:
                        Console.Write("¿Desea salir? (S/N): ");
                        a = Console.ReadLine();

                        if (a == "S" || a == "s")
                            s = 1;
                        else if (a == "N" || a == "n")
                            s = 0;
                        else
                        {
                            Console.WriteLine("Valor incorrecto");
                            Console.ReadLine();
                            s = 0;
                        }
                        break;
                }


            } while (s != 1);

        }
    }
}

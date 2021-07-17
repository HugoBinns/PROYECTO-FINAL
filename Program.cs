using System;
using System.Collections.Generic;
using System.Linq;

namespace PROYECTO_FINAL
{
    class Program
    {


        static List<string> nodos = new List<string>() { "A", "B", "C", "D", "E", "F" };
        static List<string> aristas = new List<string>() { "(A, B)", "(A, C)", "(B, D)", "(C, E)", "(C, F)" };
        static List<string> hijos = new List<string>() { "A", "AB", "AC", "ABD", "ACE", "ACF" };
        static List<string> recorrido = new List<string>() { "(A, B)", "(B, D)", "(A, C)", "(C, E)", "(C, F)" };
        static int Altura = 3;



        static List<string> infijo = new List<string>();
        static List<string> postfijo = new List<string>();
        static List<string> prefijo = new List<string>();


        static void BEA(string n)
        {
            int i, canti;
            String camino = "";
            string aux = "";
            Boolean encontrado = false;
            i = 0;
            while(encontrado != true)
            {
               recorrido.Clear();


                for (i = 0; i < hijos.Count; i++)
                {
                    Console.Write("Iteracion {0}: ", i+1);
                    aux = hijos.ElementAt(i);

                    camino = camino + hijos.ElementAt(i) + " ";
                    Console.WriteLine(camino);
                    if (aux.Contains(n) == true)
                    {
                        i = hijos.Count;
                    }
                    
                }

                
                foreach(string b in hijos)
                {
                    if (b.Contains(n) == true)
                    { 
                        camino = b;
                        Console.WriteLine("\nEl Recorrido es: " + camino);  ;
                        recorrido.Add(camino);
                        encontrado = true;
                        break;
                           
                    }
 
                }
                
            }
            
        }

        static void BEP(string n)
        {
            int i;
            string aux = "";
            for (i = 0; i < recorrido.Count; i++)
            {
                Console.Write("Iteración {0}: ", i + 1);
                aux = recorrido.ElementAt(i) + " ";
                Console.Write(aux+"\n");
                if(aux.Contains(n) == true)
                {
                    i = recorrido.Count;
                }
            }

            foreach (string b in hijos)
            {
                if (b.Contains(n) == true)
                {
                    
                    Console.WriteLine("\nEl Recorrido es: " + b); ;
                    //recorrido.Add(camino);
                    //encontrado = true;
                    break;

                }

            }


        }


        static void notacionInfijo()
        {

            int i;
            foreach(string nodo in nodos)
            {
                infijo.Add(nodo);
            }
            infijo.Clear();
            infijo.Add("D");
            infijo.Add("B");
            infijo.Add("A");
            infijo.Add("E");
            infijo.Add("C");
            infijo.Add("F");

            for (i = 0; i < infijo.Count; i++)
            {
                Console.Write(infijo.ElementAt(i) + " ");
            }



        }

        static void notacionPostfijo()
        {
            int i;
            foreach (string nodo in nodos)
            {
                postfijo.Add(nodo);
                //if()
            }
            postfijo.Clear();
            postfijo.Add("D");
            postfijo.Add("B");
            postfijo.Add("E");
            postfijo.Add("F");
            postfijo.Add("C");
            postfijo.Add("A");

            for (i = 0; i < postfijo.Count; i++)
            {
                Console.Write(postfijo.ElementAt(i) + " ");
            }
        }


        static void notacionPrefijo()
        {
            int i;
            foreach (string nodo in nodos)
            {
                prefijo.Add(nodo);
            }
            prefijo.Clear();
            prefijo.Add("A");
            prefijo.Add("B");
            prefijo.Add("D");
            prefijo.Add("C");
            prefijo.Add("E");
            prefijo.Add("F");


            for (i = 0; i < prefijo.Count; i++)
            {
                Console.Write(prefijo.ElementAt(i) + " ");
            }

        }

        static void Main(string[] args)
        {
            int s, r, s2;
            String a, node, aux;
            aux = "";
            node = "";
            s = 0;
            s2 = 0;
            r = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("PROYECTO DE GRAFOS - HUGO Y MOISÉS");
                Console.Write("\nVertices del grafo: ");
                foreach(string k in nodos)
                {
                    Console.Write(k + " ");
                }

                Console.Write("\nAristas: ");
                foreach(string k in aristas)
                {
                    Console.Write(k + " ");
                }

                Console.WriteLine("\n\nSeleccione una opción: ");
                Console.WriteLine("1. Búsqueda en Anchura\n2. Búsqueda en profundidad\n3. Notaciones\n4. Salir");
                r = int.Parse(Console.ReadLine());
                switch (r)
                {
                    case 1:
                        Console.Clear();
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("BÚSQUEDA EN ANCHURA");
                            Console.Write("\n¿Qué nodo desea buscar?: ");
                            node = Console.ReadLine();
                            node = node.ToUpper();
                            //Console.WriteLine("El recorrido es: ");
                            BEA(node);
                            Console.Write("\n¿Desea Continuar? (S/N): ");
                            aux = Console.ReadLine();

                            if (aux == "S" || aux == "s")
                                s2 = 0;
                            else if (aux == "n" || aux == "N")
                                s2 = 1;

                        } while (s2 != 1);


                        break;
                    case 2:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("BÚSQUEDA EN PROFUNDIDAD");
                            Console.Write("\n¿Qué nodo desea buscar?: ");
                            node = Console.ReadLine();
                            node = node.ToUpper();
                            //Console.WriteLine("El recorrido es: ");
                            BEP(node);
                            Console.Write("\n¿Desea Continuar? (S/N): ");
                            aux = Console.ReadLine();

                            if (aux == "S" || aux == "s")
                                s2 = 0;
                            else if (aux == "n" || aux == "N")
                                s2 = 1;


                        } while (s2 != 1);

                        break;
                    case 3:

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("NOTACIONES");
                            Console.WriteLine("\nNotación Infija: ");
                            notacionInfijo();
                            Console.WriteLine("\nNotación Prefija: ");
                            notacionPrefijo();
                            Console.WriteLine("\nNotacion Postfija: ");
                            notacionPostfijo();
                            Console.Write("\n¿Desea Continuar? (S/N): ");
                            aux = Console.ReadLine();

                            if (aux == "S" || aux == "s")
                                s2 = 0;
                            else if (aux == "n" || aux == "N")
                                s2 = 1;

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

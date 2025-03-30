using System;
using System.Collections.Generic;
using System.Linq;

class PriorityQueue<T>
{
    private SortedDictionary<int, Queue<T>> elementos;

    public PriorityQueue()
    {
        elementos = new SortedDictionary<int, Queue<T>>();
    }

    public void Enqueue(T item, int prioridad)
    {
        if (!elementos.ContainsKey(prioridad))
        {
            elementos[prioridad] = new Queue<T>();
        }
        elementos[prioridad].Enqueue(item);
    }

    public T Dequeue()
    {
        if (elementos.Count == 0)
        {
            throw new InvalidOperationException("La cola está vacía.");
        }

        var primeraClave = elementos.Keys.First();
        var cola = elementos[primeraClave];
        var elemento = cola.Dequeue();

        if (cola.Count == 0)
        {
            elementos.Remove(primeraClave);
        }

        return elemento;
    }

    public int Count
    {
        get
        {
            int total = 0;
            foreach (var cola in elementos.Values)
            {
                total += cola.Count;
            }
            return total;
        }
    }
}

class Grafo
{
    private Dictionary<string, Dictionary<string, int>> adyacencia;

    public Grafo()
    {
        adyacencia = new Dictionary<string, Dictionary<string, int>>();
    }

    public void AgregarNodo(string nodo)
    {
        if (!adyacencia.ContainsKey(nodo))
        {
            adyacencia[nodo] = new Dictionary<string, int>();
        }
    }

    public void AgregarArista(string origen, string destino, int peso)
    {
        AgregarNodo(origen);
        AgregarNodo(destino);
        adyacencia[origen][destino] = peso;
    }

    public void MostrarMatrizAdyacencia()
    {
        Console.WriteLine("\nMatriz de adyacencia:");
        foreach (var origen in adyacencia.Keys)
        {
            foreach (var destino in adyacencia.Keys)
            {
                int peso = adyacencia[origen].ContainsKey(destino) ? adyacencia[origen][destino] : 0;
                Console.Write($"{peso}\t");
            }
            Console.WriteLine();
        }
    }

    public void Dijkstra(string inicio, string fin)
    {
        Dictionary<string, int> distancias = new Dictionary<string, int>();
        Dictionary<string, string> previos = new Dictionary<string, string>();
        HashSet<string> visitados = new HashSet<string>();
        PriorityQueue<(string nodo, int distancia)> colaPrioridad = new PriorityQueue<(string nodo, int distancia)>();

        foreach (var nodo in adyacencia.Keys)
        {
            distancias[nodo] = int.MaxValue;
            previos[nodo] = null;
        }

        distancias[inicio] = 0;
        colaPrioridad.Enqueue((inicio, 0), 0);

        while (colaPrioridad.Count > 0)
        {
            var actual = colaPrioridad.Dequeue();
            string nodoActual = actual.nodo;

            if (visitados.Contains(nodoActual))
                continue;

            visitados.Add(nodoActual);

            foreach (var vecino in adyacencia[nodoActual])
            {
                string destino = vecino.Key;
                int peso = vecino.Value;

                int nuevaDistancia = distancias[nodoActual] + peso;
                if (nuevaDistancia < distancias[destino])
                {
                    distancias[destino] = nuevaDistancia;
                    previos[destino] = nodoActual;
                    colaPrioridad.Enqueue((destino, nuevaDistancia), nuevaDistancia);
                }
            }
        }

        if (distancias[fin] == int.MaxValue)
        {
            Console.WriteLine($"\nNo hay camino desde {inicio} hasta {fin}.");
            return;
        }

        Console.WriteLine($"\nDistancia más corta desde {inicio} hasta {fin}: {distancias[fin]}");
        Console.Write("Camino: ");

        Stack<string> camino = new Stack<string>();
        string actualNodo = fin;
        while (actualNodo != null)
        {
            camino.Push(actualNodo);
            actualNodo = previos[actualNodo];
        }

        Console.WriteLine(string.Join(" -> ", camino));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Grafo grafo = new Grafo();
        string opcion;

        do
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Agregar nodo.");
            Console.WriteLine("2. Agregar arista.");
            Console.WriteLine("3. Mostrar matriz de adyacencia.");
            Console.WriteLine("4. Encontrar el camino más corto (Dijkstra).");
            Console.WriteLine("5. Salir.");
            Console.Write("Seleccione una opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese el nombre del nodo: ");
                    string nodo = Console.ReadLine();
                    grafo.AgregarNodo(nodo);
                    Console.WriteLine($"Nodo '{nodo}' agregado.");
                    break;

                case "2":
                    Console.Write("Ingrese el nodo origen: ");
                    string origen = Console.ReadLine();
                    Console.Write("Ingrese el nodo destino: ");
                    string destino = Console.ReadLine();
                    Console.Write("Ingrese el peso de la arista: ");
                    int peso = int.Parse(Console.ReadLine());
                    grafo.AgregarArista(origen, destino, peso);
                    Console.WriteLine($"Arista desde '{origen}' hasta '{destino}' con peso {peso} agregada.");
                    break;

                case "3":
                    grafo.MostrarMatrizAdyacencia();
                    break;

                case "4":
                    Console.Write("Ingrese el nodo de inicio: ");
                    string inicio = Console.ReadLine();
                    Console.Write("Ingrese el nodo de fin: ");
                    string fin = Console.ReadLine();
                    grafo.Dijkstra(inicio, fin);
                    break;

                case "5":
                    Console.WriteLine("Saliendo del programa.");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        } while (opcion != "5");
    }
}

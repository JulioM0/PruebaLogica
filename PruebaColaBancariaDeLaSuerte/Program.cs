using System;
using System.Collections.Generic;

namespace ColaBancaria
{
    class Program
    {
        class Cliente : IComparable<Cliente>
        {
            public string Nombre { get; set; }
            public int Prioridad { get; set; }
            public int OrdenDeLlegada { get; set; }

            public Cliente(string nombre, int prioridad, int ordenDeLlegada)
            {
                Nombre = nombre;
                Prioridad = prioridad;
                OrdenDeLlegada = ordenDeLlegada;
            }
            public int CompareTo(Cliente otro)
            {
                if (this.Prioridad != otro.Prioridad)
                {
                    return otro.Prioridad.CompareTo(this.Prioridad); 
                }
                return this.OrdenDeLlegada.CompareTo(otro.OrdenDeLlegada); 
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el numero de eventos (E): ");
            int E = int.Parse(Console.ReadLine());
            var clientes = new List<Cliente>();
            int contadorLlegada = 0;

            for (int i = 0; i < E; i++)
            {
                Console.WriteLine($"Ingresa el evento {i + 1} de {E} ");
                Console.WriteLine("Selecciona alguno de los eventos: ");
                Console.WriteLine("1. C - Llegó un cliente");
                Console.WriteLine("1. S - Sorteo");
                Console.WriteLine("1. A - Atencion");
                string opcion = Console.ReadLine();
                
                //EVENTO DE LLEGÓ UN CLIENTE
                if (opcion == "1")
                {
                    Console.WriteLine("Has seleccionado: C - Llegó un cliente");
                    Console.WriteLine("Ingresa el nombre del cliente:");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingresa la prioridad del cliente:");
                    int prioridad = int.Parse(Console.ReadLine());

                    var cliente = new Cliente(nombre, prioridad, contadorLlegada++);
                    clientes.Add(cliente);

                    Console.WriteLine($"Cliente {nombre} agregado con prioridad {prioridad}.");
                }


                //EVENTO DE SORTEO
                else if (opcion == "2")  
                {
                    Console.WriteLine("Has seleccionado: S - Sorteo");
                    Console.WriteLine("Ingresa una letra para el sorteo:");
                    char letra = Console.ReadLine()[0];
                    Console.WriteLine("Ingresa el incremento de prioridad:");
                    int incremento = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Sorteo: Letra {letra}, Incremento {incremento}.");

                    foreach (var cliente in clientes)
                    {
                        if (cliente.Nombre[0] == letra)
                        {
                            cliente.Prioridad += incremento;
                            Console.WriteLine($"Prioridad de {cliente.Nombre} aumentada a {cliente.Prioridad}.");
                        }
                    }
                    clientes.Sort();
                }


                //EVENTO DE ATENCIÓN
                else if (opcion == "3")
                {
                    Console.WriteLine("Has seleccionado: A - Atención");
                    if (clientes.Count > 0)
                    {
                        var clienteAtendido = clientes[0]; 
                        clientes.RemoveAt(0);
                        Console.WriteLine($"Cliente atendido: {clienteAtendido.Nombre}.");
                    }
                    else
                    {
                        Console.WriteLine("No hay clientes en la cola.");
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, ingresa una opción válida (1, 2 o 3).");
                    i--;
                }
            }
        }
    }
}

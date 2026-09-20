using System;
using System.Collections.Generic;
using System.Text;

namespace GAMMA
{
    public class Ej_Extra_GuerraChaco
    {
        public void Run()
        {
            Console.WriteLine("Ej_Extra_GuerraChaco");

                // Variables iniciales de la escena
                int aguaDisponible = 30; // Litros de agua en el fortín
                int dia = 1;
                bool asedioTerminado = false;

                Console.WriteLine("--- SIMULACIÓN: ASEDIO DE BOQUERÓN (GUERRA DEL CHACO) ---");
                Console.WriteLine("Eres el comandante y debes racionar el agua de tus tropas.\n");

                // Uso del ciclo do-while para simular los días que pasan
                do
                {
                    Console.WriteLine($"\n--- DÍA {dia} ---");
                    Console.WriteLine($"Agua restante: {aguaDisponible} litros.");
                    Console.WriteLine("Opciones de racionamiento:");
                    Console.WriteLine("1. Ración normal (15 litros) - Tropas con energía");
                    Console.WriteLine("2. Ración de supervivencia (10 litros) - Tropas fatigadas");
                    Console.WriteLine("3. Sin ración (0 litros) - Riesgo crítico");
                    Console.Write("Toma una decisión (1, 2 o 3): ");

                    string opcion = Console.ReadLine();

                    // Uso de if, else if, y else para evaluar la decisión del usuario
                    if (opcion == "1")
                    {
                        aguaDisponible = aguaDisponible - 15;
                        Console.WriteLine("Has dado ración normal. Las tropas mantienen la posición con fuerza.");
                    }
                    else if (opcion == "2")
                    {
                        aguaDisponible = aguaDisponible - 10;
                        Console.WriteLine("Has dado ración de supervivencia. Las tropas resisten, pero están cansadas.");
                    }
                    else if (opcion == "3")
                    {
                        Console.WriteLine("Decisión drástica. No se gastó agua, pero los soldados sufren deshidratación.");
                    }
                    else
                    {
                        Console.WriteLine("Orden no válida. La confusión causó el derrame de 5 litros de agua.");
                        aguaDisponible = aguaDisponible - 5;
                    }

                    // Uso de if y else para verificar las condiciones de fin del juego
                    if (aguaDisponible <= 0)
                    {
                        Console.WriteLine("\n¡El agua se ha agotado por completo! El fortín debe capitular.");
                        asedioTerminado = true;
                    }
                    else if (dia >= 3)
                    {
                        Console.WriteLine("\n¡El asedio ha terminado! Los refuerzos llegaron a tiempo y el fortín sobrevive.");
                        asedioTerminado = true;
                    }

                    // Incremento del ciclo while
                    dia++;

                } while (asedioTerminado == false); // El bucle se repite mientras el asedio no haya terminado

                Console.WriteLine("\nFin de la simulación histórica.");


        }
    }
}
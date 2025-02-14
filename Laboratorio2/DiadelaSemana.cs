using System;

namespace tarea2
{
    internal class DiaDeLaSemana
    {
        public static void MostrarDia()
        {
            Console.Write("Ingrese un número del 1 al 7: ");
            int numero;

            // Validar entrada
            while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > 7)
            {
                Console.Write("Número inválido. Ingrese un número entre 1 y 7: ");
            }

            // Evaluar con switch
            string dia = numero switch
            {
                1 => "Lunes",
                2 => "Martes",
                3 => "Miércoles",
                4 => "Jueves",
                5 => "Viernes",
                6 => "Sábado",
                7 => "Domingo",
                _ => "Número fuera de rango" // No debería ocurrir por la validación previa
            };

            Console.WriteLine($"El día correspondiente es: {dia}");
        }
    }
}

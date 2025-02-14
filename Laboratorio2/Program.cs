using System;
using tarea2;

class Program
{
    static void Main()
    {
        {
            string titulo = "LABORATORIO 2";
            int anchoConsola = Console.WindowWidth;
            int espacios = (anchoConsola - titulo.Length) / 2;

            Console.WriteLine(new string(' ', Math.Max(0, espacios)) + titulo);
        }
        Console.WriteLine("=======================================================");
        Console.WriteLine("==================ENUNCIADO 3==========================");
        Console.WriteLine("=======================================================");
        {
            // Llamar a la función de verificación de acceso
            VerificacionAcceso.VerificarUsuario();
        }

        // Parte 1: Declaración y uso de variables
        int numeroEntero;
        double numeroDecimal;
        string texto;
        bool valorBooleano;
        Console.WriteLine("========================================");
        Console.WriteLine("=============== PARTE 1 ================");
        Console.WriteLine("========================================");
        Console.Write("Ingresa un número entero: ");
        numeroEntero = int.Parse(Console.ReadLine());

        Console.Write("Ingresa un número decimal: ");
        numeroDecimal = double.Parse(Console.ReadLine());

        Console.Write("Ingresa un texto: ");
        texto = Console.ReadLine();

        Console.Write("Ingresa un valor verdadero o falso (true/false): ");
        valorBooleano = bool.Parse(Console.ReadLine());

        Console.WriteLine("\nValores ingresados:");
        Console.WriteLine($"Número entero: {numeroEntero}");
        Console.WriteLine($"Número decimal: {numeroDecimal}");
        Console.WriteLine($"Texto: {texto}");
        Console.WriteLine($"Valor booleano: {valorBooleano}");
        Console.WriteLine("========================================");
        Console.WriteLine("=============== PARTE 2 ================");
        Console.WriteLine("========================================");
        // Parte 2: Operaciones Matemáticas
        Console.Write("\nIngresa el primer número entero para operaciones matemáticas: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo número entero: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("\nOperaciones Matemáticas con enteros:");
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        Console.WriteLine($"{num1} / {num2} = {(num2 != 0 ? (num1 / (double)num2).ToString() : "Indefinido")}");

        // Operaciones con double
        Console.Write("\nIngresa el primer número decimal: ");
        double num3 = double.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo número decimal: ");
        double num4 = double.Parse(Console.ReadLine());

        Console.WriteLine("\nOperaciones Matemáticas con decimales:");
        Console.WriteLine($"{num3} + {num4} = {num3 + num4}");
        Console.WriteLine($"{num3} - {num4} = {num3 - num4}");
        Console.WriteLine($"{num3} * {num4} = {num3 * num4}");
        Console.WriteLine($"{num3} / {num4} = {num3 / num4}");
        Console.WriteLine("========================================");
        Console.WriteLine("=============== PARTE 3 ================");
        Console.WriteLine("========================================");
        // Parte 3: Operaciones Lógicas
        Console.Write("\nIngresa el primer número para comparaciones lógicas: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("\nComparaciones Lógicas:");
        Console.WriteLine("{a} > {b}: {a > b}");
        Console.WriteLine("{a} < {b}: {a < b}");
        Console.WriteLine("{a} == {b}: {a == b}");

        Console.WriteLine("\nOperadores Lógicos:");
        Console.WriteLine("({a} > 0 || {b} > 0): {(a > 0 || b > 0)} (AND)");
        Console.WriteLine("({a} > 0 || {b} > 0): {(a > 0 || b > 0)} (OR)");
        Console.WriteLine("============================================");
        Console.WriteLine("=============== ENUNCIADO 1 ================");
        Console.WriteLine("============================================");
        {
            // Llamamos a la función para clasificar la edad
            ClasificacionEdad.ClasificarYMostrarEdad();
        }
        Console.WriteLine("============================================");
        Console.WriteLine("=============== ENUNCIADO 2 ================");
        Console.WriteLine("============================================");
        {
            DiaDeLaSemana.MostrarDia();
        }

        // Evitar que la consola se cierre automáticamente
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}

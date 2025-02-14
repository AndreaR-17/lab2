using System;

public class ClasificacionEdad
{
    public static void ClasificarYMostrarEdad()
    {
        // Solicitar al usuario que ingrese su edad
        Console.Write("Por favor, ingrese su edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        // Clasificar la edad en diferentes grupos
        string categoria = ClasificarEdad(edad);

        // Mostrar el resultado
        Console.WriteLine("Usted pertenece a la categoría: " + categoria);
    }

    public static string ClasificarEdad(int edad)
    {
        // Clasificación basada en rangos de edad
        if (edad >= 0 && edad <= 12)
        {
            return "Niño";
        }
        else if (edad >= 13 && edad <= 17)
        {
            return "Adolescente";
        }
        else if (edad >= 18 && edad <= 64)
        {
            return "Adulto";
        }
        else if (edad >= 65)
        {
            return "Adulto Mayor";
        }
        else
        {
            return "Edad no válida";
        }
    }
}

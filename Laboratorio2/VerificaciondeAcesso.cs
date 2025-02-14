using System;

namespace tarea2
{
    internal class VerificacionAcceso
    {
        public static void VerificarUsuario()
        {
            // Datos simulados (en un sistema real, estos vendrían de una base de datos)
            string usuarioCorrecto = "andrea";
            string contraseñaCorrecta = "1234";

            // Pedir datos al usuario
            Console.Write("Ingrese su nombre de usuario: ");
            string usuario = Console.ReadLine();

            Console.Write("Ingrese su contraseña: ");
            string contraseña = Console.ReadLine();

            // Verificación de credenciales
            if (usuario == usuarioCorrecto)
            {
                if (contraseña == contraseñaCorrecta)
                {
                    Console.WriteLine("✅ Acceso concedido.");
                }
                else
                {
                    Console.WriteLine("❌ Contraseña incorrecta.");
                }
            }
            else
            {
                Console.WriteLine("❌ Usuario no registrado.");
            }
        }
    }
}

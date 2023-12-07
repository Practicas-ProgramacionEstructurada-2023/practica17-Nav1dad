using System;
using System.IO;
namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            int opciones;
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Buscar y Mostrar el contenido de un archivo");
                Console.WriteLine("2. Salir");
                Console.Write("Seleccione una opcion (1-2)");

                opciones = Convert.ToInt32(Console.ReadLine());

                switch (opciones)
                {
                    case 1:
                    ShowFileContent();
                    break;

                    case 2:
                    Console.WriteLine("\nSaliendo del programa.....");
                    break;

                    default:
                    Console.WriteLine("\nOpcion no valida. Intentelo de nuevo");
                    break;
                }   
                
            } while (opciones != 2);
        }
        static void ShowFileContent()
        {
            Console.Write("\nIngrese la ruta del archivo: ");
            string? filePath = Console.ReadLine();

            if (File.Exists(filePath))
            {
                string content = ReadFileContent(filePath);
                Console.WriteLine($"\nContendio del archvio:\n{content}");
            }
            else
            {
                Console.WriteLine("El archvio no existe en la ruta proporcionada.");
            }
        }
        static string ReadFileContent(string filePath)
        {
            try{
                    // LEER EL CONTENDIO DEL ARCHIVO
                    string content = File.ReadAllText(filePath);
                    return content;
            }
            catch (Exception ex)
            {
                return $"Error al leer el archvio: {ex.Message}";
            }
        }
    }
}
// NOMBRE: PEDRO ANTONIO ALVAREZ HERNANDEZ
// CODIGO: U20230697
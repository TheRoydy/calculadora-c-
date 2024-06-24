// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Calculadora Roydy :D");

double numero1, numero2, numero3 = 0, resultado = 0;
string tipoOperacion;
string numeroDeTipoOperacion = "";
bool operacionValida;
bool continuar = true;

while (continuar)
{
    Console.WriteLine("Digite el primer número: ");
    numero1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite el segundo número: ");
    numero2 = double.Parse(Console.ReadLine());

    do
    {
        Console.WriteLine("Qué operación desea realizar: \n");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.WriteLine("5. Porcentaje");
        Console.WriteLine("6. Promedio");
        Console.WriteLine("7. Salir");
        Console.WriteLine("\nSu operación: ");
        tipoOperacion = Console.ReadLine();

        operacionValida = true;

        switch (tipoOperacion)
        {
            case "1":
                resultado = numero1 + numero2;
                Console.WriteLine("Resultado de la Suma: " + resultado);
                break;
            case "2":
                resultado = numero1 - numero2;
                Console.WriteLine("Resultado de la Resta: " + resultado);
                break;
            case "3":
                resultado = numero1 * numero2;
                Console.WriteLine("Resultado de la Multiplicación: " + resultado);
                break;
            case "4":
                if (numero2 == 0)
                {
                    Console.WriteLine("Error: No se puede dividir por cero.");
                    operacionValida = false;
                }
                else
                {
                    resultado = numero1 / numero2;
                    Console.WriteLine("Resultado de la División: " + resultado);
                }
                break;
            case "5":
                resultado = (numero1 * numero2) / 100;
                Console.WriteLine("Resultado del Porcentaje: " + resultado);
                break;
            case "6":
                Console.WriteLine("Digite un tercer número: ");
                numero3 = double.Parse(Console.ReadLine());
                resultado = (numero1 + numero2 + numero3) / 3;
                Console.WriteLine("Resultado del Promedio: " + resultado);
                break;
            case "7":
                continuar = false;
                Console.WriteLine("Gracias por usar mi calculadora");
                break;
            default:
                Console.WriteLine("Operación no válida. Por favor, intente de nuevo.");
                operacionValida = false;
                break;
        }
    } while (!operacionValida && continuar);

    if (continuar)
    {
        Console.WriteLine("¿Desea realizar otra operación? (S/N): ");
        string respuesta = Console.ReadLine().ToUpper();
        if (respuesta != "S")
        {
            continuar = false;
            Console.WriteLine("Gracias por usar mi calculadora");
        }
    }
}
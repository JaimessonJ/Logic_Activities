using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Net;
using System.Runtime.ConstrainedExecution;

internal class Program
{
    private static void Main(string[] args)
    {
        //Realice un programa que solicite dos números, luego debe pedirse un número que seleccionará alguna operación aritmética desde un menú. Si introduce 1 los números se deben sumar, si introduce 2 los números se deben restar, si es 3 los números se multiplican y si introduce 4 los números se dividen(validar división por cero). Independientemente de la selección, imprima el resultado. Además, el programa debe tener la posibilidad de volver al menú para pedir 2 nuevos números y hacer la elección de la operación aritmética o digitar cero para finalizar el programa.

        //Variables

        double num1, num2;
        int opcion;
        double resultado = 0;
        bool continuar = true;
        string salir = null;

        do
        {
            Console.Clear();
            Console.WriteLine("Select one arimetic operation");
            Console.WriteLine("---1.  addition +        ---");
            Console.WriteLine("---2.  subtract -        ---");
            Console.WriteLine("---3.  multiply *        ---");
            Console.WriteLine("---4.  divide /          ---");
            Console.WriteLine("---0.  Exit              ---");
            opcion = int.Parse(Console.ReadLine());

            

            if (opcion != 0)
            {
                Console.WriteLine("Enter the first number: ");
                num1 = double.Parse(Console.ReadLine()); //double.Parse it is the same that Convert.ToDouble

                Console.WriteLine("Enter the second number: ");
                num2 = double.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        //Aquí implementamos la logica para el caso 1 y cerramos con la palabra "break"
                        resultado = num1 + num2;
                        Console.WriteLine($"Addition {num1} + {num2} = {resultado}");
                        break;

                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine($"Subtract {num1} - {num2} = {resultado}");
                        break;

                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine($"Multiply {num1} * {num2} = {resultado}");
                        break;

                    case 4:
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"Divide {num1} / {num2} = {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Error: it can´t divide by 0");
                        }
                        break;

                    case 0:
                        Console.WriteLine("You exit of the program");
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
            

            if (continuar)
            {
                //Métodos para poner un string en mayuscula o minuscula: ToUpper() ó ToLower

                Console.WriteLine("Do you want to do another operation? (S/N)");
                salir = Console.ReadLine().ToUpper(); //Depués de ingresar el dato por pantalla ToUpper lo convierte a may

                if (salir == "N")
                {

                    Console.WriteLine("exit to the program");
                    continuar = false;
                }
                else if (salir == "S")
                {
                    continuar = true;
                }
                else
                {
                    Console.WriteLine("Enter a valid option");
                    continuar = false;
                }
            }
        }

        while (continuar);
    }
}
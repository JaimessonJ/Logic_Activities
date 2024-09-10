using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        //Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor, el del medio y el menor de los números ingresados.


        //Declarations
        double mayor, medio, menor;
        double num1, num2, num3;

        //Request the data
        Console.Write("Introduzca el primer numero: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduzca el segundo numero: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduzca el tercer numero: ");
        num3 = Convert.ToDouble(Console.ReadLine());

        //Proceso

        if (num1 > num2 && num1 > num3)
        {
            mayor = num1;

            if (num2 > num3)
            {
                medio = num2;
                menor = num3;
            }
            else
            {
                medio = num3;
                menor = num2;
            }
        }
        else if (num2 > num3 && num2 > num1)
        {
            mayor = num2;
            if (num1 > num3)
            {
                medio = num1;
                menor = num3;
            }
            else
            {
                medio = num3;
                menor = num1;
            }
        }
        else
        {
            mayor = num3;
            if(num1 > num2)
            {
                medio = num1;
                menor = num2;
            }
            else
            {
                medio = num2;
                menor = num1;
            }
        }

        //Resultados
        Console.WriteLine("El numero mayor es: " + mayor);
        Console.WriteLine("El numero del medio es: " + medio);
        Console.WriteLine("El numero menor es: " + menor);
    }
}
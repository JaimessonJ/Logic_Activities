internal class Program
{
    private static void Main(string[] args)
    {
        //1.Programe un algoritmo que pida a usuario 2 números por pantalla y que muestre todos los números comprendidos entre ambos números incluyéndolos.

        //Datos de entrada

        int num1, num2;
        int menor, mayor;

        Console.WriteLine("Ingrese el primer numero : ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el primer numero :");
        num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 < num2)
        {
            menor = num1;
            mayor = num2;
        }

        else
        {
            mayor = num1;
            menor = num2;
        }

        for (int i = menor; i <= mayor; i++)
        {
            Console.Write(i + " ");
        }
        }
}
internal class Program
    
{
    private static void Main(string[] args)
    {
        //Lea las coordenadas de dos puntos y que muestre la distacia entre los puntos.

        //Datos de entrada
        //Declarar variables en este caso consta de 4
        double x1, x2, y1, y2, d;

        //Vamos a inicializar las variables pidiendo sus datos por pantalla
        Console.WriteLine("Ingrese la coordenada de x1: "); //Esta es la forma de escribir en pantalla
        x1 = Convert.ToDouble(Console.ReadLine()); //Esta es la forma de leer en pantalla

        Console.WriteLine("Ingrese la coordenada de y1: ");
        y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la coordenada de x2: ");
        x2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la coordenada de y2: ");
        y2 = Convert.ToDouble(Console.ReadLine());

        //Proceso - cálcular la variable "d"

        double x = (x2 - x1) * (x2 - x1);
        double y = (y2 - y1) * (y2 - y1);

        double suma = x + y;

        d = Math.Sqrt(suma);

        //Forma mas primitiva de concatenar


        //Forma de concatenar a través del simbolo "$". Se llama interpolación
        //Console.Write($"La distancia entre los pares ordenados ({x1},{y1} y {x2}, {y2} es: {d})");

        //Forma de concatenar con la clase String.format:
        Console.Write(string.Format("La distancia entre los pares oredenados ({0},{1} y ({2},{3}) es: {4}", x1, y1, x2, y2, d));

    }
}
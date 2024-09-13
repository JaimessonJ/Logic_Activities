internal class Program
{
    private static void Main(string[] args)
    {

        //Declaración de constantes:
        const decimal precioKiloManzana = 5000;
        decimal precioBruto, descuento, precioNeto, precioDescuento;

        //Una frutería ofrece las manzanas con descuento según la siguiente tabla:
        //Usted determina e precio del kilo de manzanas como desarrollador. Determinar y mostrar cuánto pagará una persona que compre manzanas en esa frutería y cuál descuento fue el que se le aplicó, si fue que se le aplicó alguno.

        //Datos de entrada: cantidad de kilos de las manzanas.
        //Proceso: calcular el valor neto de las manzanas y luego aplicarle descuento si es que le aplica.
        //Datos de salida: valor total y descuento aplicado.


        Console.Write("¿Cuantos kilos quieres comprar?: ");
        decimal kilosmanzanas = Convert.ToDecimal(Console.ReadLine());

        //Cálculos

        if (kilosmanzanas >= 0 && kilosmanzanas <= 2)
        {
            descuento = 0;
        }
        else if (kilosmanzanas > 2 && kilosmanzanas <= 5)
        {
            descuento = 10;
        }
        else if (kilosmanzanas > 5 && kilosmanzanas <= 10)
        {
            descuento = 15;
        }
        else
        {
            descuento = 20;
        }

        //Cálculo del precio bruto.
        precioBruto = precioKiloManzana * kilosmanzanas;

        //Cálculo del descuento.
         precioDescuento= precioBruto * (descuento / 100);

        //Cálculo del precio neto.
        precioNeto = precioBruto - precioDescuento;

        //Mostrar los resultados.
        Console.Write($"El total a pagar por {kilosmanzanas} es: {precioNeto}");
        Console.Write($"Se ha aplicado un descuento del {descuento}% que equivale a {precioDescuento}");

        Console.WriteLine();
    }
}
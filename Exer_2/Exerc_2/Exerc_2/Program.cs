using System.ComponentModel.Design;

public class Program
{
    private static void Main(string[] args)
    {
        //2. Lea la longitud de tres segmentos y que muestre si se puede construir un triángulo con estos segmentos.

        //Inputs declaration.
        double seg1, seg2, seg3;
        bool isTriangle;
        string msj;

        //Request the tada
        Console.Write("Enter the segment 1: ");
        seg1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the segment 2: ");
        seg2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the segment 3: ");
        seg3 = Convert.ToDouble(Console.ReadLine());


        //Process - Validation - Long Method


        /*if ((seg1 + seg2) > seg3) 
        {
            if ((seg1 + seg3) > seg3) 
            {
                if ((seg2 + seg3) > seg1) 
                {
                    isTriangle = true ;
                }
                else
                {
                    isTriangle = false ;
                }
            }
            else
            {
                isTriangle = false ;
            }
        }
        else
        {
            isTriangle = false ;
        }*/


        //Short Method

        if (((seg1 + seg2) > seg3) && ((seg1 + seg3) > seg2) && ((seg3 + seg2) > seg1))
        {
            isTriangle = true;
        }
        else
        {
            isTriangle = false;
        }

        //Show the message - Output

        if (isTriangle)
        {
            Console.Write("It can buil: ");
        }
        else
        {
            Console.Write("It can´t buil: ");
        }
    }
}
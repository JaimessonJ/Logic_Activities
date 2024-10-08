internal class Program
{
    private static void Main(string[] args)
    {
        //22.Se quiere crear un algoritmo en C# que calcule el IMC de N pacientes y luego lo clasifique dentro de una categoría:

        //-Si el IMC del paciente es menor a 18,5, entonces tiene peso insuficiente.
        //-Si el IMC está entre 18,5 y 24,9 se encuentre en la categoría de Peso Saludable.
        //-Si el IMC está entre 25,0 y 29,9 entonces tiene sobrepeso.
        //- Si el IMC es mayor de 29.9 entonces tiene obesidad.

        //Mostrar en pantalla la categoría de cada uno de los pacientes.La aplicación debe estar en capacidad de pedirle al usuario si quiere volver a calcular.

        //valores de entrada
        double peso, estatura, imc;
        bool continuar = true;
        int n;
        string respuesta;
        while (continuar)
        {
            Console.WriteLine("Ingrese el número de pacientes: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Ingrese el peso del paciente # {i + 1} en kg: ");
                peso = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Ingrese la estatura del paciente {i + 1} en 'M': ");
                estatura = Convert.ToDouble(Console.ReadLine());    

                //Calcular el IMC

                imc = peso / Math.Pow(2, estatura); //Es lo mismo que estatura * estatura.

                switch (imc) //imc = 18 entoces cat = 18
                {
                    case double cat when cat < 18.5:
                        Console.WriteLine($"El paciente tiene un IMC: {imc:F2} está en la categoría de peso insuficiente");
                        break;

                    case double cat when cat >= 18.5 && cat < 25:
                        Console.WriteLine($"El paciente tiene un IMC: {imc:F2} está en la categoría de peso saludable");
                        break;

                    case double cat when cat >= 25 && cat < 30:
                        Console.WriteLine($"El paciente tiene un IMC: {imc:F2} está en la categoría de sobre peso");
                        break;

                    case double cat when cat >= 30:
                        Console.WriteLine($"El paciente tiene un IMC: {imc:F2} está en la categoría de obecidad");
                        break;

                    default:
                        Console.WriteLine("El paciente no se encuentra en ninguna categoría");
                        break;
                }
            }
            //Retorno del while
            Console.WriteLine("¿Desea calcular el imc de más pacientes? (S/N)");
            respuesta = Console.ReadLine().ToUpper();

            if ( respuesta == "N")
            {
                continuar = false;
            }

        }

    }
}
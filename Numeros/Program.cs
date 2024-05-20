using System;

namespace MayorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer número:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el tercer número:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int mayor = num1;
            int menor = num1;

            if (num2 > mayor)
            {
                mayor = num2;
            }
            if (num3 > mayor)
            {
                mayor = num3;
            }

            if (num2 < menor)
            {
                menor = num2;
            }
            if (num3 < menor)
            {
                menor = num3;
            }

            Console.WriteLine("El número mayor es: " + mayor);
            Console.WriteLine("El número menor es: " + menor);
        }
    }
}
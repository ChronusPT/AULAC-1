using System;

namespace Aula1_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ex1.1 - escrever nome;
            Console.WriteLine("Hello!");
            Console.WriteLine("Diogo B!");

            // Ex1.2 - somar 2 inteiros;

            int valor1 = 5;
            int valor2 = 7;
            int soma = 0;

            soma = valor1 + valor2;

            Console.WriteLine("O valor da soma é :");
            Console.Write(soma);

            //Ex1.3 - pedir uma valor ao utilizador e mostrar;

            string num;

            Console.WriteLine("\nIndique o valor ->");
            num = Console.ReadLine();
            Console.WriteLine("O valor inserido é {0} :", num);
            //Console.WriteLine();
        }
    }
}

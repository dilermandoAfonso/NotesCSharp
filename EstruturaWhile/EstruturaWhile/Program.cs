using System;
using System.Globalization;

namespace EstruturaWhile {
    class Program {
        static void Main(string[] args) {

            double numero, raiz = 0;

            Console.Write("Digite um número: ");
            numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Exemplo da estrutura de repetição "While"
            while (numero >= 0.0) {
                raiz = Math.Sqrt(numero);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            Console.WriteLine("Número negativo.");
        }
    }
}
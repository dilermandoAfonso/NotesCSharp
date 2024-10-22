using System;

namespace EstruturaFor {
    class Program {
        static void Main(string[] args) {
            int soma = 0;

            Console.WriteLine("Quantos números você vai digitar?");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++) { 
                Console.Write($"Valor #{i}: ");
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor;
            }

            Console.WriteLine($"Resultado da soma: {soma}");
        }
    }
}
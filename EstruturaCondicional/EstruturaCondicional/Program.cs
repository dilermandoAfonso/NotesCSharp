using System;

namespace EstruturaCondicional {
    class Program {
        static void Main(string[] args) {

            int x = 10;

            //Estrutura condicional simples
            if (x < 5) {
                Console.WriteLine("Hello World");
            }

            //Estrutura condicional composta
            Console.Write("Digite o número: ");
            int y = int.Parse(Console.ReadLine());

            if (y % 2 == 0) {
                Console.WriteLine("Par!");
            } else {
                Console.WriteLine("Ímpar!");
            }

            //Encadeamentos
            Console.Write("Hora atual: ");
            int z = int.Parse(Console.ReadLine());

            if (z < 12) {
                Console.WriteLine("Bom dia!");
            }
            else if (z < 18) {
                Console.WriteLine("Boa tarde");
            }
            else {
                Console.WriteLine("Boa noite");
            }
        }
    }
}
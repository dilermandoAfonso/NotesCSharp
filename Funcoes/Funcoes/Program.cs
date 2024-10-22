using System;

namespace Funcoes {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite os três números: ");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            /* A lógica com as condicionais ficaria: 
           
            if (n1 > n2 && n1 > n3) {
                Console.WriteLine($"O maior é o {n1}");
            }
            else if (n2 > n3) {
                Console.WriteLine($"O maior é o {n2}");
            }
            else {
                Console.WriteLine($"O maior é o {n3}");
            } */

            //É possível melhorar o código usando funções: 
            double resultado = Maior(n1, n2, n3);

            Console.WriteLine($"O maior é o {resultado}");

        }

        static int Maior(int a, int b, int c) {

            //tratando-se de debugging, F10 debuga ignorando a função, f11 a inclue. Além disso, F9 serve para colocar os breakpoints.
            int maior;

            if (a > b && a > c) {
                maior = a;
            }
            else if (b > c) {
                maior = b;
            }
            else {
                maior = c;
            }

            return maior;
        }
    }
}
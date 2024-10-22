using System;

namespace OperadoresAtribuicao {
    class Program {

        static void Main(string[] args) {
            int a = 10;

            Console.WriteLine(a);
            
            //Operadores de atribuição acumulativa.
            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            //usando string
            string s = "ABC";

            s += "DEF";
            Console.WriteLine("\n" + s);

            /* Outras opções: -= | /= | %= */

            //utilizando incremento
            int valor = 10;

            valor++;
            Console.WriteLine("\n" + valor);

            valor--;
            Console.WriteLine(valor);

            //primeiro a variável B RECEBE o valor de A e depois INCREMENTA o valor da variável A
            int valorA = 10;
            int valorB = valorA++;
            Console.WriteLine("\nValor A: " + valorA);
            Console.WriteLine("Valor B: " + valorB);
            
            //primeiro a variável D INCREMENTA o valor da variável C e depois RECEBE o seu valor
            int valorC = 10;
            int valorD = ++valorC;

            Console.WriteLine("\nValor C: " + valorC);
            Console.WriteLine("Valor D: " + valorD);

        }
    }

}
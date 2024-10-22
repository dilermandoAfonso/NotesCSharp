using System;

namespace OperadoresLogicos{
    class Program {
        static void Main(string[] args) {

            /* A expressão vai dá True porque na tabela verdade de "OU", só é falso quando ambos
            são falsos */
            bool c1 = 2 > 3 || 4 != 5;

            /* A expressão vai ser True porque o resultado da primeira está negando um 
            valor falso e o segundo é verdadeiro. V && V é True na tabela "E" */
            bool c2 = !(2 > 3) && 4 != 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine("");

            /* Precedência — ! > && > || — define a prioridade. Neste caso, o c2 && c3 será resolvido
             primeiro. O resultado de c2 é verdadeiro e o resultado de c3 é falso. C2 && C3 = False.
             c1 é verdadeiro, logo true || false = True */
            bool c3 = 10 < 5;
            bool c4 = c1 || c2 && c3;
            
            Console.WriteLine(c4);
        }
    }
}
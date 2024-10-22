using System;

namespace OperadoresComparativos {
    class Program {
        static void Main(string[] args) {

            int valor = 10;

            bool b1 = valor < 10;
            bool b2 = valor < 20;

            bool b3 = valor > 10;
            bool b4 = valor > 5;

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
            Console.WriteLine(b4);
            Console.WriteLine("");

            bool b5 = valor <= 10;
            bool b6 = valor >= 10;
            bool b7 = valor == 10;

            Console.WriteLine(b5);
            Console.WriteLine(b6);
            Console.WriteLine(b7);

            bool b8 = valor != 10;
            Console.WriteLine(b8);
        }
    }
}
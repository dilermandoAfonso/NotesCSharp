using System;
using System.Globalization;

namespace ImplicitExplicitConversion {
    class Program {
        static void Main(string[] args) {

            /*exemplo de conversão implícita de float para double
             onde a variável y é double, mas recebe um conteúdo float */
            float x = 4.5f;
            double y = x;

            Console.WriteLine(y);

            double alpha;
            float beta;

            /*Não é possível converter implicitamente (beta = alpha) alpha para beta, 
            o número de bytes de beta é menor que alpha (é possível conversão explícita) */

            //exemplo de conversão explícita
            alpha = 5.1;
            beta = (float)alpha;

            Console.WriteLine(beta);

            double a = 5.1;
            int b = (int)a;

            Console.WriteLine(b);

            //dividir números int não irá mostrar o valor exato, porque não possui casas decimais
            int valor1 = 5;
            int valor2 = 2;

            double resultado = valor1 / valor2;

            Console.WriteLine(resultado);

            //para mostrar o valor exato, basta usar um casting para double

            int valorA = 5;
            int valorB = 2;

            resultado = (double) valorA / valorB;
            Console.WriteLine(resultado);

        }
    
    }

}
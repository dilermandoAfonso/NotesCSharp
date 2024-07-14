// See https://aka.ms/new-console-template for more information

using System;

namespace TipoDados {
    class Program {
        static void Main(string[] args) {

            sbyte x = 100; // tipo do C#
            sbyte y = 50; // tipo do namespace System

            byte n1 = 254;

            /* No exemplo a seguir, quando ocorre o overflow, 
            o resultado vai para o limite oposto. Isto é, 0. Byte não suporta números negativos */

            byte n2 = 255;
            n2++;

            /* No caso do tipo SByte, ele irá passar para o -128 justamente 
            por ser o limite oposto, uma vez que tal tipo é "Signed" e engloba valores negativos. */

            sbyte n3 = 127;
            n3++;

            /* Exemplo com int */

            int n4 = 1000; //Está dentro do limite dos valores int
            int n5 = 2147483647; //Caso coloquemos o valor final "48", não irá pegar pois extrapola o limite.

            /* Para armazenar valores que extrapolam o limite do int, basta usar long.
            Nota que o uint (sugerido pelo erro) não suporta números negativos */

            long n6 = 2147483648L; //Recomendável colocar o L no final para sinalizar que estamos trabalhando com Long

            bool booleano = true; //valores booleanos

            char character1 = 'A'; //aspas simples para representar o caractére

            char character2 = '\u0041'; //utilizando código unicode para representar a letra A 

            float floatType = 4.8F; //é preciso indicar o tipo com o f no final. Do contrário, dará erro. 

            double doubleType = 1.5; //exemplo tipo double

            string nome = "Dilermando Afonso"; //exemplo tipo nome (não faz parte dos tipos básicos do C#)

            object obj = "Maria José "; //Um tipo genérico onde posso utilizar qualquer um dos tipos anteriores
            object obj2 = 4.5f; //Exemplo de utilização de um tipo diferente de dado

            /*Não é preciso decorar os limites de cada tipo de dado, basta apenas utilizar as propriedades MinValue ou MaxValue*/

            int intMinValue = int.MinValue;
            int intMaxValue = int.MaxValue;

            decimal decMinValue = decimal.MinValue;
            decimal decMaxValue = decimal.MaxValue;

            Console.WriteLine("Valor de X: " + x);
            Console.WriteLine("Valor de Y: " + y);
            Console.WriteLine("\nValor de n1: " + n1);
            Console.WriteLine("Valor de n2: " + n2);
            Console.WriteLine("Valor de n3: " + n3);
            Console.WriteLine("Valor de n4: " + n4);
            Console.WriteLine("Valor de n5: " + n5);
            Console.WriteLine("Valor de n6: " + n6);
            Console.WriteLine("\nValor de booleano: " + booleano);
            Console.WriteLine("Valor de character1: " + character1);
            Console.WriteLine("Valor de character2: " + character2);
            Console.WriteLine("Valor de floatType: " + floatType);
            Console.WriteLine("Valor de doubleType: " + doubleType);
            Console.WriteLine("Valor de nome: " + nome);
            Console.WriteLine("\nValor de obj: " + obj);
            Console.WriteLine("Valor de obj2: " + obj2);
            Console.WriteLine("\nValor mínimo de int: " + intMinValue);
            Console.WriteLine("Valor máximo de int: " + intMaxValue);
            Console.WriteLine("\nValor mínimo de decimal: " + decMinValue);
            Console.WriteLine("Valor máximo de decimal: " + decMaxValue);
        }
    }
}
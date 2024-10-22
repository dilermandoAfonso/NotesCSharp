using System;
using System.Globalization;

namespace EntradaDados2 {
    class Program {
        static void Main(string[] args) {

            //O ".Parse" serve para converter em String, já que o ReadLine apenas lê dados string
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());

            /* O double só aceita o separador de decimais do país onde o OS está configurado. Por isso, 
             caso você tente utilizar o ponto, ele irá ignorá-lo */
            double n2 = double.Parse(Console.ReadLine());

            /* Para aceitar qualquer separador, basta utilizar o System.Globalization para ser possível 
            usar o "CultureInfo" e incluir o InvariantCulture da seguinte forma */
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /* Caso queira printar sem levar em consideração as regras do separador, basta por o Invariant 
             na saída do dado */
            double n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4.ToString("F2", CultureInfo.InvariantCulture));

            string[] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
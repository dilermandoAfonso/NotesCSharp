
using System;
using System.Globalization;

namespace SaidaDados {
    internal class Program {
        static void Main(string[] args) {
            
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";
            char genero = 'F';
            

            Console.Write("Hello World!");
            Console.WriteLine("Bom dia");
            Console.WriteLine("Boa noite");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);

            //O "F2" serve para delimitar o número de casas decimais
            Console.WriteLine("\nSaldo com delimitação de 2 casas: " + saldo.ToString("F2"));

            //Outro exemplo
            Console.WriteLine("Saldo com delimitação de 4 casas: " + saldo.ToString("F4"));

            //Usando InvarianteCulture para desconsiderar formatações específicas de países
            Console.WriteLine("Saldo com delimitação de 4 casas: " + saldo.ToString("F4", CultureInfo.InvariantCulture));

            //Placeholder
            Console.WriteLine("\n{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); //No caso dos placeholders, para diminuir o número de casas decimais, basta colocar ":F[numero de casas]"

            //Concatenação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            //Interpolação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");


        }
    }
}
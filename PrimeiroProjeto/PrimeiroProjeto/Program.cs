using System;
using System.Globalization;

namespace PrimeiroProjeto 
{
    internal class Program
    {
        static void Main(string[] args)     
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.Write("Hello World!");
            Console.WriteLine("Bom dia");
            Console.WriteLine("Boa noite");
            Console.WriteLine("_________________");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine("Saldo com delimitação de 2 casas: " + saldo.ToString("F2")); //O "F2" serve para delimitar o número de casas decimais
            Console.WriteLine("Saldo com delimitação de 4 casas: " + saldo.ToString("F4")); //Outro exemplo
            Console.WriteLine("Saldo com delimitação de 4 casas: " + saldo.ToString("F4", CultureInfo.InvariantCulture)); //Usando InvarianteCulture para desconsiderar formatação específicas de países
        }
    }
}
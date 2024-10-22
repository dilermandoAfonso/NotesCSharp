using System;

namespace EntradaDados {
    class Program {
        static void Main(string[] args) {

            //Exemplo de inserção de dados
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            //reconhece cada parte do string pelas partes citadas no split e insere nas posições do vetor

            string s = Console.ReadLine();

            /*Aqui podemos apagar a variavél s e trocar a atribuição do 'array'
            para "Console.ReadLine().Split(' ');" */
            string[] array = s.Split(' ');

            string p1 = array[0];
            string p2 = array[1];
            string p3 = array[2];

            Console.WriteLine("Você digitou");
            Console.WriteLine(frase); 
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }
    
    }
}
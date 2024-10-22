
using System;

namespace OperadoresAritmeticos {
    class Program {
        static void Main(string[] args) {

            int n1 = 3 + 4 * 2;
            Console.WriteLine(n1);

            int n2 = (3 + 4) * 2;
            Console.WriteLine(n2);

            int n3 = 17 % 3;
            Console.WriteLine(n3);

            /* Criando uma variável int, propositalmente errada para
            tal operação, com fins didáticos */
            
            int n4 = 10 / 8;
            Console.WriteLine("\n" + n4);

            /* Caso mude para double, continuará imprimindo um resultado inteiro porque
             o compilador acha que você quer fazer a operação com números int, já que
             os valores são inteiros e ocorre uma conversao implícita. Segue o exemplo a seguir */

            //Necessário um casting para imprimir corretamente
            double valorDouble1 = (double)10 / 8; 
            Console.WriteLine(valorDouble1);

            //Colocar o dividendo em formato double também funciona
            double valorDouble2 = 10.0 / 8.0;
            Console.WriteLine(valorDouble2);

            /* Exemplo - resolução de equação quadrática (lembre-se 
            sempre de colocar as casas decimais em operações com double) */
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            /* Colocar um parenteses para evitar a priorização 
            da multiplicação e divisão, ambos possuem o msm nível de
            prioridade. Por isso, é necessário colocar parenteses de
            ambos os lados da divisão */

            double resultadoX1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double resultadoX2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("\n" + delta);
            Console.WriteLine(resultadoX1);
            Console.WriteLine(resultadoX2);
        }    
    
    }

}
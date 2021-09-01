//Frederico Guilherme Camilli Proença RA:200925

using System;

namespace Dados_de_Pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis A e B da classe Person.
            Person A, B;

            //Declaração das pessoas A e B.
            A = new Person();
            B = new Person();

            //Inserção do usuário sobre a pessoa A.
            Console.WriteLine("Insira o nome da pessoa A:");
            A.name = Console.ReadLine();
            Console.WriteLine("Agora insira a idade da pessoa A:");
            A.age = int.Parse(Console.ReadLine());

            //Inserção do usuário sobre a pessoa B.
            Console.WriteLine("Insira o nome da pessoa B:");
            B.name = Console.ReadLine();
            Console.WriteLine("Agora insira a idade da pessoa B:");
            B.age = int.Parse(Console.ReadLine());

            //Cálculo para identificar a pessoa mais velha.
            if (A.age > B.age)
            {
                Console.WriteLine("{0} é mais velho(a) que {1}.", A.name, B.name);
            }
            else if (A.age < B.age)
            {
                Console.WriteLine("{0} é mais velho(a) que {1}.", B.name, A.name);
            }
            else
            {
                Console.WriteLine("Ambas as pessoas possuem a mesma idade.");
            }
        }
    }
}

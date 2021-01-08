using System;

namespace Projeto_de_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome");
            string nomecompleto = Console.ReadLine();
            Console.WriteLine("Seja Bem-vindo(a), "+nomecompleto);

            //programa exercicio - aula

            int valorUm;
            int valorDois;
        

            //Entrada de Dados
            Console.WriteLine("Some dois valores inteiros");
            Console.WriteLine("--------------------------");
            Console.Write("Digite o primeiro valor: ");
            valorUm = int.Parse (Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            valorDois = int.Parse (Console.ReadLine());
            Console.WriteLine("--------------------------");

            //Processamento
            int soma = valorUm + valorDois;

            //Exibição
            Console.WriteLine("O resultado final da soma de "+valorUm+" e "+valorDois+" é igual à: "+soma);
            
        }
    }
}

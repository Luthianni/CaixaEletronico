using System;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            bool programa = true;
            while (programa)
            {
                Console.WriteLine("Caixa Eletronico");
                Console.WriteLine("Para sair digite 'sair'");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Digite o valor do saque: ");
                var r = Console.ReadLine();
                if (r == "sair")
                {
                    Console.WriteLine(">> Deseja Mesmo sair? s/n <<");
                    if (Console.ReadLine().ToUpper() != "n")
                    {
                        Console.Clear();
                        continue;
                    }
                    programa = false;
                    continue;
                }
                int valor = 0;
                try
                {
                    valor = int.Parse(r);
                }
                catch
                {
                    Console.WriteLine("Digite um número!");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    continue;
                }
                int n100 = valor / 100; //contagem das notas de 100R$
                int resto = valor - (n100 * 100); //valor menos as notas de 100.
                int n50 = resto / 50;//contagem das notas de 50R$
                resto = resto - (n50 * 50);
                int n20 = resto / 20;//contagem das notas de 20R$
                resto = resto - (n20 * 20);
                int n10 = resto / 10;//contagem das notas de 10R$
                resto = resto - (n10 * 10);
                
                Console.WriteLine();
                Console.WriteLine("Quantidade de notas:");
                Console.WriteLine();
                Console.WriteLine("Notas de 100R$:  " + n100);
                Console.WriteLine();
                Console.WriteLine("Notas de 50R$:  " + n50);
                Console.WriteLine();
                Console.WriteLine("Notas de 20R$:  " + n20);
                Console.WriteLine();
                Console.WriteLine("Notas de 10R$:  " + n10);
                Console.WriteLine();                
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
    

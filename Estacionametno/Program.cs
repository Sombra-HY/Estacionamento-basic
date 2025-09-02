using Estacionametno.service;
using System;

class Program
{
    static void Main()
    {
        Estacionamento estacionamento = new Estacionamento(5m, 10m); // R$10 inicial + R$5 por hora
        bool rodando = true;

        while (rodando)
        {
            Console.WriteLine("\n=== Estacionamento ===");
            Console.WriteLine("1 - Adicionar carro");
            Console.WriteLine("2 - Remover carro");
            Console.WriteLine("3 - Listar carros");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Placa: ");
                    string placaAdd = Console.ReadLine();
                    Console.Write("Hora de entrada: ");
                    int horai = int.Parse(Console.ReadLine() ?? "0");
                    Console.Write("Hora de saída: ");
                    int horaf = int.Parse(Console.ReadLine() ?? "0");

                    estacionamento.AdicionarPlaca(placaAdd, horai, horaf);
                    break;

                case "2":
                    Console.Write("Placa a remover: ");
                    string placaRem = Console.ReadLine();
                    estacionamento.RemoverPlaca(placaRem);
                    break;

                case "3":
                    estacionamento.ListarPlacas();
                    break;

                case "4":
                    rodando = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        Console.WriteLine("Programa encerrado.");
    }
}
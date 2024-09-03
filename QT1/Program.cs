using System;
class Program
{
    static void Main()
    {
        //solicita o nome do personagem
        Console.Write("Digite o nome do personagem: ");
        string nome = Console.ReadLine();

        //solicita a idade do personagem
        Console.Write("Digite a idade do personagem: ");
        int idade = int.Parse(Console.ReadLine());

        //solicitar o nivel inicial do personagem
        Console.Write("Digite o nível inicial do personagem: ");
        int nivelInicial = int.Parse(Console.ReadLine());

        //solicitar a classe do personagem
        Console.Write("Digite a classe do personagem: ");
        string classe = Console.ReadLine();

        //solicitar a raca do personagem
         Console.Write("Digite a raça do personagem: ");
        string raca = Console.ReadLine();

        //exibe os resultados
        Console.WriteLine("\nDados do personagem:");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Nível Inicial: {nivelInicial}");
        Console.WriteLine($"Classe: {classe}");
        Console.WriteLine($"Raça: {raca}");
    }

}
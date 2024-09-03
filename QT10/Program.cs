using System;

class Program
{
    static void Main()
    {
        //solicita os pontos de vida iniciais
        Console.Write("Digite os pontos de vida iniciais: ");
        double pontosVidaIniciais;
        while (!double.TryParse(Console.ReadLine(), out pontosVidaIniciais) || pontosVidaIniciais < 0)
        {
            Console.Write("Pontos de vida iniciais inválidos. Digite novamente: ");
        }

        //solicita o aumento de vida por nível
        Console.Write("Digite o aumento de vida por nível: ");
        double aumentoVidaPorNivel;
        while (!double.TryParse(Console.ReadLine(), out aumentoVidaPorNivel) || aumentoVidaPorNivel < 0)
        {
            Console.Write("Aumento de vida por nível inválido. Digite novamente: ");
        }

        //solicita o número de níveis alcançados
        Console.Write("Digite o número de níveis alcançados: ");
        int niveisAlcancados;
        while (!int.TryParse(Console.ReadLine(), out niveisAlcancados) || niveisAlcancados < 0)
        {
            Console.Write("Número de níveis inválido. Digite novamente: ");
        }

        //calcula a quantidade de pontos de vida após alcançar o novo nível
        double pontosVidaFinais = pontosVidaIniciais + (aumentoVidaPorNivel * niveisAlcancados);

        //exibe a quantidade de pontos de vida após alcançar o novo nível
        Console.WriteLine($"\nQuantidade de pontos de vida após alcançar o novo nível: {pontosVidaFinais:F2}");
    }
}

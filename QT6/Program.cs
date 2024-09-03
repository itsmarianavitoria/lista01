using System;
class Program
{
    static void Main()
    {
        //solicita  o valor em moedas de ouro
        Console.Write("Digite o valor em moedas de ouro: ");
        double valorMoedasOuro;
        while (!double.TryParse(Console.ReadLine(), out valorMoedasOuro) || valorMoedasOuro < 0)
        {
            Console.Write("Valor inválido. Digite novamente: ");
        }

        //solicita o valor da taxa de conversão
        Console.Write("Digite a taxa de conversão (1 cristal = X moedas de ouro): ");
        double taxaConversao;
        while (!double.TryParse(Console.ReadLine(), out taxaConversao) || taxaConversao <= 0)
        {
            Console.Write("Taxa de conversão inválida. Digite novamente: ");
        }

        //solicita o bônus de conversão baseado em eventos
        Console.Write("Digite o bônus de conversão baseado em eventos (em percentual, ex: 10 para 10%): ");
        double bonusEventos;
        while (!double.TryParse(Console.ReadLine(), out bonusEventos) || bonusEventos < 0)
        {
            Console.Write("Bônus inválido. Digite novamente: ");
        }

        //solicita o bônus de conversão baseado em habilidades
        Console.Write("Digite o bônus de conversão baseado em habilidades (em percentual, ex: 15 para 15%): ");
        double bonusHabilidades;
        while (!double.TryParse(Console.ReadLine(), out bonusHabilidades) || bonusHabilidades < 0)
        {
            Console.Write("Bônus inválido. Digite novamente: ");
        }

        //calcula o total de bônus de conversão
        double bonusTotal = 1 + (bonusEventos / 100) + (bonusHabilidades / 100);

        //calcula o número de cristais que o jogador pode obter
        double cristaisObtidos = (valorMoedasOuro / taxaConversao) * bonusTotal;

        //exibe o número de cristais que o jogador pode obter
        Console.WriteLine($"\nNúmero de cristais que o jogador pode obter: {cristaisObtidos:F2}");
    }
}
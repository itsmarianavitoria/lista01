using System;
class Program
{
    static void Main()
    {
        //solicita o número de inimigos derrotados
        Console.Write("Digite o número de inimigos derrotados: ");
        int inimigosDerrotados;
        while (!int.TryParse(Console.ReadLine(), out inimigosDerrotados) || inimigosDerrotados < 0)
        {
            Console.Write("Número inválido. Digite novamente: ");
        }

        //solicita a pontuação por inimigo
        Console.Write("Digite a pontuação por inimigo: ");
        int pontuacaoPorInimigo;
        while (!int.TryParse(Console.ReadLine(), out pontuacaoPorInimigo) || pontuacaoPorInimigo < 0)
        {
            Console.Write("Pontuação inválida. Digite novamente: ");
        }

        //solicita o bônus por missão
        Console.Write("Digite o bônus por missão: ");
        int bonusMissao;
        while (!int.TryParse(Console.ReadLine(), out bonusMissao) || bonusMissao < 0)
        {
            Console.Write("Bônus inválido. Digite novamente: ");
        }

        //solicita o multiplicador para o tipo de inimigo
        Console.Write("Digite o multiplicador para o tipo de inimigo: ");
        double multiplicadorTipoInimigo;
        while (!double.TryParse(Console.ReadLine(), out multiplicadorTipoInimigo) || multiplicadorTipoInimigo < 0)
        {
            Console.Write("Multiplicador inválido. Digite novamente: ");
        }

        //solicita o multiplicador para a dificuldade
        Console.Write("Digite o multiplicador para a dificuldade: ");
        double multiplicadorDificuldade;
        while (!double.TryParse(Console.ReadLine(), out multiplicadorDificuldade) || multiplicadorDificuldade < 0)
        {
            Console.Write("Multiplicador inválido. Digite novamente: ");
        }

        //calcula a pontuação final
        double pontuacaoTotal = inimigosDerrotados * pontuacaoPorInimigo;
        double pontuacaoComMultiplicador = pontuacaoTotal * multiplicadorTipoInimigo * multiplicadorDificuldade;
        double pontuacaoFinal = pontuacaoComMultiplicador + bonusMissao;

        //exibe a pontuação final
        Console.WriteLine("\nPontuação Final:");
        Console.WriteLine($"Número de Inimigos Derrotados: {inimigosDerrotados}");
        Console.WriteLine($"Pontuação por Inimigo: {pontuacaoPorInimigo}");
        Console.WriteLine($"Bônus por Missão: {bonusMissao}");
        Console.WriteLine($"Multiplicador para o Tipo de Inimigo: {multiplicadorTipoInimigo}");
        Console.WriteLine($"Multiplicador para a Dificuldade: {multiplicadorDificuldade}");
        Console.WriteLine($"Pontuação Total: {pontuacaoTotal}");
        Console.WriteLine($"Pontuação com Multiplicadores: {pontuacaoComMultiplicador}");
        Console.WriteLine($"Pontuação Final: {pontuacaoFinal}");
        
    }
}
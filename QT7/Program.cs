using System;
class Program
{
    static void Main()
    {
        //solicita a quantidade de XP acumulado
        Console.Write("Digite a quantidade de XP acumulado: ");
        double xpAcumulado;
        while (!double.TryParse(Console.ReadLine(), out xpAcumulado) || xpAcumulado < 0)
        {
            Console.Write("XP inválido. Digite novamente: ");
        }

        //solicita o XP concedido pelo primeiro tipo de inimigo
        Console.Write("Digite o XP concedido pelo primeiro tipo de inimigo: ");
        double xpTipo1;
        while (!double.TryParse(Console.ReadLine(), out xpTipo1) || xpTipo1 < 0)
        {
            Console.Write("XP do primeiro tipo de inimigo inválido. Digite novamente: ");
        }

        //solicita o XP concedido pelo segundo tipo de inimigo
        Console.Write("Digite o XP concedido pelo segundo tipo de inimigo: ");
        double xpTipo2;
        while (!double.TryParse(Console.ReadLine(), out xpTipo2) || xpTipo2 < 0)
        {
            Console.Write("XP do segundo tipo de inimigo inválido. Digite novamente: ");
        }

        //solicita o número de inimigos do primeiro tipo derrotados
        Console.Write("Digite o número de inimigos do primeiro tipo derrotados: ");
        int inimigosTipo1;
        while (!int.TryParse(Console.ReadLine(), out inimigosTipo1) || inimigosTipo1 < 0)
        {
            Console.Write("Número de inimigos do primeiro tipo inválido. Digite novamente: ");
        }

        //solicita o número de inimigos do segundo tipo derrotados
        Console.Write("Digite o número de inimigos do segundo tipo derrotados: ");
        int inimigosTipo2;
        while (!int.TryParse(Console.ReadLine(), out inimigosTipo2) || inimigosTipo2 < 0)
        {
            Console.Write("Número de inimigos do segundo tipo inválido. Digite novamente: ");
        }

        //solicita a constante de nível
        Console.Write("Digite a constante de nível (XP necessária para subir de nível): ");
        double constanteNivel;
        while (!double.TryParse(Console.ReadLine(), out constanteNivel) || constanteNivel <= 0)
        {
            Console.Write("Constante de nível inválida. Digite novamente: ");
        }

        //calcula o XP total acumulado após a batalha
        double xpTotal = xpAcumulado + (xpTipo1 * inimigosTipo1) + (xpTipo2 * inimigosTipo2);

        //calcula o nível atual do jogador
        int nivelAtual = (int)(xpTotal / constanteNivel);

        //exibe o XP total acumulado e o nível atual do jogador
        Console.WriteLine($"\nXP Total Acumulado: {xpTotal}");
        Console.WriteLine($"Nível Atual do Jogador: {nivelAtual}");
    }
}
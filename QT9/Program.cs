using System;

class Program
{
    static void Main()
    {
        //solicita o valor da força do personagem
        Console.Write("Digite o valor da força do personagem: ");
        double forca;
        while (!double.TryParse(Console.ReadLine(), out forca) || forca < 0)
        {
            Console.Write("Valor inválido. Digite novamente: ");
        }

        //solicita o poder da arma
        Console.Write("Digite o poder da arma: ");
        double poderArma;
        while (!double.TryParse(Console.ReadLine(), out poderArma) || poderArma < 0)
        {
            Console.Write("Valor inválido. Digite novamente: ");
        }

        //solicita o bônus de habilidades
        Console.Write("Digite o bônus de habilidades: ");
        double bonusHabilidades;
        while (!double.TryParse(Console.ReadLine(), out bonusHabilidades) || bonusHabilidades < 0)
        {
            Console.Write("Valor inválido. Digite novamente: ");
        }

        //solicita o modificador de crítico
        Console.Write("Digite o modificador de crítico: ");
        double modificadorCritico;
        while (!double.TryParse(Console.ReadLine(), out modificadorCritico) || modificadorCritico < 0)
        {
            Console.Write("Valor inválido. Digite novamente: ");
        }

        //solicita o modificador para o tipo da arma
        Console.Write("Digite o modificador para o tipo da arma: ");
        double modificadorTipoArma;
        while (!double.TryParse(Console.ReadLine(), out modificadorTipoArma) || modificadorTipoArma < 0)
        {
            Console.Write("Valor inválido. Digite novamente: ");
        }

        //calcula o total de ataque do personagem
        double totalAtaque = (forca + poderArma + bonusHabilidades) * modificadorCritico * modificadorTipoArma;

        //exibe o total de ataque
        Console.WriteLine($"\nTotal de ataque do personagem: {totalAtaque:F2}");
    }
}

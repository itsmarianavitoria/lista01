using System;
class Program
{
    static void Main()
    {
        //solicita o valor inicial da vida
        Console.Write("Digite o valor da vida inicial: ");
        double vidaInicial;
        while (!double.TryParse(Console.ReadLine(), out vidaInicial) || vidaInicial < 0)
        {
            Console.Write("Valor inválido. Digite novamente: ");
        }

        //solicita o dano recebido
        Console.Write("Digite o dano recebido: ");
        double danoRecebido;
        while (!double.TryParse(Console.ReadLine(), out danoRecebido) || danoRecebido < 0)
        {
            Console.Write("Dano inválido. Digite novamente: ");
        }

        //solicita o bônus de regeneração
        Console.Write("Digite o bônus de regeneração: ");
        double bonusRegeneracao;
        while (!double.TryParse(Console.ReadLine(), out bonusRegeneracao) || bonusRegeneracao < 0)
        {
            Console.Write("Bônus inválido. Digite novamente: ");
        }

        //solicita o modificador para equipamentos
        Console.Write("Digite o modificador para equipamentos: ");
        double modificadorEquipamentos;
        while (!double.TryParse(Console.ReadLine(), out modificadorEquipamentos) || modificadorEquipamentos < 0)
        {
            Console.Write("Modificador inválido. Digite novamente: ");
        }

        //solicita o modificador para habilidades
        Console.Write("Digite o modificador para habilidades: ");
        double modificadorHabilidades;
        while (!double.TryParse(Console.ReadLine(), out modificadorHabilidades) || modificadorHabilidades < 0)
        {
            Console.Write("Modificador inválido. Digite novamente: ");
        }

        //calcula a vida restante
        double danoAjustado = danoRecebido * modificadorEquipamentos * modificadorHabilidades;
        double vidaRestante = vidaInicial - danoAjustado + bonusRegeneracao;

        //garante que a vida restante não seja negativa
        vidaRestante = vidaRestante < 0 ? 0 : vidaRestante;

        //exibe a vida restante
        Console.WriteLine("\nVida Restante:");
        Console.WriteLine($"Vida Inicial: {vidaInicial}");
        Console.WriteLine($"Dano Recebido: {danoRecebido}");
        Console.WriteLine($"Bônus de Regeneração: {bonusRegeneracao}");
        Console.WriteLine($"Modificador para Equipamentos: {modificadorEquipamentos}");
        Console.WriteLine($"Modificador para Habilidades: {modificadorHabilidades}");
        Console.WriteLine($"Dano Ajustado: {danoAjustado}");
        Console.WriteLine($"Vida Restante: {vidaRestante}");
    }
}
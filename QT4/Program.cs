using System;
class Program
{
    static void Main()
    {
       //incializa a variável para armazenar o total de moedas
       double totalMoedas = 0;

       //loop para coletar cinco valores de moedas
       for (int i = 1; i <= 5; i++)
       {
            //solicita o valor da moeda
            Console.Write($"Digite o valor da moeda {i}: ");
            double valorMoeda;
            
            // Verifica se a entrada é válida e solicita novamente se necessário
            while (!double.TryParse(Console.ReadLine(), out valorMoeda) || valorMoeda < 0)
            {
                Console.Write("Valor inválido. Digite novamente: ");
            }

            //adiciona o valor da moeda ao total
            totalMoedas += valorMoeda;
       } 
       
       //exibe o total das moedas coletadas
       Console.WriteLine($"\nTotal de moedas coletadas: {totalMoedas}");
    }
}
using System;
class Program
{
    static void Main()
    {
        //inicializa uma variável para armazenar o total de pontos
        int totalPontos = 0;

        //armazenar os pontos de habilidade de cada característica
        int[] pontosPorCaracteristica = new int[5];

        //nomes das características
        string[] caracteristicas = 
        {
            "Força",
            "Destreza",
            "Constituição",
            "Inteligência",
            "Sabedoria"
        };

        //loop para solicitar os pontos atribuídos a cada característica
        for (int i = 0; i < caracteristicas.Length; i++)
        {
            Console.Write($"Digite a quantidade de pontos de habilidade para {caracteristicas[i]}: ");
            int pontos;
            
            //verifica se a entrada é válida e solicita novamente se necessário
            while (!int.TryParse(Console.ReadLine(), out pontos) || pontos < 0)
            {
                Console.Write("Número inválido. Digite novamente: ");
            }

            //atribui os pontos e adiciona ao total
            pontosPorCaracteristica[i] = pontos;
            totalPontos += pontos;
        }

        //exibe o total de pontos distribuídos
        Console.WriteLine($"\nTotal de pontos distribuídos: {totalPontos}");
    }
}
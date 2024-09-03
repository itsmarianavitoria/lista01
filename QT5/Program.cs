using System;
class Program
{
    static void Main()
    {
        //solicita a velocidade do veiculo
         Console.Write("Digite a velocidade do veículo (em km/h): ");
        double velocidade;
        while (!double.TryParse(Console.ReadLine(), out velocidade) || velocidade < 0)
        {
            Console.Write("Velocidade inválida. Digite novamente: ");
        }

        //solicita o tempo de viagem
        Console.Write("Digite o tempo de viagem (em horas): ");
        double tempo;
        while (!double.TryParse(Console.ReadLine(), out tempo) || tempo < 0)
        {
            Console.Write("Tempo inválido. Digite novamente: ");
        }

        //solicita o multiplicador para condições climáticas
        Console.Write("Digite o multiplicador para condições climáticas: ");
        double multiplicadorClimatico;
        while (!double.TryParse(Console.ReadLine(), out multiplicadorClimatico) || multiplicadorClimatico < 0)
        {
            Console.Write("Multiplicador inválido. Digite novamente: ");
        }

        //solicita o multiplicador para o estado do veículo
        Console.Write("Digite o multiplicador para o estado do veículo: ");
        double multiplicadorVeiculo;
        while (!double.TryParse(Console.ReadLine(), out multiplicadorVeiculo) || multiplicadorVeiculo < 0)
        {
            Console.Write("Multiplicador inválido. Digite novamente: ");
        }

        //calcula a distância total percorrida
        double distanciaPercorrida = velocidade * tempo * multiplicadorClimatico * multiplicadorVeiculo;

        //exibe a distancia total percorrida
        Console.WriteLine($"\nDistância total percorrida: {distanciaPercorrida} km");
    }
}
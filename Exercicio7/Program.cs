//Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno

System.Console.Write("Digite a primeira nota: ");
decimal nota1 = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Digite a segunda nota: ");
decimal nota2 = Convert.ToDecimal(Console.ReadLine());

decimal peso1 = 2;
decimal peso2 = 3;

decimal mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

Console.WriteLine($"Média ponderada: {mediaPonderada}");
﻿//Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem. O
//programa deve solicitar ao usuário:

// ● A quilometragem inicial do veículo no início da viagem.
// ● A quilometragem final ao término da viagem.
// ● A quantidade de combustível consumida durante a viagem (em litros).

System.Console.Write("Digite a quilometragem inicial do veiculo: ");
decimal quilometragemInicial = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Digite a quilometragem final do veiculo: ");
decimal quilometragemFinal = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Digite a quantidade de combustivel utilizada pelo veiculo: ");
decimal combustivel = Convert.ToDecimal(Console.ReadLine());

decimal diferencaQuilometragem = quilometragemFinal - quilometragemInicial;

decimal combustivelConsumido = diferencaQuilometragem/combustivel;

System.Console.WriteLine("Foi consumido foi: " + combustivelConsumido);
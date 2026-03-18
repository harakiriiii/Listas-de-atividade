﻿// Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
// Considere sempre anos completos, e que um ano possui 365 dias. Ex: uma pessoa com 19 anos possui 6935 dias
// de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.

System.Console.Write("Digite seu nome para verificar quantos dias ja viveu: ");
string? nome = Console.ReadLine();

System.Console.Write("Digite a sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

int tempoVivido = idade * 365;

System.Console.WriteLine($"{nome} voce ja viveu {tempoVivido} dias!");
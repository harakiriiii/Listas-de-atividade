﻿//8. Crie um programa para verificar se um número é primo.

System.Console.Write("Digite um numero para verificar se e par ou impar: ");
decimal num = Convert.ToDecimal(Console.ReadLine());

if(num % 2 == 0)
{
    System.Console.WriteLine("O numero e PAR");
}
else
{
    System.Console.WriteLine("O numero e impar");
}
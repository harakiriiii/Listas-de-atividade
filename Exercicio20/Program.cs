﻿// 20. Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N. Mostre a
// tabuada na forma:

System.Console.Write("Digite um numero para ver a tabuada: ");
decimal n = Convert.ToDecimal(Console.ReadLine());

for(int i = 0; i <=10; i++)
{
    System.Console.WriteLine($"{n} X {i} = {n*i}");
}
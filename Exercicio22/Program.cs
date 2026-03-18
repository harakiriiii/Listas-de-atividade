﻿// 22. Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.

System.Console.WriteLine("Digite o primeiro numero: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Digite o primeiro numero: ");
int b = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < 10; i++)
{
    int proximo = a + b;
    Console.WriteLine(proximo);

    a = b;
    b = proximo;
}
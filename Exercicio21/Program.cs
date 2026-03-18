﻿// 20. Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N. Mostre a
// tabuada na forma:

System.Console.Write("Digite um valor para verificar a fatorial: ");
int n = Convert.ToInt32(Console.ReadLine());
int soma = 1;

for(int i = 1; i<= n; i++)
{
    soma *= i;
}
System.Console.WriteLine(soma);
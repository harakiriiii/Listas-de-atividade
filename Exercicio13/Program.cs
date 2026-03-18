﻿// Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.

System.Console.Write("Digite o primeiro valor: ");
decimal valor1 = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Digite o segundo valor: ");
decimal valor2 = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Digite o terceiro valor: ");
decimal valor3 = Convert.ToDecimal(Console.ReadLine());

System.Console.WriteLine("1 valor: " +valor1);
System.Console.WriteLine("2 valor: " +valor2);
System.Console.WriteLine("3 valor: " +valor3);

if(valor1 + valor2 > valor3)
{
    System.Console.WriteLine("A soma dos valores A e B = " + (valor1 + valor2) + " e maior que o valor C: " +valor3);
}
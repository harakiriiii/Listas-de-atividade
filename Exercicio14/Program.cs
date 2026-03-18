﻿// 14. Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.

    decimal[] valores = new decimal[3];

    System.Console.Write("Digite o primeiro valor: ");
    valores[0] = Convert.ToDecimal(Console.ReadLine());

    System.Console.Write("Digite o segundo valor: ");
    valores[1] = Convert.ToDecimal(Console.ReadLine());

    System.Console.Write("Digite o terceiro valor: ");
    valores[2] = Convert.ToDecimal(Console.ReadLine());

    for(int i = 0; i < valores.Length -1 ; i++)
    {
        for(int j =0; j < valores.Length - 1; j++)
        {
            if (valores[j] > valores[j + 1])
            {
                decimal temp = valores[j];
                valores[j] = valores[j + 1];
                valores[j + 1] = temp; //Bubble Sortzada joguei no google n quis fazer if e else kkk
            }
        }
    }
    foreach(decimal i in valores)
    {
        System.Console.WriteLine(i);
    }
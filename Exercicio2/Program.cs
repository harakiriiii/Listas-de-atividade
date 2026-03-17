﻿//1. Crie um programa para calcular o volume de uma cilindro

System.Console.Write("Digite o raio do cilindro: ");
decimal raio = Convert.ToDecimal(Console.ReadLine());


System.Console.Write("Digite o altura do cilindro: ");
decimal altura = Convert.ToDecimal(Console.ReadLine());


decimal volume = 3.14m * altura * altura * raio;

System.Console.WriteLine("O volume do cilindro e: " + volume);
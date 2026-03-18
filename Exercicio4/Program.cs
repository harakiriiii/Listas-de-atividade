﻿//4. Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

System.Console.Write("Digite a temperatura em Celsius: ");
decimal celsius = Convert.ToDecimal(Console.ReadLine());

decimal converter = ( celsius * 9/5) + 32;

System.Console.WriteLine("Conversao para Fahrenheit: " + converter);
﻿// Crie um programa para calcular a média harmônica das notas de um aluno

decimal[] notas = new decimal[4];

System.Console.Write("Digite a primeira nota do aluno: ");
notas[0] = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Digite a segunda nota do aluno: ");
notas[1] = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Digite a terceira nota do aluno: ");
notas[2] = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Digite a quarta nota do aluno: ");
notas[3] = Convert.ToDecimal(Console.ReadLine());

decimal mediaHarmonica = 4 / (1 / notas[0] + 1 / notas[1] + 1 / notas[2] + 1 / notas[3]);

System.Console.WriteLine("A media Harmonica e: " + mediaHarmonica);
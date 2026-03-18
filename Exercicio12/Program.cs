﻿// 12. Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de
// impostos. Imprima o salário inicial, o salário com o aumento e o salário final.

System.Console.Write("Digite o seu salario: ");
decimal salario = Convert.ToDecimal(Console.ReadLine());

decimal aumento = salario + (salario * 0.15m);

System.Console.WriteLine("Seu salario com o aumento e: " + aumento);

decimal imposto = aumento - (aumento * 0.08m);

System.Console.WriteLine("Com os impostos seu salario e: " + imposto);
System.Console.WriteLine("faz o L");
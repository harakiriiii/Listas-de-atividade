﻿//Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
//vendas. A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.

System.Console.Write("Informe o salario base do vendedor: ");
decimal salarioBase = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Informe a quantidade de vendas em R$: ");
decimal comissao = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Digite a porcentagem de comissao do vendedor Exemplo - 10 :");
decimal porcentagem = Convert.ToDecimal(Console.ReadLine());

decimal salarioFinal = salarioBase + (comissao * porcentagem/100);

System.Console.WriteLine("Salario base" + salarioBase + " , valor de vendas: " + comissao + " , valor final do salario: " + salarioFinal);
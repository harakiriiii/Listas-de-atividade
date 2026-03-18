﻿// A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada
// pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a venda
// dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado). Você foi
// contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as quantidades
// de pães e de broas, e depois calcular os dados solicitados.

System.Console.WriteLine("Bem-Vindo a padaria do seu Ze");
System.Console.WriteLine("------------------------------");

System.Console.Write("Insira a quantidade de Paos: ");
int qntdPao = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Insira a quantidade de Broas: ");
int qntdBroas = Convert.ToInt32(Console.ReadLine());

decimal valorPao = Convert.ToDecimal(qntdPao * 0.10);
decimal valorBroas = Convert.ToDecimal(qntdPao * 1.50);

decimal valorTotal = valorBroas + valorPao;

decimal poupanca = valorTotal * 0.10m;

System.Console.WriteLine("Valor total das vendas do dia: "+ valorTotal);
System.Console.WriteLine("Valor a ser guardado na poupanca: "+ poupanca);
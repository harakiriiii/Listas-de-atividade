﻿// 9. A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um
// terreno e depois exibir a área do terreno.

System.Console.Write("Digite a largura do terreno: ");
decimal comprimento = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Digite a largura do altura: ");
decimal altura = Convert.ToDecimal(Console.ReadLine());

decimal area = altura * comprimento;

System.Console.WriteLine("A area do Imovel: " + area);
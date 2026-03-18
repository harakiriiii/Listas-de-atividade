﻿// 15. O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre
// a condição de peso de uma pessoa adulta. A fórmula é IMC = peso / (altura) 2. Elabore um algoritmo que leia o
// peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
// ● IMC em adultos Condição
// ● Abaixo de 18,5
// ● Abaixo do peso
// ● Entre 18,5 e 25 Peso normal
// ● Entre 25 e 30
// ● Acima do peso
// ● Acima de 30 obeso

System.Console.WriteLine("Vamos ver se vc e gordo");
System.Console.WriteLine("-------------------------");
System.Console.WriteLine("Utilize virgulas!");

System.Console.Write("Digite a sua altura: ");
decimal altura = Convert.ToDecimal(Console.ReadLine());

System.Console.WriteLine("Digite seu peso: ");
decimal peso = Convert.ToDecimal(Console.ReadLine());

decimal imc = peso / (altura * altura);

if(imc < 18.5m)
{
    System.Console.WriteLine("Voce esta abaixo do peso! IMC: "+imc);
}
else if(imc > 18.5m && imc < 25m)
{
    System.Console.WriteLine("Voce esta no peso normal! IMC: "+imc);
}
else if(imc > 25m && imc < 30)
{
    System.Console.WriteLine("Voce esta acima do peso, IMC: "+imc);
}
else
{
    System.Console.WriteLine("Voce e Obeso! IMC: "+imc);
}
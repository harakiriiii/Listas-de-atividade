Console.WriteLine("-------------------");
Console.WriteLine("Altura do Retângulo");
Console.WriteLine("--------------------");

decimal Altura = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("-------------------");
Console.WriteLine("Largura do Retângulo");
Console.WriteLine("--------------------");

decimal Largura = Convert.ToDecimal(Console.ReadLine());

decimal Volume = Largura * Altura;
Console.WriteLine($"O volume do retangulo é:{Volume}");


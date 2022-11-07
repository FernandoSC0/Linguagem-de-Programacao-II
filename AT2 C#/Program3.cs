using System;

class Program
{
    static void Main(string[] args)
    {

        Fun[] garage = {
new Fun(&quot; Fernando & quot;, 11111, 2500.00),
new Fun(&quot; André & quot;, 22222, 5100.00),
new Fun(&quot; Paulo & quot;, 33333, 9800.00)
}

foreach (Fun Funcionario in garage) {
Console.WriteLine(Funcionario.name);
Console.WriteLine(Funcionario.matricula);
Console.WriteLine(Funcionario.salario);
}

Console.ReadKey();
}
}
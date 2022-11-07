class Program
{
    static void Main(string[] args)
    {
        Funcionario func1 = new Funcionario("Atari", 011, "7462842");
        Funcionario func2 = new Funcionario("Pedro", 110, "2300042");
        Departamento vendas = new Departamento("VENDAS");

        vendas.AdicionaFuncionario(func1);
        vendas.AdicionaFuncionario(func2);
        vendas.ImprimeDepartamento();
    }
}
}


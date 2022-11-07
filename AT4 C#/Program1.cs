class Program
{
    static void Main(string[] args)
    {
        Aluno a1 = new Aluno();
        a1.Nome = "Zé";
        a1.Matricula = 234;
        a1.Email = "ze@gmail.com";

        Aluno a2 = new Aluno();
        a2.Nome = "Ana";
        a2.Matricula = 789;
        a2.Email = "ana@xy.com";

        Aluno a3 = new Aluno();

        a3.Nome = "Paulo";
        a3.Matricula = 989;
        a3.Email = "paulo@ig.com";

        a1.imprimir();
        a2.imprimir();
        a3.imprimir();

        Console.ReadKey();
    }
}
}

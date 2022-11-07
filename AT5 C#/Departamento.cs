using System.Collections;

class Deparatmento
{
    private string nome_;
    ArrayList listaFuncionarios = new ArrayList();

    public Departamento(string nome)
    {
        nome_ = nome;
    }

    public string Nome
    {
        get
        {
            return nome_;
        }
        set
        {
            nome_ = value;
        }
    }

    public void AdicionaFuncionario(Funcionario f)
    {
        listaFuncionarios.Add(f);
    }

    public void ImprimeDepartamento()
    {
        Console.WriteLine("--------Funcionarios do departamento " + nome_ + "--------");
        foreach (Funcionario f in listaFuncionarios)
        {
            Console.WriteLine(f.nome + "\n");
        }
        Console.WriteLine("--------Fim do departamento--------");
    }


}

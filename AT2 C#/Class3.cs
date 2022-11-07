class Funcionario
{
    private string nome;
    private int matricula;
    public float salario;

    public Funcionario(string nome)
    {
        this.nome = nome;
    }

    public Funcionario()
    {
    }

    public Funcionario(string nome, int matricula, float salario)
    {
        this.nome = nome;
        this.matricula = matricula;
        this.salario = salario;
    }

    public string getNome()
    {
        return this.nome;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public int getMatricula()
    {
        return this.matricula;
    }

    public void setMatricula(int matricula)
    {
        this.matricula = matricula;
    }

    public float getSalario()
    {
        return this.salario;
    }

    public void setSalario(float salario)
    {
        this.salario = salario;
    }

    public void imprimir()
    {
        Console.WriteLine(this.nome + &quot; &quot; +this.matricula + &quot; &quot; +this.salario);
    }

}
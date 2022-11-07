class Aluno
{

    private String nome;
    private int matricula;
    private String email;

    public String Nome { get => nome; set => nome = value; }

    // get e set nome

    public int Matricula { get => matricula; set => matricula = value; }

    // get e set matricula


    // get e set email

    public String Email { get => email; set => email = value; }

    public void imprimir()
    {
        Console.WriteLine(this.nome + " " + this.matricula + " " + this.email);
    }
}
}

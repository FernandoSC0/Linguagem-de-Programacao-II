namespace Exercicio_141022
{
    class Funcionario
    {
        private string nome_;
        private int matricula_;
        private string cpf_;


        public Funcionario(string nome, int matricula, string cpf)
        {
            this.nome_ = nome;
            this.matricula_ = matricula;
            this.cpf_ = cpf;
        }

        public string getnome()
        {
            return this.nome_;
        }

        public string getmatricula()
        {
            return this.matricula;
        }

        public void setcpf(string cpf)
        {
            this.cpf_ = cpf;
        }

        public void imprime()
        {
            Console.WriteLine(this.nome_ + " " + this.matricula_ + " " + this.cpf_);

        }
    }
}

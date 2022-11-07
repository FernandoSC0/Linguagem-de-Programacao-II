using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp 300922
{
    class Funcionario
{
    public String nome { get; set; }
    public int MAT { get; set; }
    public int SAL { get; set; }


    public void imprimir()
    {
        Console.WriteLine(this.nome + " " + this.MAT + " " + this.SAL);
    }
}
}

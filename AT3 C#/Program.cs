using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario[] f = new Funcionario[4];
                 
            f[0]= new Funcionario();
            f[0].nome = "Fefis";
            f[0].matricula = 011;
            f[0].salario = 1500;

            f[1] = new Funcionario();
            f[1].nome = "Paulo ";
            f[1].matricula = 031;
            f[1].salario = 1700;

            f[2] = new Funcionario();
            f[2].nome = "Isabella";
            f[2].matricula = 099;
            f[2].salario = 3000;

            f[3] = new Funcionario();
            f[3].nome = "André";
            f[3]. matricula = 001;
            f[3].salario = 1000000;
    

            int SomaMedia=0;

            for(int i = 0; i<4;i++)
            {
                SomaMedia += f[i].salario;
            }
            float MEdFinal = SomaMedia / 4;

            for (int i = 0; i< 4; i++)
            {
                if (f[i].salario > MedFinal)
                {
                    f[i].imprimir();
                }
            }
            Console.ReadKey();
        }
       
    }
}

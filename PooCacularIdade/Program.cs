using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooCacularIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Programa calcula idade de uma pessoa");
            Pessoa p = new Pessoa();
            Console.Write("Nome da pessoa: ");
            p.Nome = Console.ReadLine(); 
            Console.Write("Ano de nascimento: ");
            p.AnoNacimento = int.Parse(Console.ReadLine());
            p.ExibriDados();
            Console.Clear();
        }
    }
}

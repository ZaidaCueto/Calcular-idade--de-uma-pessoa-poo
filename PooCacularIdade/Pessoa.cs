using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooCacularIdade
{
  public class Pessoa
    {
        //digitar propfull para criar estrutura  base para set get de manira mais facil
        private int anoNacimento;

		public int AnoNacimento	
		{
			get { return this.anoNacimento; }
			set { this.anoNacimento = value; }
		}

		private string nome;
   

        public string Nome
		{
			get { return nome; }
			set { nome = value.ToUpper(); }
		}

		public void ExibriDados()
		{

			Console.WriteLine();
			Console.WriteLine($"nome: {this.Nome}");
			Console.WriteLine($"Ano de nacimento: {this.AnoNacimento}");
			int idade = this.CalcularIdade();
			Console.WriteLine($"Idade: {idade} ");
		}
	private int CalcularIdade()
		{
			DateTime data = DateTime.Now;
			int ano = data.Year;
			int idade = ano - this.AnoNacimento;
            return idade;
		}
	}
}

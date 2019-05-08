using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apBiblioteca
{
	class Leitor
	{
		public Leitor(int id, string nome, string telefone, string email, string endereco)
		{
			IdLeitor = id;
			NomeLeitor = nome;
			TelefoneLeitor = telefone;
			EmailLeitor = email;
			EnderecoLeitor = endereco;
		}

		const int tamanhoNome = 50;
		const int tamanhoTelefone = 50;
		const int tamanhoEmail = 50;
		const int tamanhoEndereco = 100;

		private int idLeitor;
		private string nomeLeitor,
			telefoneLeitor,
			emailLeitor,
			enderecoLeitor;

		public int IdLeitor
		{
			get => idLeitor;
			set
			{
				if (value < 0)
					throw new Exception("ID negativo é inválido");
				idLeitor = value;
			}
		}
		public string NomeLeitor
		{
			get => nomeLeitor;
			set => nomeLeitor = value.Remove(tamanhoNome).PadRight(tamanhoNome, ' ');
		}
		public string TelefoneLeitor
		{
			get => telefoneLeitor;
			set => telefoneLeitor = value.Remove(tamanhoTelefone).PadRight(tamanhoTelefone, ' ');
		}
		public string EmailLeitor
		{
			get => emailLeitor;
			set => emailLeitor = value.Remove(tamanhoEmail).PadRight(tamanhoEmail, ' ');
		}
		public string EnderecoLeitor
		{
			get => enderecoLeitor;
			set => enderecoLeitor = value.Remove(tamanhoEndereco).PadRight(tamanhoEndereco, ' ');
		}
	}
}

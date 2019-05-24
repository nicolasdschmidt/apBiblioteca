using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apBiblioteca
{
	class Livro
	{
		public Livro(int id, string codigo, string titulo, string autor)
		{
			IdLivro = id;
			CodigoLivro = codigo;
			Titulolivro = titulo;
			AutorLivro = autor;
		}

		const int tamanhoCodigo = 6;
		const int tamanhoTitulo = 50;
		const int tamanhoAutor = 50;

		private int idLivro;
		private string codigoLivro,
			titulolivro,
			autorLivro;

		public int IdLivro
		{
			get => idLivro;
			set
			{
				if(value < 0)
					throw new Exception("ID negativo é inválido");
				idLivro = value;
			}
		}

		public string CodigoLivro
		{
			get => codigoLivro;
			set => codigoLivro = value./*Remove(tamanhoCodigo).*/PadLeft(tamanhoCodigo, '0');
		}

		public string Titulolivro
		{
			get => titulolivro;
			set => titulolivro = value./*Remove(tamanhoTitulo).*/PadRight(tamanhoTitulo, ' ');
		}

		public string AutorLivro
		{
			get => autorLivro;
			set => autorLivro = value./*Remove(tamanhoAutor).*/PadRight(tamanhoAutor, ' ');
		}
	}
}

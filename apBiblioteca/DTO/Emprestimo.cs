using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apBiblioteca
{
	class Emprestimo
	{
		private int idEmprestimo;
		private DateTime dataEmprestimo,
			dataDevolucaoPrevista,
			dataDevolucaoReal;

		public int IdEmprestimo { get => idEmprestimo; set { if (value < 0) { throw new Exception("ID negativo é inválido"); } idEmprestimo = value; } }
		public DateTime DataEmprestimo { get => dataEmprestimo; set => dataEmprestimo = value; }
		public DateTime DataDevolucaoPrevista { get => dataDevolucaoPrevista; set => dataDevolucaoPrevista = value; }
		public DateTime DataDevolucaoReal { get => dataDevolucaoReal; set => dataDevolucaoReal = value; }
	}
}

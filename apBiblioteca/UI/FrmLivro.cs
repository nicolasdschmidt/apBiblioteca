using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using apBiblioteca.BLL;

namespace apBiblioteca.UI
{
	public partial class FrmLivro : Form
	{
		public FrmLivro()
		{
			InitializeComponent();
		}

		private void btnExibir_Click(object sender, EventArgs e)
		{
			try
			{
				var livroBLL = new LivroBLL();
				dgvLivro.DataSource = livroBLL.SelecionarLivros();
				tbcLivros.SelectedTab = tpLista;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private void btnNovo_Click(object sender, EventArgs e)
		{
			var livro = new Livro(0, "", "", "");
			livro.CodigoLivro = txtCodigoLivro.Text;
			livro.Titulolivro = txtTituloLivro.Text;
			livro.AutorLivro = txtAutorLivro.Text;

			try
			{
				var livroBLL = new LivroBLL();
				livroBLL.IncluirLivro(livro);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro: " + ex.Message);
			}
		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			var livro = new Livro(int.Parse(txtIdLivro.Text), txtCodigoLivro.Text, txtTituloLivro.Text, txtAutorLivro.Text);

			try
			{
				var livroBLL = new LivroBLL();
				livroBLL.AlterarLivro(livro);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro: " + ex.Message);

			}
		}
	}
}

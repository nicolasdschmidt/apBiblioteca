using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apBiblioteca.UI
{
	public partial class FrmPrincipal : Form
	{
		FrmLivro frmLivro = new FrmLivro();
		public FrmPrincipal()
		{
			InitializeComponent();
		}

		private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (frmLivro == null)
				frmLivro = new FrmLivro();
			frmLivro.Show();
		}
	}
}

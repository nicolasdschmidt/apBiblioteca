namespace apBiblioteca.UI
{
	partial class FrmLivro
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tbcLivros = new System.Windows.Forms.TabControl();
			this.tpCadastro = new System.Windows.Forms.TabPage();
			this.btnExibir = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnNovo = new System.Windows.Forms.Button();
			this.btnProcurar = new System.Windows.Forms.Button();
			this.txtAutorLivro = new System.Windows.Forms.TextBox();
			this.txtTituloLivro = new System.Windows.Forms.TextBox();
			this.txtCodigoLivro = new System.Windows.Forms.TextBox();
			this.txtIdLivro = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tpLista = new System.Windows.Forms.TabPage();
			this.dgvLivro = new System.Windows.Forms.DataGridView();
			this.idLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.codigoLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.titulolivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.autorLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.livroBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tbcLivros.SuspendLayout();
			this.tpCadastro.SuspendLayout();
			this.tpLista.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tbcLivros
			// 
			this.tbcLivros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbcLivros.Controls.Add(this.tpCadastro);
			this.tbcLivros.Controls.Add(this.tpLista);
			this.tbcLivros.Location = new System.Drawing.Point(12, 12);
			this.tbcLivros.Name = "tbcLivros";
			this.tbcLivros.SelectedIndex = 0;
			this.tbcLivros.Size = new System.Drawing.Size(693, 260);
			this.tbcLivros.TabIndex = 0;
			// 
			// tpCadastro
			// 
			this.tpCadastro.Controls.Add(this.btnExibir);
			this.tpCadastro.Controls.Add(this.btnExcluir);
			this.tpCadastro.Controls.Add(this.btnAlterar);
			this.tpCadastro.Controls.Add(this.btnNovo);
			this.tpCadastro.Controls.Add(this.btnProcurar);
			this.tpCadastro.Controls.Add(this.txtAutorLivro);
			this.tpCadastro.Controls.Add(this.txtTituloLivro);
			this.tpCadastro.Controls.Add(this.txtCodigoLivro);
			this.tpCadastro.Controls.Add(this.txtIdLivro);
			this.tpCadastro.Controls.Add(this.label4);
			this.tpCadastro.Controls.Add(this.label3);
			this.tpCadastro.Controls.Add(this.label2);
			this.tpCadastro.Controls.Add(this.label1);
			this.tpCadastro.Location = new System.Drawing.Point(4, 22);
			this.tpCadastro.Name = "tpCadastro";
			this.tpCadastro.Padding = new System.Windows.Forms.Padding(3);
			this.tpCadastro.Size = new System.Drawing.Size(685, 234);
			this.tpCadastro.TabIndex = 0;
			this.tpCadastro.Text = "Cadastro";
			this.tpCadastro.UseVisualStyleBackColor = true;
			// 
			// btnExibir
			// 
			this.btnExibir.Location = new System.Drawing.Point(530, 192);
			this.btnExibir.Name = "btnExibir";
			this.btnExibir.Size = new System.Drawing.Size(75, 23);
			this.btnExibir.TabIndex = 12;
			this.btnExibir.Text = "Exibir";
			this.btnExibir.UseVisualStyleBackColor = true;
			this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(380, 192);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 23);
			this.btnExcluir.TabIndex = 11;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(230, 192);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(75, 23);
			this.btnAlterar.TabIndex = 10;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = true;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
			// 
			// btnNovo
			// 
			this.btnNovo.Location = new System.Drawing.Point(80, 192);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(75, 23);
			this.btnNovo.TabIndex = 9;
			this.btnNovo.Text = "Novo";
			this.btnNovo.UseVisualStyleBackColor = true;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// btnProcurar
			// 
			this.btnProcurar.Location = new System.Drawing.Point(569, 6);
			this.btnProcurar.Name = "btnProcurar";
			this.btnProcurar.Size = new System.Drawing.Size(98, 38);
			this.btnProcurar.TabIndex = 8;
			this.btnProcurar.Text = "Procurar";
			this.btnProcurar.UseVisualStyleBackColor = true;
			// 
			// txtAutorLivro
			// 
			this.txtAutorLivro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAutorLivro.Location = new System.Drawing.Point(80, 158);
			this.txtAutorLivro.MaxLength = 50;
			this.txtAutorLivro.Name = "txtAutorLivro";
			this.txtAutorLivro.Size = new System.Drawing.Size(599, 20);
			this.txtAutorLivro.TabIndex = 7;
			// 
			// txtTituloLivro
			// 
			this.txtTituloLivro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTituloLivro.Location = new System.Drawing.Point(80, 122);
			this.txtTituloLivro.MaxLength = 50;
			this.txtTituloLivro.Name = "txtTituloLivro";
			this.txtTituloLivro.Size = new System.Drawing.Size(599, 20);
			this.txtTituloLivro.TabIndex = 6;
			// 
			// txtCodigoLivro
			// 
			this.txtCodigoLivro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCodigoLivro.Location = new System.Drawing.Point(80, 86);
			this.txtCodigoLivro.MaxLength = 6;
			this.txtCodigoLivro.Name = "txtCodigoLivro";
			this.txtCodigoLivro.Size = new System.Drawing.Size(599, 20);
			this.txtCodigoLivro.TabIndex = 5;
			// 
			// txtIdLivro
			// 
			this.txtIdLivro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtIdLivro.Location = new System.Drawing.Point(80, 50);
			this.txtIdLivro.MaxLength = 6;
			this.txtIdLivro.Name = "txtIdLivro";
			this.txtIdLivro.Size = new System.Drawing.Size(599, 20);
			this.txtIdLivro.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(42, 161);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Autor";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Título";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Código";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Identificação";
			// 
			// tpLista
			// 
			this.tpLista.Controls.Add(this.dgvLivro);
			this.tpLista.Location = new System.Drawing.Point(4, 22);
			this.tpLista.Name = "tpLista";
			this.tpLista.Padding = new System.Windows.Forms.Padding(3);
			this.tpLista.Size = new System.Drawing.Size(685, 234);
			this.tpLista.TabIndex = 1;
			this.tpLista.Text = "Lista";
			this.tpLista.UseVisualStyleBackColor = true;
			// 
			// dgvLivro
			// 
			this.dgvLivro.AutoGenerateColumns = false;
			this.dgvLivro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLivroDataGridViewTextBoxColumn,
            this.codigoLivroDataGridViewTextBoxColumn,
            this.titulolivroDataGridViewTextBoxColumn,
            this.autorLivroDataGridViewTextBoxColumn});
			this.dgvLivro.DataSource = this.livroBindingSource;
			this.dgvLivro.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvLivro.Location = new System.Drawing.Point(3, 3);
			this.dgvLivro.Name = "dgvLivro";
			this.dgvLivro.Size = new System.Drawing.Size(679, 228);
			this.dgvLivro.TabIndex = 0;
			// 
			// idLivroDataGridViewTextBoxColumn
			// 
			this.idLivroDataGridViewTextBoxColumn.DataPropertyName = "IdLivro";
			this.idLivroDataGridViewTextBoxColumn.HeaderText = "Identificação";
			this.idLivroDataGridViewTextBoxColumn.Name = "idLivroDataGridViewTextBoxColumn";
			// 
			// codigoLivroDataGridViewTextBoxColumn
			// 
			this.codigoLivroDataGridViewTextBoxColumn.DataPropertyName = "CodigoLivro";
			this.codigoLivroDataGridViewTextBoxColumn.HeaderText = "Código";
			this.codigoLivroDataGridViewTextBoxColumn.Name = "codigoLivroDataGridViewTextBoxColumn";
			// 
			// titulolivroDataGridViewTextBoxColumn
			// 
			this.titulolivroDataGridViewTextBoxColumn.DataPropertyName = "Titulolivro";
			this.titulolivroDataGridViewTextBoxColumn.HeaderText = "Título";
			this.titulolivroDataGridViewTextBoxColumn.Name = "titulolivroDataGridViewTextBoxColumn";
			// 
			// autorLivroDataGridViewTextBoxColumn
			// 
			this.autorLivroDataGridViewTextBoxColumn.DataPropertyName = "AutorLivro";
			this.autorLivroDataGridViewTextBoxColumn.HeaderText = "Autor";
			this.autorLivroDataGridViewTextBoxColumn.Name = "autorLivroDataGridViewTextBoxColumn";
			// 
			// livroBindingSource
			// 
			this.livroBindingSource.DataSource = typeof(apBiblioteca.Livro);
			// 
			// FrmLivro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(717, 284);
			this.Controls.Add(this.tbcLivros);
			this.Name = "FrmLivro";
			this.Text = "Manutenção de Livros";
			this.tbcLivros.ResumeLayout(false);
			this.tpCadastro.ResumeLayout(false);
			this.tpCadastro.PerformLayout();
			this.tpLista.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tbcLivros;
		private System.Windows.Forms.TabPage tpCadastro;
		private System.Windows.Forms.TabPage tpLista;
		private System.Windows.Forms.DataGridView dgvLivro;
		private System.Windows.Forms.TextBox txtAutorLivro;
		private System.Windows.Forms.TextBox txtTituloLivro;
		private System.Windows.Forms.TextBox txtCodigoLivro;
		private System.Windows.Forms.TextBox txtIdLivro;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnExibir;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button btnProcurar;
		private System.Windows.Forms.BindingSource livroBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idLivroDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn codigoLivroDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn titulolivroDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn autorLivroDataGridViewTextBoxColumn;
	}
}
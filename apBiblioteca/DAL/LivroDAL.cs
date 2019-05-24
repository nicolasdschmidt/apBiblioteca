using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace apBiblioteca.DAL
{
	class LivroDAL
	{
		private string _conexaoSQLServer = "";
		SqlConnection conexao = null;

		public LivroDAL()
		{
			_conexaoSQLServer = $"Data Source=Regulus;Initial Catalog=BD19191;User ID=BD19191;Password={DALSecurity.Pass}";
		}

		public List<Livro> SelectListLivros()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(_conexaoSQLServer))
				{
					using (SqlCommand command = new SqlCommand("select * from BibLivro", conn))
					{
						conn.Open();
						var listaLivros = new List<Livro>();
						using (SqlDataReader dr = command.ExecuteReader())
						{
							while(dr.Read())
							{
								var livro = new Livro(Convert.ToInt32(dr["idLivro"]), dr["codigoLivro"].ToString(), dr["tituloLivro"].ToString(), dr["autorLivro"].ToString());
								listaLivros.Add(livro);
							}
						}
						conn.Close();
						return listaLivros;
					}
				}
			}
			catch (Exception e)
			{
				throw e;
			}
			finally
			{
			}
		}

		public DataTable SelectLivros()
		{
			try
			{
				string sql = "select * from BibLivro";
				conexao = new SqlConnection(_conexaoSQLServer);
				var cmd = new SqlCommand(sql, conexao);
				var da = new SqlDataAdapter();
				da.SelectCommand = cmd;
				var dt = new DataTable();
				da.Fill(dt);

				return dt;
			}
			catch (Exception e)
			{
				throw e;
			}
			finally
			{
				conexao.Close();
			}
		}

		public Livro SelectByID(int id)
		{
			try
			{
				string sql = $"select * from BibLivro where idLivro = @id";
				conexao = new SqlConnection(_conexaoSQLServer);
				var cmd = new SqlCommand(sql, conexao);
				cmd.Parameters.AddWithValue("@id", id);
				conexao.Open();
				SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
				Livro livro = null;
				if (dr.Read())
				{
					livro = new Livro(Convert.ToInt32(dr["idLivro"]), dr["codigoLivro"].ToString(), dr["tituloLivro"].ToString(), dr["autorLivro"].ToString());
				}
				return livro;
			}
			catch (Exception e)
			{
				throw e;
			}
			finally
			{
				conexao.Close();
			}
		}

		public Livro SelectLivroByCodigo(string codigo)
		{
			try
			{
				string sql = $"select * from BibLivro where codigoLivro = @codigo";
				conexao = new SqlConnection(_conexaoSQLServer);
				var cmd = new SqlCommand(sql, conexao);
				cmd.Parameters.AddWithValue("@codigo", codigo);
				conexao.Open();
				SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
				Livro livro = null;
				if (dr.Read())
				{
					livro = new Livro(Convert.ToInt32(dr["idLivro"]), dr["codigoLivro"].ToString(), dr["tituloLivro"].ToString(), dr["autorLivro"].ToString());
				}
				return livro;
			}
			catch (Exception e)
			{
				throw e;
			}
			finally
			{
				conexao.Close();
			}
		}

		public void InsertLivro(Livro livro)
		{
			try
			{
				string sql = "insert into BibLivro values(@codigo, @titulo, @autor)";
				conexao = new SqlConnection(_conexaoSQLServer);
				var cmd = new SqlCommand(sql, conexao);
				cmd.Parameters.AddWithValue("@codigo", livro.CodigoLivro);
				cmd.Parameters.AddWithValue("@titulo", livro.Titulolivro);
				cmd.Parameters.AddWithValue("@autor", livro.AutorLivro);
				conexao.Open();
				cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				throw e;
			}
			finally
			{
				conexao.Close();
			}
		}

		public void UpdateLivro(Livro livro)
		{
			try
			{
				string sql = "update BibLivro set codigoLivro = @codigo, tituloLivro = @titulo, autorLivro = @autor where idLivro = @id";
				conexao = new SqlConnection(_conexaoSQLServer);
				var cmd = new SqlCommand(sql, conexao);
				cmd.Parameters.AddWithValue("@id", livro.IdLivro);
				cmd.Parameters.AddWithValue("@codigo", livro.CodigoLivro);
				cmd.Parameters.AddWithValue("@titulo", livro.Titulolivro);
				cmd.Parameters.AddWithValue("@autor", livro.AutorLivro);
				conexao.Open();
				cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				throw e;
			}
			finally
			{
				conexao.Close();
			}
		}

		public void DeleteLivro(Livro livro)
		{
			try
			{
				string sql = "delete from BibLivro where idLivro = @id";
				conexao = new SqlConnection(_conexaoSQLServer);
				var cmd = new SqlCommand(sql, conexao);
				cmd.Parameters.AddWithValue("@id", livro.IdLivro);
				conexao.Open();
				cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				throw e;
			}
			finally
			{
				conexao.Close();
			}
		}
	}
}

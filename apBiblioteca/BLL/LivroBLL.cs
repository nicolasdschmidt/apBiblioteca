using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace apBiblioteca.BLL
{
	class LivroBLL
	{
		DAL.LivroDAL dal;
		public LivroBLL()
		{

		}

		public List<Livro> ListarLivros()
		{
			try
			{
				dal = new DAL.LivroDAL();
				return dal.SelectListLivros();
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public DataTable SelecionarLivros()
		{
			var dt = new DataTable();
			try
			{
				dal = new DAL.LivroDAL();
				dt = dal.SelectLivros();
				return dt;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public Livro SelecionarLivroPorId(int id)
		{
			try
			{
				dal = new DAL.LivroDAL();
				return dal.SelectByID(id);
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public Livro SelecionarLivroPorCodigo(string codigo)
		{
			try
			{
				dal = new DAL.LivroDAL();
				return dal.SelectLivroByCodigo(codigo);
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public void IncluirLivro(Livro livro)
		{
			try
			{
				dal = new DAL.LivroDAL();
				dal.InsertLivro(livro);
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public void AlterarLivro(Livro livro)
		{
			try
			{
				dal = new DAL.LivroDAL();
				dal.UpdateLivro(livro);
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public void ExcluirLivro(Livro livro)
		{
			try
			{
				dal = new DAL.LivroDAL();
				dal.DeleteLivro(livro);
			}
			catch (Exception e)
			{
				throw e;
			}
		}
	}
}

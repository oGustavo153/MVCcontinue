using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Controller
{
    internal class LivroController : DefaultController
    {
        private static void Validar(Livro livro)
        {
            if (livro.Titulo.Trim() == "")
                throw new Exception("Título vazio");

            if (livro.DataPublicacao > DateTime.Today)
                throw new Exception("Data inválida");

            if (livro.Titulo.Length > 80)
                throw new Exception("Título muito grande");
        }

        internal static void Inserir(Livro livro)
        {
            Validar(livro);
            
            dataContext.Add(livro);
            dataContext.SaveChanges();
        }

        internal static List<Livro> Listar()
        {
            return dataContext.TBLivro.OrderBy(x => x.Titulo).ThenBy(x => x.DataPublicacao).ToList();
        }

        internal static List<Livro> Pesquisar(Livro livro)
        {
            if(livro.DataPublicacao == null)
                return dataContext.TBLivro.Where(x => x.Titulo.Contains(livro.Titulo)).ToList();
            else
                return dataContext.TBLivro.Where(x => x.Titulo.Contains(livro.Titulo) && x.DataPublicacao == livro.DataPublicacao).ToList();

            //var x =
            //    from l in dataContext.TBLivro
            //    where l.Titulo.Contains(livro.Titulo)
            //    select l;

            //return x.ToList();
        }

        internal static void Excluir(Livro livro)
        {
            //Livro remover = dataContext.TBLivro.FirstOrDefault(x => x.Id == livro.Id);

            if (livro != null)
            {
                dataContext.TBLivro.Remove(livro);
                dataContext.SaveChanges();
            }
            else
                throw new Exception();
        }

        internal static void Atualizar(Livro livro)
        {
            Validar(livro);

            dataContext.TBLivro.Update(livro);
            dataContext.SaveChanges();
        }
    }


}

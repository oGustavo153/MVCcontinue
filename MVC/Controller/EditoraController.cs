using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Controller
{
    internal class EditoraController : DefaultController
    {
        public static void Inserir(Editora editora)
        {
            if (editora.Nome == null)
                throw new Exception("Campo vazio");
            if (editora.Cidade == null)
                throw new Exception("Campo vazio");
            if (editora.AnoFundacao.Value == null)
                throw new Exception("Campo vazio");
        }
    }
}

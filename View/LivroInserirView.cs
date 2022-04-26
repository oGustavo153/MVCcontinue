using MVC.Controller;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC.View
{
    public partial class LivroInserirView : Form
    {
        Livro livroAtual;

        public LivroInserirView(Livro livro = null)
        {
            InitializeComponent();
            livroAtual = livro;

            if(livroAtual != null)
            {
                txtTitulo.Text = livroAtual.Titulo;
                txtData.Value = livroAtual.DataPublicacao.Value;
                Text = "Atualizar livro";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool erro = false;

            if (txtTitulo.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTitulo, "Campo obrigatório");
                erro = true;
            }

            if(txtTitulo.TextLength > 80)
            {
                errorProvider1.SetError(txtTitulo, "Título muito grande");
                erro = true;
            }

            if (txtData.Value.Date > DateTime.Today)
            {
                errorProvider1.SetError(txtData, "Data inválida");
                erro = true;
            }

            if(!erro)
            {
                Livro livro = new Livro();

                if (livroAtual == null)
                {
                    livro.Titulo = txtTitulo.Text.Trim();
                    livro.DataPublicacao = txtData.Value.Date;
                }
                else
                {
                    livroAtual.Titulo = txtTitulo.Text.Trim();
                    livroAtual.DataPublicacao = txtData.Value.Date;
                }

                bool sucesso = false;
                try
                {
                    if (livroAtual == null)
                        LivroController.Inserir(livro);
                    else
                        LivroController.Atualizar(livroAtual);

                    sucesso = true;
                }
                catch { }

                if(sucesso)
                {
                    string msg = "Livro salvo com sucesso!";
                    if (livroAtual != null)
                        msg = msg.Replace("salvo", "atualizado");

                    MessageBox.Show(msg, "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    string msg = "Falha na inserção!";

                    if (livroAtual != null)
                        msg = msg.Replace("inserção", "atualização");

                    MessageBox.Show(msg,
                        "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

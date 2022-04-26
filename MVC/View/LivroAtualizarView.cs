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
    public partial class LivroAtualizarView : Form
    {
        private Livro livroAtual;
        public LivroAtualizarView(Livro livro)
        {
            InitializeComponent();

            livroAtual = livro;
            txtTitulo.Text = livro.Titulo;
            txtData.Value = livro.DataPublicacao.Value;
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

            if (txtTitulo.TextLength > 80)
            {
                errorProvider1.SetError(txtTitulo, "Título muito grande");
                erro = true;
            }

            if (txtData.Value.Date > DateTime.Today)
            {
                errorProvider1.SetError(txtData, "Data inválida");
                erro = true;
            }

            if (!erro)
            {
                livroAtual.Titulo = txtTitulo.Text.Trim();
                livroAtual.DataPublicacao = txtData.Value.Date;

                bool sucesso = false;
                try
                {
                    LivroController.Atualizar(livroAtual);
                    sucesso = true;
                }
                catch { }

                if (sucesso)
                {
                    MessageBox.Show("Livro salvo com sucesso!", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Falha na inserção!",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

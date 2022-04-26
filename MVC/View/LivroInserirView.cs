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
                livro.Titulo = txtTitulo.Text.Trim();
                livro.DataPublicacao = txtData.Value.Date;

                bool sucesso = false;
                try
                {
                    LivroController.Inserir(livro);
                    sucesso = true;
                }
                catch { }

                if(sucesso)
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

        private void txtData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

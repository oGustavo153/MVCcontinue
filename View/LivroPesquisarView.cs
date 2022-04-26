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
    public partial class LivroPesquisarView : Form
    {
        Livro ultimaPesquisa = null;

        public LivroPesquisarView()
        {
            InitializeComponent();
        }

        private void LivroPesquisarView_Load(object sender, EventArgs e)
        {
            ultimaPesquisa = new Livro() { Id = null, Titulo = "", DataPublicacao = null };
            dataGridView1.DataSource = LivroController.Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            livro.Titulo = textBox1.Text.Trim();

            if (dateTimePicker1.Checked)
                livro.DataPublicacao = dateTimePicker1.Value.Date;

            List<Livro> livros = LivroController.Pesquisar(livro);
            dataGridView1.DataSource = livros;

            ultimaPesquisa = livro;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            DialogResult dr = MessageBox.Show("Você realmente deseja excluir o livro selecionado?",
                            "", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                //Livro livro = new Livro();
                //livro.Id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                //LivroController.Excluir(livro);

                Livro livro = (Livro)dataGridView1.SelectedRows[0].DataBoundItem;

                bool sucesso = false;
                try
                {
                    LivroController.Excluir(livro);
                    sucesso = true;
                }
                catch { }

                if (sucesso)
                {
                    MessageBox.Show("Livro excluído com sucesso!", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGridView1.DataSource = LivroController.Pesquisar(ultimaPesquisa);
                }
                else
                {
                    MessageBox.Show("Falha na exclusão!",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            Livro livro = (Livro)dataGridView1.SelectedRows[0].DataBoundItem;
            LivroAtualizarView form = new LivroAtualizarView(livro);

            form.ShowDialog();

            dataGridView1.DataSource = LivroController.Pesquisar(ultimaPesquisa);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            Livro livro = (Livro)dataGridView1.SelectedRows[0].DataBoundItem;
            LivroInserirView form = new LivroInserirView(livro);

            form.ShowDialog();

            dataGridView1.DataSource = LivroController.Pesquisar(ultimaPesquisa);
        }

        private void novaToolStripButton_Click(object sender, EventArgs e)
        {
            new LivroInserirView().ShowDialog();

            dataGridView1.DataSource = LivroController.Pesquisar(ultimaPesquisa);
        }
    }
}

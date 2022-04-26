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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LivroInserirView form = new LivroInserirView();
            form.ShowDialog();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LivroPesquisarView().ShowDialog();
        }
    }
}

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
    public partial class EditoraInserirView : Form
    {
        public EditoraInserirView()
        {
            InitializeComponent();
            dtpAno.Format = DateTimePickerFormat.Custom;
            dtpAno.CustomFormat = "yyyy";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtNome.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNome, "Campo Obrigatório!");
            }

            if (txtCidade.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCidade, "Campo Obrigatório!");
            }

            if (mtxtCNPJ.Text == "")
            {
                errorProvider1.SetError(mtxtCNPJ, "Campo Obrigatório!");
            }

            if (dtpAno.Value.Date > DateTime.Today)
            {
                errorProvider1.SetError(dtpAno, "Data Inválida!");
            }

        }
    }
}

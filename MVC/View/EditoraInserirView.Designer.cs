namespace MVC.View
{
    partial class EditoraInserirView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.dtpAno = new System.Windows.Forms.DateTimePicker();
            this.mtxtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(14, 43);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(395, 34);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "CNPJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cidade da Sede";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ano de Fundação";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(14, 191);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(395, 34);
            this.txtCidade.TabIndex = 2;
            // 
            // dtpAno
            // 
            this.dtpAno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAno.Location = new System.Drawing.Point(14, 265);
            this.dtpAno.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dtpAno.Name = "dtpAno";
            this.dtpAno.Size = new System.Drawing.Size(148, 34);
            this.dtpAno.TabIndex = 3;
            // 
            // mtxtCNPJ
            // 
            this.mtxtCNPJ.Location = new System.Drawing.Point(14, 117);
            this.mtxtCNPJ.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mtxtCNPJ.Mask = "00,000,000/0000-00";
            this.mtxtCNPJ.Name = "mtxtCNPJ";
            this.mtxtCNPJ.Size = new System.Drawing.Size(395, 34);
            this.mtxtCNPJ.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(304, 309);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(105, 36);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // EditoraInserirView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 357);
            this.Controls.Add(this.mtxtCNPJ);
            this.Controls.Add(this.dtpAno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSalvar);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "EditoraInserirView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditoraInserir";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCidade;
        private DateTimePicker dtpAno;
        private MaskedTextBox mtxtCNPJ;
        private Button btnSalvar;
        private ErrorProvider errorProvider1;
    }
}
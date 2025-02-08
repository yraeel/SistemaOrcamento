namespace SistemaOrcamento.View
{
    partial class frmClientes
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
            dg = new DataGridView();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();
            txtBuscar = new TextBox();
            label5 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            txtTelefone = new MaskedTextBox();
            txtCodigo = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dg).BeginInit();
            SuspendLayout();
            // 
            // dg
            // 
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg.Location = new Point(73, 166);
            dg.Name = "dg";
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.Size = new Size(526, 205);
            dg.TabIndex = 29;
            dg.CellClick += dg_CellClick_1;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(468, 404);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 28;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(355, 404);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 27;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(248, 404);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 26;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(142, 404);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 25;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(140, 30);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(131, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 30);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 23;
            label5.Text = "Buscar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 116);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 17;
            label2.Text = "Telefone:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(140, 113);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(131, 23);
            txtNome.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 113);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 15;
            label1.Text = "Nome:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(414, 113);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(129, 23);
            txtTelefone.TabIndex = 3;
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(140, 71);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(61, 23);
            txtCodigo.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 71);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 31;
            label3.Text = "Código:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(412, 71);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(131, 23);
            txtEmail.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(345, 71);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 33;
            label4.Text = "E-mail:";
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 450);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtCodigo);
            Controls.Add(label3);
            Controls.Add(txtTelefone);
            Controls.Add(dg);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(txtBuscar);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "frmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario de Clientes";
            ((System.ComponentModel.ISupportInitialize)dg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dg;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnNovo;
        private TextBox txtBuscar;
        private Label label5;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private MaskedTextBox txtTelefone;
        private TextBox txtCodigo;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
    }
}
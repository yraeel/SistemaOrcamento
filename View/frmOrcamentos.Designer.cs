namespace SistemaOrcamento.View
{
    partial class frmOrcamentos
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
            cbCliente = new TextBox();
            label4 = new Label();
            txtQuantidade = new TextBox();
            label3 = new Label();
            cbProduto = new TextBox();
            label2 = new Label();
            txtOrcamento = new TextBox();
            label1 = new Label();
            txtCodigo = new TextBox();
            lbTotal = new Label();
            txtValor = new TextBox();
            label6 = new Label();
            label7 = new Label();
            rbCliente = new RadioButton();
            rbOrcamento = new RadioButton();
            rbData = new RadioButton();
            cbBuscarCliente = new ComboBox();
            dtBuscar = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dg).BeginInit();
            SuspendLayout();
            // 
            // dg
            // 
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg.Location = new Point(40, 238);
            dg.Name = "dg";
            dg.Size = new Size(605, 200);
            dg.TabIndex = 29;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(473, 489);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 28;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(360, 489);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 27;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(253, 489);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 26;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(147, 489);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 25;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(505, 25);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(131, 23);
            txtBuscar.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(438, 25);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 23;
            label5.Text = "Buscar:";
            // 
            // cbCliente
            // 
            cbCliente.Location = new Point(505, 136);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(131, 23);
            cbCliente.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(438, 136);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 21;
            label4.Text = "Cliente:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(505, 88);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(131, 23);
            txtQuantidade.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(427, 91);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 19;
            label3.Text = "Quantidade:";
            // 
            // cbProduto
            // 
            cbProduto.Location = new Point(133, 133);
            cbProduto.Name = "cbProduto";
            cbProduto.Size = new Size(131, 23);
            cbProduto.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 136);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 17;
            label2.Text = "Produto:";
            // 
            // txtOrcamento
            // 
            txtOrcamento.Location = new Point(133, 88);
            txtOrcamento.Name = "txtOrcamento";
            txtOrcamento.Size = new Size(131, 23);
            txtOrcamento.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 91);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 15;
            label1.Text = "Nº Orçamento:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(304, 178);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(51, 23);
            txtCodigo.TabIndex = 30;
            txtCodigo.Visible = false;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(609, 450);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(33, 15);
            lbTotal.TabIndex = 31;
            lbTotal.Text = "Total";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(145, 175);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(119, 23);
            txtValor.TabIndex = 33;
            txtValor.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 178);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 32;
            label6.Text = "Valor do Produto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 25);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 34;
            label7.Text = "Buscar Por:";
            // 
            // rbCliente
            // 
            rbCliente.AutoSize = true;
            rbCliente.Location = new Point(146, 25);
            rbCliente.Name = "rbCliente";
            rbCliente.Size = new Size(62, 19);
            rbCliente.TabIndex = 36;
            rbCliente.TabStop = true;
            rbCliente.Text = "Cliente";
            rbCliente.UseVisualStyleBackColor = true;
            rbCliente.CheckedChanged += rbCliente_CheckedChanged;
            // 
            // rbOrcamento
            // 
            rbOrcamento.AutoSize = true;
            rbOrcamento.Location = new Point(215, 25);
            rbOrcamento.Name = "rbOrcamento";
            rbOrcamento.Size = new Size(115, 19);
            rbOrcamento.TabIndex = 37;
            rbOrcamento.TabStop = true;
            rbOrcamento.Text = "Núm Orçamento";
            rbOrcamento.UseVisualStyleBackColor = true;
            rbOrcamento.CheckedChanged += rbOrcamento_CheckedChanged;
            // 
            // rbData
            // 
            rbData.AutoSize = true;
            rbData.Location = new Point(341, 25);
            rbData.Name = "rbData";
            rbData.Size = new Size(49, 19);
            rbData.TabIndex = 38;
            rbData.TabStop = true;
            rbData.Text = "Data";
            rbData.UseVisualStyleBackColor = true;
            rbData.CheckedChanged += rbData_CheckedChanged;
            // 
            // cbBuscarCliente
            // 
            cbBuscarCliente.FormattingEnabled = true;
            cbBuscarCliente.Location = new Point(505, 24);
            cbBuscarCliente.Name = "cbBuscarCliente";
            cbBuscarCliente.Size = new Size(131, 23);
            cbBuscarCliente.TabIndex = 39;
            // 
            // dtBuscar
            // 
            dtBuscar.Format = DateTimePickerFormat.Short;
            dtBuscar.Location = new Point(505, 24);
            dtBuscar.Name = "dtBuscar";
            dtBuscar.Size = new Size(131, 23);
            dtBuscar.TabIndex = 40;
            // 
            // frmOrcamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 552);
            Controls.Add(dtBuscar);
            Controls.Add(cbBuscarCliente);
            Controls.Add(rbData);
            Controls.Add(rbOrcamento);
            Controls.Add(rbCliente);
            Controls.Add(label7);
            Controls.Add(txtValor);
            Controls.Add(label6);
            Controls.Add(lbTotal);
            Controls.Add(txtCodigo);
            Controls.Add(dg);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(txtBuscar);
            Controls.Add(label5);
            Controls.Add(cbCliente);
            Controls.Add(label4);
            Controls.Add(txtQuantidade);
            Controls.Add(label3);
            Controls.Add(cbProduto);
            Controls.Add(label2);
            Controls.Add(txtOrcamento);
            Controls.Add(label1);
            Name = "frmOrcamentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orçamentos";
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
        private TextBox cbCliente;
        private Label label4;
        private TextBox txtQuantidade;
        private Label label3;
        private TextBox cbProduto;
        private Label label2;
        private TextBox txtOrcamento;
        private Label label1;
        private TextBox txtCodigo;
        private Label lbTotal;
        private TextBox txtValor;
        private Label label6;
        private Label label7;
        private RadioButton rbCliente;
        private RadioButton rbOrcamento;
        private RadioButton rbData;
        private ComboBox cbBuscarCliente;
        private DateTimePicker dtBuscar;
    }
}
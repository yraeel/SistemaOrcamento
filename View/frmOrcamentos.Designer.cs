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
            ((System.ComponentModel.ISupportInitialize)dg).BeginInit();
            SuspendLayout();
            // 
            // dg
            // 
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg.Location = new Point(40, 180);
            dg.Name = "dg";
            dg.Size = new Size(526, 205);
            dg.TabIndex = 29;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(435, 401);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 28;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(322, 401);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 27;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(215, 401);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 26;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(109, 401);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 25;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(107, 27);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(131, 23);
            txtBuscar.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 27);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 23;
            label5.Text = "Buscar:";
            // 
            // cbCliente
            // 
            cbCliente.Location = new Point(435, 136);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(131, 23);
            cbCliente.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(368, 136);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 21;
            label4.Text = "Cliente:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(435, 88);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(131, 23);
            txtQuantidade.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 91);
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
            // frmOrcamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 450);
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
    }
}
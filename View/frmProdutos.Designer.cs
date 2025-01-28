
namespace SistemaOrcamento.View
{
    partial class frmProdutos
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
            label1 = new Label();
            txtNome = new TextBox();
            txtDescricao = new TextBox();
            label2 = new Label();
            txtValor = new TextBox();
            label3 = new Label();
            txtCodigo = new TextBox();
            label4 = new Label();
            txtBuscar = new TextBox();
            label5 = new Label();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            dg = new DataGridView();
            txtId = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dg).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(49, 103);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Enabled = false;
            txtNome.Location = new Point(116, 103);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(131, 23);
            txtNome.TabIndex = 1;
            // 
            // txtDescricao
            // 
            txtDescricao.Enabled = false;
            txtDescricao.Location = new Point(116, 145);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(131, 23);
            txtDescricao.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Location = new Point(49, 148);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Descrição:";
            // 
            // txtValor
            // 
            txtValor.Enabled = false;
            txtValor.Location = new Point(444, 100);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(131, 23);
            txtValor.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Location = new Point(377, 103);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Valor:";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(444, 148);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(131, 23);
            txtCodigo.TabIndex = 7;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Location = new Point(377, 148);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Codigo:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(116, 32);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(131, 23);
            txtBuscar.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 32);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 8;
            label5.Text = "Buscar:";
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(118, 413);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 10;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Location = new Point(224, 413);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(331, 413);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(444, 413);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dg
            // 
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg.Location = new Point(49, 192);
            dg.Name = "dg";
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.Size = new Size(526, 205);
            dg.TabIndex = 14;
            dg.CellContentClick += dg_CellContentClick;
            // 
            // txtId
            // 
            txtId.Location = new Point(116, 74);
            txtId.Name = "txtId";
            txtId.Size = new Size(131, 23);
            txtId.TabIndex = 16;
            txtId.Visible = false;
            txtId.TextChanged += txtCodProduto_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 74);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 15;
            label6.Text = "Id:";
            label6.Visible = false;
            // 
            // frmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 450);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(dg);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(txtBuscar);
            Controls.Add(label5);
            Controls.Add(txtCodigo);
            Controls.Add(label4);
            Controls.Add(txtValor);
            Controls.Add(label3);
            Controls.Add(txtDescricao);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmProdutos";
            Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)dg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtDescricao;
        private Label label2;
        private TextBox txtValor;
        private Label label3;
        private TextBox txtCodigo;
        private Label label4;
        private TextBox txtBuscar;
        private Label label5;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridView dg;
        private TextBox txtId;
        private Label label6;
    }
}
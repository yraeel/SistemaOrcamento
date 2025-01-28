using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaOrcamento.Entidades;
using SistemaOrcamento.Model;

namespace SistemaOrcamento.View
{
    public partial class frmProdutos : Form
    {
        ProdutoModel model = new ProdutoModel();
        public frmProdutos()
        {
            InitializeComponent();
            Listar();
        }



        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtCodigo.Enabled = true;
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            txtId.Enabled = true;

        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = false;
            txtValor.Enabled = false;
            txtId.Enabled = false;

        }

        private void Limpar()
        {
            txtNome.Text = "";
            txtCodigo.Text = "";
            txtDescricao.Text = "";
            txtValor.Text = "";
            txtId.Text = "";
        }

        private void Listar()
        {
            try
            {
                dg.DataSource = model.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Salvar(Produtos dado)
        {

            try
            {
                dado.Nome = txtNome.Text;
                dado.Codigo = txtCodigo.Text;
                dado.Descricao = txtDescricao.Text;
                dado.Valor = Convert.ToDecimal(txtValor.Text);

                model.Salvar(dado);

                MessageBox.Show("Produto salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar " + ex.Message);
            }
        }

        public void Excluir(Produtos dado)
        {
            try
            {
                dado.Id_produto = Convert.ToInt32(txtId.Text);

                model.Excluir(dado);
                MessageBox.Show("Produto excluido com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir" + ex.Message);
            }
        }


        public void Buscar(Produtos dado)
        {
            try
            {
                dado.Nome = txtBuscar.Text;
                dado.Codigo = txtCodigo.Text;
                dg.DataSource = model.Buscar(dado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os dados" + ex.Message);
            }
        }

        public void Editar(Produtos dado)
        {
            try
            {
                dado.Id_produto = Convert.ToInt32(txtId.Text);
                dado.Nome = txtNome.Text;
                dado.Codigo = txtCodigo.Text;
                dado.Descricao = txtDescricao.Text;
                dado.Valor = Convert.ToDecimal(txtValor.Text);

                model.Editar(dado);
                MessageBox.Show("Produto editado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar produto" + ex.Message);
            }
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnSalvar.Enabled = true;
            Limpar();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome!");
                return;
            }

            Produtos dados = new Produtos();
            Salvar(dados);
            Listar();
            Limpar();
            DesabilitarCampos();
        }



        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dg.CurrentRow.Cells[1].Value.ToString();
            txtNome.Text = dg.CurrentRow.Cells[2].Value.ToString();
            txtDescricao.Text = dg.CurrentRow.Cells[3].Value.ToString();
            txtValor.Text = dg.CurrentRow.Cells[4].Value.ToString();
            txtId.Text = dg.CurrentRow.Cells[0].Value.ToString();

            HabilitarCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione na tabela um produto para exclusão", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja Excluir produto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            Produtos dado = new Produtos();
            Excluir(dado);
            Listar();
            Limpar();
            DesabilitarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione na tabela um produto para editar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            Produtos dado = new Produtos();
            Editar(dado);
            Listar();
            Limpar();
            DesabilitarCampos();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodProduto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

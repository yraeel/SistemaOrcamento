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
    public partial class frmOrcamentos : Form
    {
        OrcamentoModel model = new OrcamentoModel();
        ProdutoModel modelP = new ProdutoModel();
        ClienteModel modelC = new ClienteModel();
        public frmOrcamentos()
        {
            InitializeComponent();
            Listar();
        }


        //private void PreencherCB()
        //{
        //    cbProduto.DataSource = modelP.Listar();
        //    cbProduto.ValueMember = "id_produto";
        //    cbProduto.DisplayMember = "nome";

        //    cbCliente.DataSource = modelC.Listar();
        //    cbCliente.ValueMember = "id_cliente";
        //    cbCliente.DisplayMember = "nome";
        //}

        private void HabilitarCampos()
        {
            txtOrcamento.Enabled = true;
            txtQuantidade.Enabled = true;
            cbCliente.Enabled = true;
            cbProduto.Enabled = true;


        }

        private void DesabilitarCampos()
        {
            txtOrcamento.Enabled = false;
            txtQuantidade.Enabled = false;
            cbCliente.Enabled = false;
            cbProduto.Enabled = false;

        }

        private void Limpar()
        {
            txtOrcamento.Text = "";
            txtQuantidade.Text = "";
            txtCodigo.Text = "";
            lbTotal.Text = "";
        }

        private void Listar()
        {
            try
            {
                dg.DataSource = model.Listar();

                dg.Columns[0].Visible = false;
                dg.Columns[1].HeaderText = "Número Orçamento";
                dg.Columns[2].HeaderText = "Produto";
                dg.Columns[3].HeaderText = "Cliente";
                dg.Columns[4].HeaderText = "Quantidade";
                dg.Columns[5].HeaderText = "Valor Total";
                dg.Columns[6].HeaderText = "Data";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Salvar(Orcamentos dado)
        {

            try
            {
                dado.Numero_orcamento = txtOrcamento.Text;
                //dado.Id_produto = Convert.ToInt32(cbProduto.SelectedValue);
                //dado.Id_cliente = Convert.ToInt32(cbCliente.SelectedValue);
                dado.Valor_total = 0;
                dado.Data = DateTime.Today;

                model.Salvar(dado);

                MessageBox.Show("Produto salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar " + ex.Message);
            }
        }

        public void Excluir(Orcamentos dado)
        {
            try
            {
                dado.Id_orcamento = Convert.ToInt32(txtCodigo.Text);

                model.Excluir(dado);
                MessageBox.Show("Produto excluido com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir" + ex.Message);
            }
        }


        public void Buscar(Orcamentos dado)
        {
            try
            {
                dado.Numero_orcamento = txtBuscar.Text;
                //dado.Id_cliente = Convert.ToInt32(cbBuscarCliente.SelectedValue);
                //dado.Data = Convert.ToDateTime(dtBuscar.Text);
                dg.DataSource = model.Buscar(dado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os dados" + ex.Message);
            }
        }

        public void BuscarDT(Orcamentos dado)
        {
            try
            {
                dado.Data = Convert.ToDateTime(dtBuscar.Text);
                dg.DataSource = model.Buscar(dado);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os dados" + ex.Message);
            }
        }

        public void BuscarCB(Orcamentos dado)
        {
            try
            {
                dado.Id_cliente = Convert.ToInt32(cbBuscarCliente.SelectedValue);
                dg.DataSource = model.Buscar(dado);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os dados" + ex.Message);
            }
        }



        public void Editar(Orcamentos dado)
        {
            try
            {
                dado.Id_orcamento = Convert.ToInt32(txtCodigo.Text);
                dado.Numero_orcamento = txtOrcamento.Text;
                //dado.Id_produto = Convert.ToInt32(cbProduto.SelectedValue);
                //dado.Id_cliente = Convert.ToInt32(cbCliente.SelectedValue);
                dado.Valor_total = 0;
                dado.Data = DateTime.Today;

                model.Editar(dado);
                MessageBox.Show("Produto editado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar produto" + ex.Message);
            }
        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
            cbBuscarCliente.Visible = true;
            txtBuscar.Visible = false;
            dtBuscar.Visible = false;
            txtBuscar.Text = "";
            cbBuscarCliente.Enabled = true;
        }

        private void rbOrcamento_CheckedChanged(object sender, EventArgs e)
        {
            cbBuscarCliente.Visible = false;
            txtBuscar.Visible = true;
            dtBuscar.Visible = false;
            txtBuscar.Text = "";
            txtBuscar.Enabled = true;
        }

        private void rbData_CheckedChanged(object sender, EventArgs e)
        {
            cbBuscarCliente.Visible = false;
            txtBuscar.Visible = false;
            dtBuscar.Visible = true;
            txtBuscar.Text = "";
            dtBuscar.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnSalvar.Enabled = true;
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtOrcamento.Text == "")
            {
                MessageBox.Show("Preencha o campo Número Orçamento!");
                return;
            }

            Orcamentos dados = new Orcamentos();
            Salvar(dados);
            Listar();
            Limpar();
            DesabilitarCampos();
        }



        //private void Total_Click(object sender, EventArgs e)
        //{

        //}
    }
}

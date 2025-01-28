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
    public partial class frmClientes : Form
    {
        ClienteModel model = new ClienteModel();
        public frmClientes()
        {
            InitializeComponent();
            Listar();
        }

       

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;

        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtTelefone.Enabled = false;

        }

        private void Limpar()
        {
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtCodigo.Text = "";

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

        private void Salvar(Clientes dado)
        {

            try
            {
                dado.Nome = txtNome.Text;
                dado.Telefone = txtTelefone.Text;

                model.Salvar(dado);

                MessageBox.Show("Cliente salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar " + ex.Message);
            }
        }

        public void Excluir(Clientes dado)
        {
            try
            {
                dado.Id_cliente = Convert.ToInt32(txtCodigo.Text);
                dado.Nome = txtNome.Text;
                dado.Telefone = txtTelefone.Text;
                model.Excluir(dado);
                MessageBox.Show("Cliente excluido com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir" + ex.Message);
            }
        }



        public void Buscar(Clientes dado)
        {
            try
            {
                dado.Nome = txtBuscar.Text;
                dg.DataSource = model.Buscar(dado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os dados" + ex.Message);
            }
        }

        public void Editar(Clientes dado)
        {
            try
            {
                dado.Id_cliente = Convert.ToInt32(txtCodigo.Text);
                dado.Nome = txtNome.Text;
                dado.Telefone = txtTelefone.Text;

                model.Editar(dado);
                MessageBox.Show("Cliente editado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar cliente" + ex.Message);
            }
        }



        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione na tabela um cliente para exclusão", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja Excluir cliente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            Clientes dado = new Clientes();
            Excluir(dado);
            Listar();
            Limpar();
            DesabilitarCampos();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione na tabela um cliente para editar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            Clientes dado = new Clientes();
            Editar(dado);
            Listar();
            Limpar();
            DesabilitarCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome!");
                return;
            }

            Clientes dados = new Clientes();
            Salvar(dados);
            Listar();
            Limpar();
            DesabilitarCampos();
        }



        //private void txtNome_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void dg_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dg.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dg.CurrentRow.Cells[1].Value.ToString();
            txtTelefone.Text = dg.CurrentRow.Cells[2].Value.ToString();
            HabilitarCampos();
        }





        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Clientes dado = new Clientes();
            Buscar(dado);

            if (txtBuscar.Text == "")
            {
                Listar();
                return;
            }
        }



        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaOrcamento.Entidades;

namespace SistemaOrcamento.Controller
{
    public class OrcamentoController
    {
        MySqlCommand sql;
        Conexao con = new Conexao();


        public DataTable Listar()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM orcamentos order by data desc", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter(sql);
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Editar(Orcamentos dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE orcamentos SET numero_orcamento = @numero_orcamento, id_produto = @id_produto, id_cliente = @id_cliente, quantidade = @quantidade, valor_total = @valor_total, data = @data WHERE id_orcamento = @id", con.con);
                sql.Parameters.AddWithValue("@numero_orcamento", dado.Numero_orcamento);
                sql.Parameters.AddWithValue("@id_produto", dado.Id_produto);
                sql.Parameters.AddWithValue("@id_cliente", dado.Id_cliente);
                sql.Parameters.AddWithValue("@quantidade", dado.Quantidade);
                sql.Parameters.AddWithValue("@valor_total", dado.Valor_total);
                sql.Parameters.AddWithValue("@data", dado.Data);
                sql.Parameters.AddWithValue("@id", dado.Id_orcamento);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar " + ex.Message);
                con.FecharConexao();
            }
        }

        public DataTable Buscar(Orcamentos dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM orcamentos WHERE numero_orcamento like @numero_orcamento or id_cliente like @id_Cliente or data = @data", con.con);
                sql.Parameters.AddWithValue("@numero_orcamento", dado.Numero_orcamento);
                sql.Parameters.AddWithValue("@id_cliente", dado.Id_cliente);
                sql.Parameters.AddWithValue("@data", dado.Data);


                MySqlDataAdapter da = new MySqlDataAdapter(sql);
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
                con.FecharConexao();
            }
        }

        public void Excluir(Orcamentos dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM orcamentos WHERE id_orcamento = @id", con.con);
                sql.Parameters.AddWithValue("@id", dado.Id_orcamento);
                sql.ExecuteNonQuery();
                con.FecharConexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir. " + ex.Message);
                con.FecharConexao();
            }
        }

        public void Inserir(Orcamentos dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO orcamentos (numero_orcamento, id_produto, id_cliente, quantidade, valor_total, data) values (@numero_orcamento, @id_produto, @id_cliente, @quantidade, @valor_total, @data)", con.con);
                sql.Parameters.AddWithValue("@numero_orcamento", dado.Numero_orcamento);
                sql.Parameters.AddWithValue("@id_produto", dado.Id_produto);
                sql.Parameters.AddWithValue("@id_cliente", dado.Id_cliente);
                sql.Parameters.AddWithValue("@quantidade", dado.Quantidade);
                sql.Parameters.AddWithValue("@valor_total", dado.Valor_total);
                sql.Parameters.AddWithValue("@data", dado.Data);

                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar " + ex.Message);
                con.FecharConexao();
            }
        }
    }
}

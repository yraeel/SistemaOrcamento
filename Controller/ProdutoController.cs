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
    public class ProdutoController
    {
        MySqlCommand sql;
        Conexao con = new Conexao();


        public DataTable Listar()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM produtos order by nome desc", con.con);
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

        public void Editar(Produtos dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE produtos SET nome = @nome, codigo = @codigo, descricao = @descricao, valor = @valor WHERE id_produto = @id", con.con);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@codigo", dado.Codigo);
                sql.Parameters.AddWithValue("@descricao", dado.Descricao);
                sql.Parameters.AddWithValue("@valor", dado.Valor);
                sql.Parameters.AddWithValue("@id", dado.Id_produto);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar " + ex.Message);
                con.FecharConexao();
            }
        }

        public DataTable Buscar(Produtos dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM produtos WHERE nome like @nome or codigo like @codigo", con.con);
                sql.Parameters.AddWithValue("@nome", dado.Nome + "%");
                sql.Parameters.AddWithValue("@codigo", dado.Codigo + "%");

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

        public void Excluir(Produtos dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM produtos WHERE id_produto = @id", con.con);
                sql.Parameters.AddWithValue("@id", dado.Id_produto);
                sql.ExecuteNonQuery();
                con.FecharConexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir. " + ex.Message);
                con.FecharConexao();
            }
        }

        public void Inserir(Produtos dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO produtos (nome, codigo, descricao, valor) values (@nome, @codigo, @descricao, @valor)", con.con);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@codigo", dado.Codigo);
                sql.Parameters.AddWithValue("@descricao", dado.Descricao);
                sql.Parameters.AddWithValue("@valor", dado.Valor);


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

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaOrcamento.Entidades;
using ZstdSharp;

namespace SistemaOrcamento.Controller
{
    public class ClienteController
    {
        MySqlCommand sql;
        Conexao con = new Conexao();


        public DataTable Listar()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM clientes order by id_cliente desc", con.con);
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

        public void Editar(Clientes dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE clientes SET nome = @nome, telefone = @telefone WHERE id_cliente = @id", con.con);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@telefone", dado.Telefone);
                sql.Parameters.AddWithValue("@id", dado.Id_cliente);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar " + ex.Message);
                con.FecharConexao();
            }
        }

        public DataTable Buscar(Clientes dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM clientes WHERE nome like @nome", con.con);
                sql.Parameters.AddWithValue("@nome", dado.Nome + "%");
                sql.Parameters.AddWithValue("@telefone", dado.Telefone + "%");

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

        public void Excluir(Clientes dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM clientes WHERE id_cliente = @id", con.con);
                sql.Parameters.AddWithValue("@id", dado.Id_cliente);
                sql.ExecuteNonQuery();
                con.FecharConexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir. " + ex.Message);
                con.FecharConexao();
            }
        }

        public void Inserir(Clientes dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO clientes (nome, telefone) values (@nome, @telefone)", con.con);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@telefone", dado.Telefone);
               
                
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace SistemaOrcamento
{
    public class Conexao
    {
        string conexao = "SERVER=localhost; DATABASE=orcamento; UID=root; PWD=;";

        public MySqlConnection con = null;

        public void AbrirConexao()
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar" + ex.Message);
            }
        }

        public void FecharConexao()
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fechar conexão." + ex.Message);
            }
        }
    
    }


}

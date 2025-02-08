using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaOrcamento.Controller;
using SistemaOrcamento.Entidades;

namespace SistemaOrcamento.Model
{
    public class OrcamentoModel
    {
        OrcamentoController controller = new OrcamentoController();

        public DataTable Listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = controller.Listar();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void Salvar(Orcamentos dado)
        {
            try
            {
                controller.Inserir(dado);
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
                controller.Editar(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(Orcamentos dado)
        {
            try
            {
                controller.Excluir(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object Buscar(Orcamentos dado)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = controller.Buscar(dado);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

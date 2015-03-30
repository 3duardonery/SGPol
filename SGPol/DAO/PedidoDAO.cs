using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGPol.Classes;
using System.Data.SqlClient;

namespace SGPol.DAO
{
    class PedidoDAO
    {
        private SqlConnection sConn;
        private List<Pedido> listaPedido;

        public void InserirPedido(Pedido pedido)
        {
            try
            {

            }
            catch (SqlException sqlExc)
            {
                
            }
        }

        public List<Pedido> ListaPedidos()
        {

            return listaPedido;
        }

        public void AtualizarPedido(int id_pedido)
        {
        }
        public void AtualizarPedido(Pedido pedido)
        {
        }

        public int BuscaCodPedido(Pedido pedido)
        {
            int id_pedido = 0;
            return id_pedido;
        }

        public void ExcluirPedido(int id)
        {

        }
    }
}

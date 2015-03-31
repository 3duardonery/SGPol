using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGPol.DAO;
using SGPol.Classes;

namespace SGPol
{
    public partial class FrmBuscaPedido : Form
    {
        //private Pedido pedido;
        private List<Pedido> listPedido;
        private PedidoDAO pedidoDAO;
        public FrmBuscaPedido()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (rbCliente.Checked)
            {
                pedidoDAO = new PedidoDAO();
                listPedido = pedidoDAO.BuscaNomeCliente(txtCampoBusca.Text);
                carregaLista();
            }
            else if (rbEtiq.Checked)
            {
                pedidoDAO = new PedidoDAO();
                listPedido = pedidoDAO.BuscaEtiqueta(txtCampoBusca.Text);
                carregaLista();
            }
            else if (rbOs.Checked)
            {
                pedidoDAO = new PedidoDAO();
                listPedido = pedidoDAO.BuscaOs(txtCampoBusca.Text);
                if (listPedido.Count == 0)
                {
                    MessageBox.Show("Não houve resultados para a consulta!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    carregaLista();
                }
                
            }
            else
            {
                MessageBox.Show("Por favor selecione uma opção de busca.","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
                
            
        }

        public void carregaLista()
        {
            try
            {
                dtListPedidos.Rows.Clear();
                
                

            foreach(Pedido pedido2 in listPedido)
            {
                dtListPedidos.Rows.Add(pedido2.Id, pedido2.Cliente, pedido2.Etiqueta, pedido2.Os, pedido2.Obs);
            }
            }
            catch (Exception exc)
            {

                MessageBox.Show("Erro ao carregar a lista .. "+exc.Message,"ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGPol.Classes;
using SGPol.DAO;

namespace SGPol
{
    public partial class FrmListaPedidosFull : Form
    {
        private PedidoDAO pedidoDAO;
        private Pedido pedido = new Pedido();
        private List<Pedido> listPedido;
        private static FrmListaPedidosFull frmListFull;
        public FrmListaPedidosFull()
        {
            InitializeComponent();
            carregaGrid();
        }

        public static FrmListaPedidosFull getInstance()
        {
            if (frmListFull == null)
                frmListFull = new FrmListaPedidosFull();
            return frmListFull;
        }

        private void carregaInfPedido(object sender, EventArgs e)
        {
            try
            {
                lbId.Text = gridListPedidos.CurrentRow.Cells[0].Value.ToString();
                lbNome.Text = gridListPedidos.CurrentRow.Cells[1].Value.ToString();
                lbEtiqueta.Text = gridListPedidos.CurrentRow.Cells[2].Value.ToString();
                lbOs.Text = gridListPedidos.CurrentRow.Cells[3].Value.ToString();
                lbObs.Text = gridListPedidos.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("O sistema não suporta seleção multiplas de pedidos!","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            
        }

        public void carregaGrid()
        {
            gridListPedidos.Rows.Clear();
            pedidoDAO = new PedidoDAO();
            listPedido = pedidoDAO.ListaPedidos();

            foreach(Pedido pedido2 in listPedido)
            {
                gridListPedidos.Rows.Add(pedido2.Id,pedido2.Cliente,pedido2.Etiqueta,pedido2.Os,pedido2.Obs);
            }
        }
    }
}

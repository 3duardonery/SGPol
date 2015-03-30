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
            pedidoDAO = new PedidoDAO();
            listPedido = pedidoDAO.ListaPedidos();

            foreach(Pedido pedido2 in listPedido)
            {
                gridListPedidos.Rows.Add(pedido2.Id,pedido2.Cliente,pedido2.Etiqueta,pedido2.Os,pedido2.Obs);
            }


            //gridListPedidos.Rows.Add(1,"EMPRESA XVZY","ETIQUETA 12X50","1234","ESSE ETIQEUTA TEM QUE SER IMPRESSA NA MAQ 2");
            //gridListPedidos.Rows.Add(1, "EMPRESA WAZ", "ETIQUETA 20X40", "3453", "ESSE ETIQEUTA TEM QUE SER IMPRESSA NA MAQ 5");
            //gridListPedidos.Rows.Add(1, "EMPRESA TER", "ETIQUETA 30X50", "1278", "ESSE ETIQEUTA TEM QUE SER IMPRESSA NA MAQ 1");
            //gridListPedidos.Rows.Add(1, "EMPRESA OPK", "ETIQUETA 15X20", "2343", "ESSE ETIQEUTA TEM QUE SER IMPRESSA NA MAQ 3");
        }
    }
}

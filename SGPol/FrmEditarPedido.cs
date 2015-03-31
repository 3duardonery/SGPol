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
    public partial class FrmEditarPedido : Form
    {
        private Pedido editarPedido;
        private Pedido recuperarPedido = new Pedido();
        private PedidoDAO pedidoDAO;
        private List<Pedido> listPedido;
        private static FrmEditarPedido frmEditPedido;

        public FrmEditarPedido()
        {
            InitializeComponent();
            carregaGrid();
        }

        public static FrmEditarPedido getInstance()
        {
            if (frmEditPedido == null)
                frmEditPedido = new FrmEditarPedido();
            return frmEditPedido;
        }

        public void carregaGrid()
        {

            dtGridPedidos.Rows.Clear();
            pedidoDAO = new PedidoDAO();
            listPedido = pedidoDAO.ListaPedidos();

            foreach (Pedido pedido2 in listPedido)
            {
                dtGridPedidos.Rows.Add(pedido2.Id, pedido2.Cliente, pedido2.Etiqueta, pedido2.Os, pedido2.Obs);
            }
        }

        private void carregaCampos(object sender, EventArgs e)
        {
            try
            {
                txtIdPedido.Text = dtGridPedidos.CurrentRow.Cells[0].Value.ToString();
                txtCliente.Text = dtGridPedidos.CurrentRow.Cells[1].Value.ToString();
                txtEtiqueta.Text = dtGridPedidos.CurrentRow.Cells[2].Value.ToString();
                txtOs.Text = dtGridPedidos.CurrentRow.Cells[3].Value.ToString();
                txtObs.Text = dtGridPedidos.CurrentRow.Cells[4].Value.ToString();

                recuperarPedido.Id = int.Parse(dtGridPedidos.CurrentRow.Cells[0].Value.ToString());
                recuperarPedido.Cliente = dtGridPedidos.CurrentRow.Cells[1].Value.ToString();
                recuperarPedido.Etiqueta = dtGridPedidos.CurrentRow.Cells[2].Value.ToString();
                recuperarPedido.Os = dtGridPedidos.CurrentRow.Cells[3].Value.ToString();
                recuperarPedido.Obs = dtGridPedidos.CurrentRow.Cells[4].Value.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("O sistema não suporta seleção multiplas de pedidos!","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                editarPedido = new Pedido();
                editarPedido.Id = int.Parse(txtIdPedido.Text);
                editarPedido.Cliente = txtCliente.Text;
                editarPedido.Etiqueta = txtEtiqueta.Text;
                editarPedido.Os = txtOs.Text;
                editarPedido.Obs = txtObs.Text;

                DialogResult res = MessageBox.Show("Você realmente deseja atualizar o registro?","CONFIRMAÇÃO",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    pedidoDAO.AtualizarPedido(editarPedido);
                    carregaGrid();
                }
                MessageBox.Show("Registro atualizado com sucesso!","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show("O sistema não conseguiu atualizar o registro. " + exc.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

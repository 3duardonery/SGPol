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
    public partial class FrmNovoPedido : Form
    {
        private static FrmNovoPedido frmNP;
        private PedidoDAO pedidoDAO = new PedidoDAO();
        private Pedido pedido;

        public FrmNovoPedido()
        {
            InitializeComponent();
        }
        public static FrmNovoPedido getInstance()
        {
            if (frmNP == null)
                frmNP = new FrmNovoPedido();
            return frmNP;
        }

        private void btCad_Click(object sender, EventArgs e)
        {
            try
            {
                pedido = new Pedido();
                pedido.Cliente = txtCliente.Text;
                pedido.Etiqueta = txtModeloEti.Text;
                pedido.Os = txtOs.Text;
                pedido.Obs = txtObs.Text;
                if (!pedido.Cliente.Equals(""))
                {
                    if (!pedido.Etiqueta.Equals(""))
                    {
                        pedidoDAO.InserirPedido(pedido);
                    }
                    else
                    {
                        MessageBox.Show("Campo Etiqueta não aceita NULO!!!  ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Campo Cliente não aceita NULO!!!  ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Registro inserido com sucesso!!!","SUCESSO",MessageBoxButtons.OK,MessageBoxIcon.Information); 
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erro ao tentar Inserir novo pedido.  "+exc.Message,"ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}

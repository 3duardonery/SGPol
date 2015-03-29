using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGPol.Classes;

namespace SGPol
{
    public partial class FrmListaPedidos : Form
    {
        //OBJETO 
        Pedido pedido = new Pedido();
        /*
         * METODO CONSTRUTOR DEFAULT
         * */
        public FrmListaPedidos()
        {
            InitializeComponent();
        }
        /*
         * METODO CONSTRUTOR QUE RECEBE A INSTANCIA DA FORM NOVA ARTE
         * */
        public FrmListaPedidos(FrmNovaArte frm)
        {

            InitializeComponent();
            //CARREGA OS DADOS NO GRID
            carregaTabela();
        }
        /* ESSE METODO APENAS CARREGA ALGUNS DADOS PARA O GRID
         * FUTURAMENTE VAI CARREGAR UMA LISTA DO TIPO PEDIDOS PROVINDA DO BANCO DE DADOS
         * */
        public void carregaTabela()
        {
            gridViewPedido.Rows.Add(1,"Teste","Teste","Teste");
            gridViewPedido.Rows.Add(2, "Teste3", "Teste32", "Teste32");
            gridViewPedido.Rows.Add(3, "Teste345", "Teste435", "Teste432");
            gridViewPedido.Rows.Add(4, "Teste4355", "Teste67", "Teste56");
            gridViewPedido.Rows.Add(5, "Teste356", "Teste4556", "Teste765");
        }

        /* ESSE METODO AO SER ACIONADO PEGA A INSTANCIA DO FORM NOVAARTE 
         * E CARREGA OS DADOS DO OBJETO PED2(PEDIDO) NOS LABELS PARA INFORMAR OS DADOS DO PEDIDO SELECIONADO 
         * AO MESMO TEMPO DEIXA O BOTÃO BTSELECT.ENABLE = FALSE(BLOQUEADO)
         * E NA ULTIMA LINHA ELE FECHA ESTA FORM
         * (ADCIONAR METODO DE VERIFICAÇÃO SE TEM ALGUMA LINHA DO GRID SELECIONADA)
         * */
        private void btSelecionar_Click(object sender, EventArgs e)
        {     
            FrmNovaArte frmNvArte = FrmNovaArte.getInstance();
            frmNvArte.lbIdPedido.Text = ""+pedido.Id;
            frmNvArte.lbCliente.Text = pedido.Cliente;
            frmNvArte.lbEtiqueta.Text = pedido.Etiqueta;
            frmNvArte.lbOs.Text = pedido.Os;
            frmNvArte.btSelect.Enabled = false;
            this.Close();
        }

        /* ESSE METODO DO TIPO SELECTION CHANGED DO GRID ELE CONFORME O USUARIO SELECIONA UMA LINHA DO GRID
         * ELE SETA INFORMAÇÃO NO OBJETO PED2(PEDIDO) PARA QUE POSTERIORMENTE POSSA SER PASSADO PARA A OUTRA FORM
         * */
        private void carregaPedido(object sender, EventArgs e)
        {
            pedido.Id = int.Parse(gridViewPedido.CurrentRow.Cells[0].Value.ToString());
            pedido.Cliente = gridViewPedido.CurrentRow.Cells[1].Value.ToString();
            pedido.Etiqueta = gridViewPedido.CurrentRow.Cells[2].Value.ToString();
            pedido.Os = gridViewPedido.CurrentRow.Cells[3].Value.ToString();
        }
    }
}

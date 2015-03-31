using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SGPol
{
    public partial class FrmMain : Form
    {

       
        #region FORMS
        private FrmNovoPedido frmNovo;
        private FrmNovaArte frmNovaArte;
        private FrmListaPedidosFull frmListFull;
        private FrmExcluirPedido frmExcluirPedido;
        private FrmEditarPedido frmEditPedido;
        private static FrmMain frmMain;
        #endregion

        /*
         * METODO SINGLETON
         * INSTANCIA UNICA DA APLICAÇÃO
         * */
        public static FrmMain getInstance()
        {
            if (frmMain == null)
                frmMain = new FrmMain();
            return frmMain;
        }
        /*
         * METODO CONSTRUTOR DA FORM
         * */
        public FrmMain()
        {
            InitializeComponent();
        }
       

        #region ITENS DO MENU
        /*
         * AÇÃO DE CLICK NO ITEM PEDIDO -- EXCLUIR
         * */
        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExcluirPedido = FrmExcluirPedido.getInstance();
            frmExcluirPedido.ShowDialog();
        }
        /*
         * AÇÃO DE CLICK NO SUBITEM EDITAR DADOS DENTRO DE PEDIDO
         * */
        private void editarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditPedido = FrmEditarPedido.getInstance();
            frmEditPedido.ShowDialog();
        }
        
        /*
         * AÇÃO DE CLICK NO ITEM AJUDA -- SOBRE DO MENU
         * */
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre frmSobre = new FrmSobre();
            frmSobre.ShowDialog();
        }
        /*
         * AÇÃO DE CLICK NO ITEM NOVO PEDIDO DO MENU
         * */
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovo = FrmNovoPedido.getInstance();
            frmNovo.ShowDialog();
        }
        /*
         * AÇÃO DE CLICK NO ITEM NOVA ARTE
         * */
        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNovaArte = FrmNovaArte.getInstance();
            frmNovaArte.ShowDialog();
        }
        /*
         * AÇÃO DE CLICK NO ITEM PEDIDO -- CONSULTAR NO MENU 
         * */
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListFull = FrmListaPedidosFull.getInstance();
            frmListFull.ShowDialog();
        }
        /*
         * AÇÃO DE CLICK NO ITEM SAIR
         * ABRI UMA CAIXA DE PERGUNTA PARA CONFIRMAR SAIDA
         * */
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CRIADO UM DIALOG RESULT PARA CAPTURAR A RESPOSTA DO USER NO MESSAGEBOX
            DialogResult res = MessageBox.Show("Você deseja sair do sistema?",
                 "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //SE O res FOR IGUAL A SIM
            if (res == DialogResult.Yes)
            {
                //APLICAÇÃO FECHA
                Application.Exit();
            }
        }
        /*
         * AÇÃO DE CLICK NO ITEM AJUDA -- TESTAR CONEXÃO -- DO MENU
         * */
        private void testarConexãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //OBJETO SQLCONECTION QUE IRÁ RECEBER A INSTANCIA DA CLASSE Util.Conexao.cs    
                SqlConnection con = Util.Conexao.ObterConexao();
                //STRING DE MENSAGEM DE INFORMAÇÕES SOBRE A CONEXÃO COM O BANCO
                string msg = string.Format("Nome do Server :{0} Nome da Instância : {1}"+
                "Banco Conectado : {2}",Util.Conexao.server,Util.Conexao.instance,Util.Conexao.db);
                //CONDIÇÃO DE ESTADO DO OBJETO con SE ELE FOR DIFERENTE DE NULO
                if (con != null)
                {
                    //CONEXÃO ABRE
                    con.Open();
                    MessageBox.Show("Conectado com sucesso: "+msg,"INFORMAÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    //CONEXÃO FECHA
                    con.Close();
                }

            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Erro ao tentar abrir conexão "+sqlEx.Message,"ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion

        

        

    }
}

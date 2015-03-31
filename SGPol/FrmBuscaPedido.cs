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
        /*
         * OBJETOS(LIST<PEDIDO> E PEDIDODAO) USADOS NESSA FORM
         * */
        private List<Pedido> listPedido;
        private PedidoDAO pedidoDAO;

        /*
         * METODO CONSTRUTOR DA FORM
         * */
        public FrmBuscaPedido()
        {
            InitializeComponent();
        }
        /*
         * METODO QUE FAZ A BUSCA PELA OPÇÃO ESCOLHIDA(CLIENTE,ETIQUETA OU O.S)
         * */
        private void btBuscar_Click(object sender, EventArgs e)
        {
            // SE O RADIO BUTTON rbCliente ESTIVER CHECADO
            // CRIA UMA NOVA INSTANCIA DO OBJETO pedidoDAO
            // A LISTA ACESSA O METODO DE BUSCA POR NOME DO CLIENTE E PASSA O CAMPO BUSCA DE TEXTO
            // CHECA SE TEM ALGUM RADIO BOX BUTTON SELECIONADO
            if (rbCliente.Checked)
            {
                //NOVA INSTANCIA
                pedidoDAO = new PedidoDAO();
                // OBJETO LIST RECEBE OU NÃO UMA LISTA DE PEDIDOS COMO RETORNO DO METODO pedidoDAO.BuscaNomeCliente() 
                listPedido = pedidoDAO.BuscaNomeCliente(txtCampoBusca.Text);
                // VERIFICA SE A LISTA VEIO VAZIA
                if (listPedido.Count == 0)
                {
                    // SE A LISTA ESTIVER VAZIA, NÃO HOUVE NENHUM RESULTADO DA PESQUISA
                    // AVISO QUE NÃO RETORNOU NADA
                    MessageBox.Show("Não houve resultados para a consulta!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // SE A LISTA CONTIVER ALGO, O SISTEMA CHAMA O METODO RESPONSAVEL PELO CARREGAMENTO DE DADOS NO GRID
                    carregaLista();
                }
            }
            // SE O RADIO BUTTON rbEtiq ESTIVER CHECADO
            // CRIA UMA NOVA INSTANCIA DO OBJETO pedidoDAO
            // A LISTA ACESSA O METODO DE BUSCA POR NOME DA ETIQUETA E PASSA O CAMPO BUSCA DE TEXTO
            else if (rbEtiq.Checked)
            {
                //NOVA INSTANCIA
                pedidoDAO = new PedidoDAO();
                // OBJETO LIST RECEBE OU NÃO UMA LISTA DE PEDIDOS COMO RETORNO DO METODO pedidoDAO.BuscaEtiqueta() 
                listPedido = pedidoDAO.BuscaEtiqueta(txtCampoBusca.Text);
                // VERIFICA SE A LISTA VEIO VAZIA
                if (listPedido.Count == 0)
                {
                    // SE A LISTA ESTIVER VAZIA, NÃO HOUVE NENHUM RESULTADO DA PESQUISA
                    // AVISO QUE NÃO RETORNOU NADA
                    MessageBox.Show("Não houve resultados para a consulta!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // SE A LISTA CONTIVER ALGO, O SISTEMA CHAMA O METODO RESPONSAVEL PELO CARREGAMENTO DE DADOS NO GRID
                    carregaLista();
                }
            }
            // SE O RADIO BUTTON rbOs ESTIVER CHECADO
            // CRIA UMA NOVA INSTANCIA DO OBJETO pedidoDAO
            // A LISTA ACESSA O METODO DE BUSCA POR NUMERO DA OS E PASSA O CAMPO BUSCA DE TEXTO
            else if (rbOs.Checked)
            {
                //NOVA INSTANCIA
                pedidoDAO = new PedidoDAO();
                // OBJETO LIST RECEBE OU NÃO UMA LISTA DE PEDIDOS COMO RETORNO DO METODO pedidoDAO.BuscaOs() 
                listPedido = pedidoDAO.BuscaOs(txtCampoBusca.Text);
                // VERIFICA SE A LISTA VEIO VAZIA
                if (listPedido.Count == 0)
                {
                    // SE A LISTA ESTIVER VAZIA, NÃO HOUVE NENHUM RESULTADO DA PESQUISA
                    // AVISO QUE NÃO RETORNOU NADA
                    MessageBox.Show("Não houve resultados para a consulta!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // SE A LISTA CONTIVER ALGO, O SISTEMA CHAMA O METODO RESPONSAVEL PELO CARREGAMENTO DE DADOS NO GRID
                    carregaLista();
                }
                
            }
            // SE NENHUM RADIO BUTTON ESTIVER SELECIONADO O SISTEMA RETONARÁ UMA MENSAGEM DE AVISO
            else
            {
                // MENSAGEM EM CASO NENHUM RADIO ESTIVER MARCADO
                MessageBox.Show("Por favor selecione uma opção de busca.","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        /*
         * METODO DE CARREGAMENTO DO GRID
         * DESCARREGA A LISTA DE PEDIDOS NO GRID
         * */
        public void carregaLista()
        {
            try
            {
                // PRIMEIRO É FEITO A LIMPA NO GRID CASO HAVER OUTRO RESULTADO DE CONSULTA
                dtListPedidos.Rows.Clear();
                // PARA CADA OBJETO PEDIDO NA LIST
                foreach(Pedido pedido2 in listPedido)
                {
                    // O GRID ADICIONA UMA LINHA E PREENCHE COM OS DADOS DO OBJETO
                    dtListPedidos.Rows.Add(pedido2.Id, pedido2.Cliente, pedido2.Etiqueta, pedido2.Os, pedido2.Obs);
                }
            }
            catch (Exception exc)
            {
                // MESSAGEM DE ERRO AO TENTAR CARREGAR O GRID
                MessageBox.Show("Erro ao carregar a lista .. "+exc.Message,"ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}

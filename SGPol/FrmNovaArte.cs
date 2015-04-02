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
    public partial class FrmNovaArte : Form
    {
        static FrmNovaArte frmNvArte;
        private ArteDAO arteDAO;
        private Arte arte;


        public FrmNovaArte()
        {
            InitializeComponent();
        }

        public static FrmNovaArte getInstance()
        {
            if (frmNvArte == null)
                frmNvArte = new FrmNovaArte();
            return frmNvArte;
        }

        //public string lbidt
        //{
        //    get { return this.lbIdPedido.Text; }
        //    set { this.lbIdPedido.Text = value; }
        //}

        private void btSelect_Click(object sender, EventArgs e)
        {
            FrmListaPedidos lista = new FrmListaPedidos(this);
            lista.ShowDialog();
        }

        private void AtivaDtElaboracao(object sender, EventArgs e)
        {
            if (chkCampoDt.Checked)
                txtDtElab.Enabled = true;
            else
                txtDtElab.Enabled = false;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtObs.Text = cbOpcPri.Text;
        }

        private void btCadArte_Click(object sender, EventArgs e)
        {
            try
            {
                arteDAO = new ArteDAO();
                arte = new Arte();
                arte.Id_pedido = int.Parse(lbIdPedido.Text);
                arte.Prazo_arte = Util.FormatData.FormataData(txtPrazo.Text);
                if (txtDtElab.Enabled)
                    arte.Data_elab = Util.FormatData.FormataData(txtDtElab.Text);
                else
                    arte.Data_elab = null;
                arte.Prioridade = int.Parse(cbOpcPri.Text);
                arte.Status = cbOpcStatus.Text;
                arte.Obs = txtObs.Text;
                if (arteDAO.InserirArte(arte).Equals("Registro inserido com sucesso!"))
                {
                    MessageBox.Show("Registro Inserido com Sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(arteDAO.InserirArte(arte), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //MessageBox.Show(arteDAO.InserirArte(arte),"AVISO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //arteDAO.InserirArte();

            }
            catch (Exception exc)
            {
                MessageBox.Show(arteDAO.InserirArte(arte), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

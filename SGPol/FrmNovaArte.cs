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
    public partial class FrmNovaArte : Form
    {
        static FrmNovaArte frmNvArte;


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

        public string lbidt
        {
            get { return this.lbIdPedido.Text; }
            set { this.lbIdPedido.Text = value; }
        }

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
            
        }

        private void btCadArte_Click(object sender, EventArgs e)
        {

        }
    }
}

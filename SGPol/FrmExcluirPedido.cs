using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGPol
{
    public partial class FrmExcluirPedido : Form
    {

        private static FrmExcluirPedido frmExcluir;
        public FrmExcluirPedido()
        {
            InitializeComponent();
        }

        public static FrmExcluirPedido getInstance()
        {
            if (frmExcluir == null)
                frmExcluir = new FrmExcluirPedido();
            return frmExcluir;

        }
    }
}

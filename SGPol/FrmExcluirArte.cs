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
    public partial class FrmExcluirArte : Form
    {

        private static FrmExcluirArte frmExcluir;
        public FrmExcluirArte()
        {
            InitializeComponent();
        }

        public static FrmExcluirArte getInstance()
        {
            if (frmExcluir == null)
                frmExcluir = new FrmExcluirArte();
            return frmExcluir;

        }
    }
}

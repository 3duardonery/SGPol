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
    public partial class FrmListArte : Form
    {
    
        private List<ViewArte> _listArte;
        private ViewArte _vArte;

        public FrmListArte()
        {
            InitializeComponent();
        }

        public void CarregaGrid()
        {
        }
    }
}

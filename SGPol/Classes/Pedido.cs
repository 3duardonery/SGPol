using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGPol.Classes
{
    class Pedido
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string cliente;

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        private string etiqueta;

        public string Etiqueta
        {
            get { return etiqueta; }
            set { etiqueta = value; }
        }
        private string os;

        public string Os
        {
            get { return os; }
            set { os = value; }
        }
    }
}

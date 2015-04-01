using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGPol.Classes
{
    class Arte
    {
        private int id_arte;

        public int Id_arte
        {
            get { return id_arte; }
            set { id_arte = value; }
        }
        private int id_pedido;

        public int Id_pedido
        {
            get { return id_pedido; }
            set { id_pedido = value; }
        }
        private string prazo_arte;

        public string Prazo_arte
        {
            get { return prazo_arte; }
            set { prazo_arte = value; }
        }
        private string data_elab;

        public string Data_elab
        {
            get { return data_elab; }
            set { data_elab = value; }
        }
        private int prioridade;

        public int Prioridade
        {
            get { return prioridade; }
            set { prioridade = value; }
        }
        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private string obs;

        public string Obs
        {
            get { return obs; }
            set { obs = value; }
        }

    }
}

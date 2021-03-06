﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGPol.Classes
{
    class Arte
    {
        private int id_arte;
        private int id_pedido;
        private string prazo_arte;
        private string data_elab;
        private int prioridade;
        private string status;
        private string obs;

        public int Id_arte
        {
            get { return id_arte; }
            set { id_arte = value; }
        }
        

        public int Id_pedido
        {
            get { return id_pedido; }
            set { id_pedido = value; }
        }
        

        public string Prazo_arte
        {
            get { return prazo_arte; }
            set { prazo_arte = value; }
        }
        

        public string Data_elab
        {
            get { return data_elab; }
            set { data_elab = value; }
        }
        

        public int Prioridade
        {
            get { return prioridade; }
            set { prioridade = value; }
        }
        

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        

        public string Obs
        {
            get { return obs; }
            set { obs = value; }
        }

    }
}

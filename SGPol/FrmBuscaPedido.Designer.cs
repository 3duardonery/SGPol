﻿namespace SGPol
{
    partial class FrmBuscaPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscaPedido));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCampoBusca = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.dtListPedidos = new System.Windows.Forms.DataGridView();
            this.groupRb = new System.Windows.Forms.GroupBox();
            this.rbOs = new System.Windows.Forms.RadioButton();
            this.rbEtiq = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etiqueta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.os = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btNovaArte = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.rbTudo = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListPedidos)).BeginInit();
            this.groupRb.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btBuscar);
            this.panel1.Controls.Add(this.groupRb);
            this.panel1.Controls.Add(this.txtCampoBusca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 61);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PALAVRA CHAVE A SER PROCURADA :";
            // 
            // txtCampoBusca
            // 
            this.txtCampoBusca.Enabled = false;
            this.txtCampoBusca.Location = new System.Drawing.Point(216, 16);
            this.txtCampoBusca.Name = "txtCampoBusca";
            this.txtCampoBusca.Size = new System.Drawing.Size(262, 20);
            this.txtCampoBusca.TabIndex = 1;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(775, 9);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(76, 44);
            this.btBuscar.TabIndex = 5;
            this.btBuscar.Text = "BUSCAR";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // dtListPedidos
            // 
            this.dtListPedidos.AllowUserToAddRows = false;
            this.dtListPedidos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtListPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cliente,
            this.etiqueta,
            this.os,
            this.obs});
            this.dtListPedidos.Location = new System.Drawing.Point(13, 80);
            this.dtListPedidos.Name = "dtListPedidos";
            this.dtListPedidos.Size = new System.Drawing.Size(867, 292);
            this.dtListPedidos.TabIndex = 1;
            // 
            // groupRb
            // 
            this.groupRb.Controls.Add(this.rbTudo);
            this.groupRb.Controls.Add(this.rbOs);
            this.groupRb.Controls.Add(this.rbCliente);
            this.groupRb.Controls.Add(this.rbEtiq);
            this.groupRb.Location = new System.Drawing.Point(484, 3);
            this.groupRb.Name = "groupRb";
            this.groupRb.Size = new System.Drawing.Size(276, 50);
            this.groupRb.TabIndex = 6;
            this.groupRb.TabStop = false;
            this.groupRb.Text = "OPÇÕES";
            // 
            // rbOs
            // 
            this.rbOs.AutoSize = true;
            this.rbOs.Location = new System.Drawing.Point(164, 20);
            this.rbOs.Name = "rbOs";
            this.rbOs.Size = new System.Drawing.Size(43, 17);
            this.rbOs.TabIndex = 9;
            this.rbOs.Text = "O.S";
            this.rbOs.UseVisualStyleBackColor = true;
            this.rbOs.CheckedChanged += new System.EventHandler(this.eventoRbOs);
            // 
            // rbEtiq
            // 
            this.rbEtiq.AutoSize = true;
            this.rbEtiq.Location = new System.Drawing.Point(91, 20);
            this.rbEtiq.Name = "rbEtiq";
            this.rbEtiq.Size = new System.Drawing.Size(64, 17);
            this.rbEtiq.TabIndex = 8;
            this.rbEtiq.Text = "Etiqueta";
            this.rbEtiq.UseVisualStyleBackColor = true;
            this.rbEtiq.CheckedChanged += new System.EventHandler(this.eventoRbEtiq);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(19, 20);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(57, 17);
            this.rbCliente.TabIndex = 7;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.eventoRbCli);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 40;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "CLIENTE";
            this.cliente.Name = "cliente";
            this.cliente.Width = 300;
            // 
            // etiqueta
            // 
            this.etiqueta.HeaderText = "ETIQUETA";
            this.etiqueta.Name = "etiqueta";
            this.etiqueta.Width = 300;
            // 
            // os
            // 
            this.os.HeaderText = "O.S";
            this.os.Name = "os";
            this.os.Width = 70;
            // 
            // obs
            // 
            this.obs.HeaderText = "OBS";
            this.obs.Name = "obs";
            this.obs.Width = 300;
            // 
            // btNovaArte
            // 
            this.btNovaArte.Location = new System.Drawing.Point(13, 393);
            this.btNovaArte.Name = "btNovaArte";
            this.btNovaArte.Size = new System.Drawing.Size(75, 46);
            this.btNovaArte.TabIndex = 2;
            this.btNovaArte.Text = "NOVA ARTE";
            this.btNovaArte.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "NOVO POLIMERO";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "DUPLICAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(256, 393);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 46);
            this.btSair.TabIndex = 2;
            this.btSair.Text = "SAIR";
            this.btSair.UseVisualStyleBackColor = true;
            // 
            // rbTudo
            // 
            this.rbTudo.AutoSize = true;
            this.rbTudo.Checked = true;
            this.rbTudo.Location = new System.Drawing.Point(217, 20);
            this.rbTudo.Name = "rbTudo";
            this.rbTudo.Size = new System.Drawing.Size(50, 17);
            this.rbTudo.TabIndex = 10;
            this.rbTudo.TabStop = true;
            this.rbTudo.Text = "Tudo";
            this.rbTudo.UseVisualStyleBackColor = true;
            this.rbTudo.CheckedChanged += new System.EventHandler(this.eventoRbTudo);
            // 
            // FrmBuscaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 451);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btNovaArte);
            this.Controls.Add(this.dtListPedidos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBuscaPedido";
            this.Text = "Buscar Pedido";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListPedidos)).EndInit();
            this.groupRb.ResumeLayout(false);
            this.groupRb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCampoBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DataGridView dtListPedidos;
        private System.Windows.Forms.GroupBox groupRb;
        private System.Windows.Forms.RadioButton rbOs;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbEtiq;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn etiqueta;
        private System.Windows.Forms.DataGridViewTextBoxColumn os;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.RadioButton rbTudo;
        private System.Windows.Forms.Button btNovaArte;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btSair;
    }
}
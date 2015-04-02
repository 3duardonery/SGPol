namespace SGPol
{
    partial class FrmListArte
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtListArte = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_elab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListArte)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtListArte);
            this.panel1.Location = new System.Drawing.Point(13, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 302);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 66);
            this.panel2.TabIndex = 1;
            // 
            // dtListArte
            // 
            this.dtListArte.AllowUserToAddRows = false;
            this.dtListArte.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtListArte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListArte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome_cliente,
            this.prazo,
            this.data_elab,
            this.prioridade,
            this.status,
            this.obs,
            this.id_pedido});
            this.dtListArte.Location = new System.Drawing.Point(13, 10);
            this.dtListArte.Name = "dtListArte";
            this.dtListArte.Size = new System.Drawing.Size(851, 287);
            this.dtListArte.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID ARTE";
            this.id.Name = "id";
            this.id.Width = 40;
            // 
            // nome_cliente
            // 
            this.nome_cliente.HeaderText = "CLIENTE";
            this.nome_cliente.Name = "nome_cliente";
            this.nome_cliente.Width = 300;
            // 
            // prazo
            // 
            this.prazo.HeaderText = "PRAZO ARTE";
            this.prazo.Name = "prazo";
            // 
            // data_elab
            // 
            this.data_elab.HeaderText = "DATA ELABORAÇÃO";
            this.data_elab.Name = "data_elab";
            // 
            // prioridade
            // 
            this.prioridade.HeaderText = "PRIORIDADE";
            this.prioridade.Name = "prioridade";
            this.prioridade.Width = 80;
            // 
            // status
            // 
            this.status.HeaderText = "STATUS";
            this.status.Name = "status";
            // 
            // obs
            // 
            this.obs.HeaderText = "OBS";
            this.obs.Name = "obs";
            this.obs.Width = 300;
            // 
            // id_pedido
            // 
            this.id_pedido.HeaderText = "ID PEDIDO";
            this.id_pedido.Name = "id_pedido";
            this.id_pedido.Width = 40;
            // 
            // FrmListArte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 464);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmListArte";
            this.Text = "Lista de Artes";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtListArte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtListArte;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn prazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_elab;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pedido;
    }
}
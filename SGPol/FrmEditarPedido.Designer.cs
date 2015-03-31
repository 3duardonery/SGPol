namespace SGPol
{
    partial class FrmEditarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarPedido));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtGridPedidos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etiqueta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.os = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEtiqueta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIdPedido);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtObs);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtOs);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEtiqueta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 191);
            this.panel1.TabIndex = 0;
            // 
            // dtGridPedidos
            // 
            this.dtGridPedidos.AllowUserToAddRows = false;
            this.dtGridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cliente,
            this.etiqueta,
            this.os,
            this.obs});
            this.dtGridPedidos.Location = new System.Drawing.Point(13, 13);
            this.dtGridPedidos.Name = "dtGridPedidos";
            this.dtGridPedidos.Size = new System.Drawing.Size(849, 273);
            this.dtGridPedidos.TabIndex = 1;
            this.dtGridPedidos.SelectionChanged += new System.EventHandler(this.carregaCampos);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 30;
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
            this.os.HeaderText = "OS";
            this.os.Name = "os";
            this.os.Width = 80;
            // 
            // obs
            // 
            this.obs.HeaderText = "OBS";
            this.obs.Name = "obs";
            this.obs.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME DO CLIENTE :";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(17, 35);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(326, 20);
            this.txtCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MODELO DA ETIQUETA :";
            // 
            // txtEtiqueta
            // 
            this.txtEtiqueta.Location = new System.Drawing.Point(17, 104);
            this.txtEtiqueta.Name = "txtEtiqueta";
            this.txtEtiqueta.Size = new System.Drawing.Size(326, 20);
            this.txtEtiqueta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NUMERO DA OS :";
            // 
            // txtOs
            // 
            this.txtOs.Location = new System.Drawing.Point(414, 35);
            this.txtOs.Name = "txtOs";
            this.txtOs.Size = new System.Drawing.Size(149, 20);
            this.txtOs.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "OBSERVAÇÕES :";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(414, 104);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(311, 73);
            this.txtObs.TabIndex = 7;
            this.txtObs.Text = "";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(13, 499);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(91, 52);
            this.btSalvar.TabIndex = 2;
            this.btSalvar.Text = "SALVAR EDIÇÕES";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "CODIGO DO PEDIDO :";
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Enabled = false;
            this.txtIdPedido.Location = new System.Drawing.Point(17, 161);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(100, 20);
            this.txtIdPedido.TabIndex = 9;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(121, 499);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 52);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "button1";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // FrmEditarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 558);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.dtGridPedidos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditarPedido";
            this.Text = "Editar Pedido";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtGridPedidos;
        private System.Windows.Forms.RichTextBox txtObs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEtiqueta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn etiqueta;
        private System.Windows.Forms.DataGridViewTextBoxColumn os;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancel;
    }
}
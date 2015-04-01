namespace SGPol
{
    partial class FrmExcluirPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExcluirPedido));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btExcluir = new System.Windows.Forms.Button();
            this.gridListPedidos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etiqueta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.os = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbOs = new System.Windows.Forms.Label();
            this.lbEtiqueta = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbObs = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListPedidos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.gridListPedidos);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(823, 489);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btExcluir);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 57);
            this.panel2.TabIndex = 2;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(8, 6);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(109, 43);
            this.btExcluir.TabIndex = 0;
            this.btExcluir.Text = "EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // gridListPedidos
            // 
            this.gridListPedidos.AllowUserToAddRows = false;
            this.gridListPedidos.AllowUserToOrderColumns = true;
            this.gridListPedidos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridListPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cliente,
            this.etiqueta,
            this.os,
            this.obs});
            this.gridListPedidos.Location = new System.Drawing.Point(3, 66);
            this.gridListPedidos.MultiSelect = false;
            this.gridListPedidos.Name = "gridListPedidos";
            this.gridListPedidos.Size = new System.Drawing.Size(820, 218);
            this.gridListPedidos.TabIndex = 0;
            this.gridListPedidos.SelectionChanged += new System.EventHandler(this.carregaInfPedido);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbOs);
            this.panel1.Controls.Add(this.lbEtiqueta);
            this.panel1.Controls.Add(this.lbNome);
            this.panel1.Controls.Add(this.lbId);
            this.panel1.Controls.Add(this.lbObs);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 242);
            this.panel1.TabIndex = 1;
            // 
            // lbOs
            // 
            this.lbOs.AutoSize = true;
            this.lbOs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOs.Location = new System.Drawing.Point(387, 48);
            this.lbOs.Name = "lbOs";
            this.lbOs.Size = new System.Drawing.Size(23, 15);
            this.lbOs.TabIndex = 9;
            this.lbOs.Text = "....";
            // 
            // lbEtiqueta
            // 
            this.lbEtiqueta.AutoSize = true;
            this.lbEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEtiqueta.Location = new System.Drawing.Point(17, 158);
            this.lbEtiqueta.Name = "lbEtiqueta";
            this.lbEtiqueta.Size = new System.Drawing.Size(23, 15);
            this.lbEtiqueta.TabIndex = 8;
            this.lbEtiqueta.Text = "....";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(17, 106);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(23, 15);
            this.lbNome.TabIndex = 7;
            this.lbNome.Text = "....";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(17, 48);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(23, 15);
            this.lbId.TabIndex = 6;
            this.lbId.Text = "....";
            // 
            // lbObs
            // 
            this.lbObs.AutoSize = true;
            this.lbObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObs.Location = new System.Drawing.Point(387, 106);
            this.lbObs.Name = "lbObs";
            this.lbObs.Size = new System.Drawing.Size(23, 15);
            this.lbObs.TabIndex = 5;
            this.lbObs.Text = "....";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "OBSERVAÇÕES :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "NUMERO DA OS :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MODELO DA ETIQUETA :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOME DO CLIENTE :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID DO PEDIDO :";
            // 
            // FrmExcluirPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 489);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmExcluirPedido";
            this.Text = "Excluir Pedido";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridListPedidos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView gridListPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn etiqueta;
        private System.Windows.Forms.DataGridViewTextBoxColumn os;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbOs;
        private System.Windows.Forms.Label lbEtiqueta;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbObs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btExcluir;
    }
}
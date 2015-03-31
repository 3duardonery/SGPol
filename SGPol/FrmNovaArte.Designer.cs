namespace SGPol
{
    partial class FrmNovaArte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNovaArte));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbOpcStatus = new System.Windows.Forms.ComboBox();
            this.cbOpcPri = new System.Windows.Forms.ComboBox();
            this.chkCampoDt = new System.Windows.Forms.CheckBox();
            this.txtDtElab = new System.Windows.Forms.MaskedTextBox();
            this.txtPrazo = new System.Windows.Forms.MaskedTextBox();
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btSelect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbOs = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbEtiqueta = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbIdPedido = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCadArte = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.cbOpcStatus);
            this.panel1.Controls.Add(this.cbOpcPri);
            this.panel1.Controls.Add(this.chkCampoDt);
            this.panel1.Controls.Add(this.txtDtElab);
            this.panel1.Controls.Add(this.txtPrazo);
            this.panel1.Controls.Add(this.txtObs);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btSelect);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 362);
            this.panel1.TabIndex = 0;
            // 
            // cbOpcStatus
            // 
            this.cbOpcStatus.FormattingEnabled = true;
            this.cbOpcStatus.Items.AddRange(new object[] {
            "ABERTO",
            "FABRICAÇÃO",
            "CONCLUIDO",
            "REFAZER"});
            this.cbOpcStatus.Location = new System.Drawing.Point(132, 170);
            this.cbOpcStatus.Name = "cbOpcStatus";
            this.cbOpcStatus.Size = new System.Drawing.Size(89, 21);
            this.cbOpcStatus.TabIndex = 13;
            // 
            // cbOpcPri
            // 
            this.cbOpcPri.FormattingEnabled = true;
            this.cbOpcPri.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbOpcPri.Location = new System.Drawing.Point(133, 135);
            this.cbOpcPri.Name = "cbOpcPri";
            this.cbOpcPri.Size = new System.Drawing.Size(89, 21);
            this.cbOpcPri.TabIndex = 13;
            // 
            // chkCampoDt
            // 
            this.chkCampoDt.AutoSize = true;
            this.chkCampoDt.Location = new System.Drawing.Point(205, 93);
            this.chkCampoDt.Name = "chkCampoDt";
            this.chkCampoDt.Size = new System.Drawing.Size(91, 17);
            this.chkCampoDt.TabIndex = 12;
            this.chkCampoDt.Text = "Ativar campo ";
            this.chkCampoDt.UseVisualStyleBackColor = true;
            this.chkCampoDt.CheckedChanged += new System.EventHandler(this.AtivaDtElaboracao);
            // 
            // txtDtElab
            // 
            this.txtDtElab.Culture = new System.Globalization.CultureInfo("");
            this.txtDtElab.Enabled = false;
            this.txtDtElab.Location = new System.Drawing.Point(126, 91);
            this.txtDtElab.Mask = "00/00/0000";
            this.txtDtElab.Name = "txtDtElab";
            this.txtDtElab.Size = new System.Drawing.Size(73, 20);
            this.txtDtElab.TabIndex = 11;
            this.txtDtElab.ValidatingType = typeof(System.DateTime);
            // 
            // txtPrazo
            // 
            this.txtPrazo.Location = new System.Drawing.Point(126, 51);
            this.txtPrazo.Mask = "00/00/0000";
            this.txtPrazo.Name = "txtPrazo";
            this.txtPrazo.Size = new System.Drawing.Size(73, 20);
            this.txtPrazo.TabIndex = 10;
            this.txtPrazo.ValidatingType = typeof(System.DateTime);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(22, 241);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(316, 96);
            this.txtObs.TabIndex = 9;
            this.txtObs.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Observações : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Status :";
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(146, 8);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(137, 23);
            this.btSelect.TabIndex = 6;
            this.btSelect.Text = "SELECIONAR";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(358, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dados do Pedido :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbOs);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.lbEtiqueta);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lbCliente);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lbIdPedido);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(361, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 208);
            this.panel2.TabIndex = 4;
            // 
            // lbOs
            // 
            this.lbOs.AutoSize = true;
            this.lbOs.Location = new System.Drawing.Point(4, 172);
            this.lbOs.Name = "lbOs";
            this.lbOs.Size = new System.Drawing.Size(28, 13);
            this.lbOs.TabIndex = 2;
            this.lbOs.Text = ".......";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "NUMERO DA OS :";
            // 
            // lbEtiqueta
            // 
            this.lbEtiqueta.AutoSize = true;
            this.lbEtiqueta.Location = new System.Drawing.Point(3, 129);
            this.lbEtiqueta.Name = "lbEtiqueta";
            this.lbEtiqueta.Size = new System.Drawing.Size(28, 13);
            this.lbEtiqueta.TabIndex = 2;
            this.lbEtiqueta.Text = ".......";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "MODELO ETIQUETA : ";
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(3, 88);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(28, 13);
            this.lbCliente.TabIndex = 2;
            this.lbCliente.Text = ".......";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "CLIENTE : ";
            // 
            // lbIdPedido
            // 
            this.lbIdPedido.AutoSize = true;
            this.lbIdPedido.Location = new System.Drawing.Point(3, 30);
            this.lbIdPedido.Name = "lbIdPedido";
            this.lbIdPedido.Size = new System.Drawing.Size(28, 13);
            this.lbIdPedido.TabIndex = 1;
            this.lbIdPedido.Text = ".......";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID PEDIDO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prioridade :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Elaboração :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prazo : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o pedido :";
            // 
            // btCadArte
            // 
            this.btCadArte.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btCadArte.Location = new System.Drawing.Point(12, 381);
            this.btCadArte.Name = "btCadArte";
            this.btCadArte.Size = new System.Drawing.Size(99, 54);
            this.btCadArte.TabIndex = 1;
            this.btCadArte.Text = "CADASTRAR ARTE";
            this.btCadArte.UseVisualStyleBackColor = false;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btCancel.Location = new System.Drawing.Point(137, 381);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(99, 54);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "CANCELAR";
            this.btCancel.UseVisualStyleBackColor = false;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btLimpar.Location = new System.Drawing.Point(261, 381);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(99, 54);
            this.btLimpar.TabIndex = 1;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = false;
            // 
            // FrmNovaArte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(701, 447);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCadArte);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNovaArte";
            this.Text = "Nova Arte";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOpcStatus;
        private System.Windows.Forms.ComboBox cbOpcPri;
        private System.Windows.Forms.CheckBox chkCampoDt;
        private System.Windows.Forms.MaskedTextBox txtDtElab;
        private System.Windows.Forms.MaskedTextBox txtPrazo;
        private System.Windows.Forms.RichTextBox txtObs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btCadArte;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btLimpar;
        public  System.Windows.Forms.Label lbOs;
        public  System.Windows.Forms.Label lbEtiqueta;
        public  System.Windows.Forms.Label lbCliente;
        public  System.Windows.Forms.Label lbIdPedido;
        public System.Windows.Forms.Button btSelect;
    }
}
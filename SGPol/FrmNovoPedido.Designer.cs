﻿namespace SGPol
{
    partial class FrmNovoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNovoPedido));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOs = new System.Windows.Forms.TextBox();
            this.txtModeloEti = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCad = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtObs);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtOs);
            this.panel1.Controls.Add(this.txtModeloEti);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 335);
            this.panel1.TabIndex = 0;
            // 
            // txtOs
            // 
            this.txtOs.Location = new System.Drawing.Point(155, 147);
            this.txtOs.Name = "txtOs";
            this.txtOs.Size = new System.Drawing.Size(117, 20);
            this.txtOs.TabIndex = 3;
            // 
            // txtModeloEti
            // 
            this.txtModeloEti.Location = new System.Drawing.Point(155, 109);
            this.txtModeloEti.Name = "txtModeloEti";
            this.txtModeloEti.Size = new System.Drawing.Size(254, 20);
            this.txtModeloEti.TabIndex = 2;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(155, 68);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(331, 20);
            this.txtCliente.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(155, 31);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(71, 20);
            this.txtId.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "OS : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MODELO DA ETIQUETA :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CLIENTE :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // btCad
            // 
            this.btCad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btCad.Location = new System.Drawing.Point(5, 382);
            this.btCad.Name = "btCad";
            this.btCad.Size = new System.Drawing.Size(89, 49);
            this.btCad.TabIndex = 6;
            this.btCad.Text = "SALVAR PEDIDO";
            this.btCad.UseVisualStyleBackColor = false;
            this.btCad.Click += new System.EventHandler(this.btCad_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btCancel.Location = new System.Drawing.Point(102, 382);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(89, 49);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "CANCELAR";
            this.btCancel.UseVisualStyleBackColor = false;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btLimpar.Location = new System.Drawing.Point(197, 382);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(89, 49);
            this.btLimpar.TabIndex = 8;
            this.btLimpar.Text = "LIMPAR CAMPOS";
            this.btLimpar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Observações :";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(76, 204);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(477, 96);
            this.txtObs.TabIndex = 8;
            this.txtObs.Text = "";
            // 
            // FrmNovoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(595, 443);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCad);
            this.Controls.Add(this.btCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNovoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Pedido";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtOs;
        private System.Windows.Forms.TextBox txtModeloEti;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCad;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.RichTextBox txtObs;
        private System.Windows.Forms.Label label5;

    }
}
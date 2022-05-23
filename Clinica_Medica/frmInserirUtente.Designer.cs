
using System;

namespace Clinica_Medica
{
    partial class frmInserirUtente
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUtente = new System.Windows.Forms.TextBox();
            this.tbMorada = new System.Windows.Forms.TextBox();
            this.dtpDN = new System.Windows.Forms.DateTimePicker();
            this.tbContato = new System.Windows.Forms.TextBox();
            this.tbNif = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNome.Location = new System.Drawing.Point(60, 65);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(395, 31);
            this.tbNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(479, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "NIF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(479, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(60, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data de Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(60, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Morada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(479, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nº Utente";
            // 
            // tbUtente
            // 
            this.tbUtente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUtente.Location = new System.Drawing.Point(479, 65);
            this.tbUtente.MaxLength = 9;
            this.tbUtente.Name = "tbUtente";
            this.tbUtente.Size = new System.Drawing.Size(127, 31);
            this.tbUtente.TabIndex = 7;
            // 
            // tbMorada
            // 
            this.tbMorada.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMorada.Location = new System.Drawing.Point(60, 196);
            this.tbMorada.Name = "tbMorada";
            this.tbMorada.Size = new System.Drawing.Size(359, 31);
            this.tbMorada.TabIndex = 8;
            // 
            // dtpDN
            // 
            this.dtpDN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDN.Location = new System.Drawing.Point(60, 134);
            this.dtpDN.Name = "dtpDN";
            this.dtpDN.Size = new System.Drawing.Size(359, 31);
            this.dtpDN.TabIndex = 10;
            this.dtpDN.ValueChanged += new System.EventHandler(this.dtpDN_ValueChanged);
            // 
            // tbContato
            // 
            this.tbContato.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbContato.Location = new System.Drawing.Point(479, 137);
            this.tbContato.Name = "tbContato";
            this.tbContato.Size = new System.Drawing.Size(127, 31);
            this.tbContato.TabIndex = 11;
            // 
            // tbNif
            // 
            this.tbNif.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNif.Location = new System.Drawing.Point(479, 196);
            this.tbNif.Name = "tbNif";
            this.tbNif.Size = new System.Drawing.Size(127, 31);
            this.tbNif.TabIndex = 12;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInserir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInserir.Location = new System.Drawing.Point(180, 253);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(109, 56);
            this.btnInserir.TabIndex = 13;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(346, 253);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 56);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmInserirUtente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(675, 354);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.tbNif);
            this.Controls.Add(this.tbContato);
            this.Controls.Add(this.dtpDN);
            this.Controls.Add(this.tbMorada);
            this.Controls.Add(this.tbUtente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label1);
            this.Name = "frmInserirUtente";
            this.Text = "Inserir Utente";
            this.Load += new System.EventHandler(this.frmInserirUtente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUtente;
        private System.Windows.Forms.TextBox tbMorada;
        private System.Windows.Forms.DateTimePicker dtpDN;
        private System.Windows.Forms.TextBox tbContato;
        private System.Windows.Forms.TextBox tbNif;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnCancelar;
    }
}

namespace Clinica_Medica
{
    partial class frmConsultarConsulta
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
            this.btnEliminarCons = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dTPDtConsulta = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgvVerCons = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUtente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerCons)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarCons
            // 
            this.btnEliminarCons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminarCons.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarCons.Location = new System.Drawing.Point(26, 382);
            this.btnEliminarCons.Name = "btnEliminarCons";
            this.btnEliminarCons.Size = new System.Drawing.Size(198, 56);
            this.btnEliminarCons.TabIndex = 35;
            this.btnEliminarCons.Text = "Cancelar Consulta";
            this.btnEliminarCons.UseVisualStyleBackColor = false;
            this.btnEliminarCons.Click += new System.EventHandler(this.btnEliminarCons_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.Location = new System.Drawing.Point(666, 385);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(109, 56);
            this.btnFechar.TabIndex = 33;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dTPDtConsulta
            // 
            this.dTPDtConsulta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dTPDtConsulta.Location = new System.Drawing.Point(356, 33);
            this.dTPDtConsulta.Name = "dTPDtConsulta";
            this.dTPDtConsulta.Size = new System.Drawing.Size(250, 27);
            this.dTPDtConsulta.TabIndex = 31;
            this.dTPDtConsulta.ValueChanged += new System.EventHandler(this.dTPDtConsulta_ValueChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiltrar.Location = new System.Drawing.Point(666, 16);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(109, 50);
            this.btnFiltrar.TabIndex = 30;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dgvVerCons
            // 
            this.dgvVerCons.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvVerCons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerCons.Location = new System.Drawing.Point(26, 108);
            this.dgvVerCons.Name = "dgvVerCons";
            this.dgvVerCons.RowTemplate.Height = 25;
            this.dgvVerCons.Size = new System.Drawing.Size(749, 265);
            this.dgvVerCons.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Utente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(356, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Data da Consulta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Consultas";
            // 
            // cbUtente
            // 
            this.cbUtente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUtente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbUtente.FormattingEnabled = true;
            this.cbUtente.Location = new System.Drawing.Point(26, 33);
            this.cbUtente.Name = "cbUtente";
            this.cbUtente.Size = new System.Drawing.Size(311, 29);
            this.cbUtente.TabIndex = 36;
            this.cbUtente.SelectedIndexChanged += new System.EventHandler(this.cbUtente_SelectedIndexChanged);
            // 
            // frmConsultarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbUtente);
            this.Controls.Add(this.btnEliminarCons);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dTPDtConsulta);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dgvVerCons);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultarConsulta";
            this.Text = "Pesquisar Consulta Marcada";
            this.Load += new System.EventHandler(this.frmConsultarConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerCons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarCons;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DateTimePicker dTPDtConsulta;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dgvVerCons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUtente;
    }
}
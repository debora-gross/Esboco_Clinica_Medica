
namespace Clinica_Medica
{
    partial class frmInserirConsulta
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
            this.cbUtente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lbDtNasc = new System.Windows.Forms.Label();
            this.lbContato = new System.Windows.Forms.Label();
            this.lbUtente = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.cbMedico = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEspecialidade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbHora = new System.Windows.Forms.ComboBox();
            this.dTPdtConsulta = new System.Windows.Forms.DateTimePicker();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbUtente
            // 
            this.cbUtente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUtente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbUtente.FormattingEnabled = true;
            this.cbUtente.Location = new System.Drawing.Point(25, 49);
            this.cbUtente.Name = "cbUtente";
            this.cbUtente.Size = new System.Drawing.Size(295, 29);
            this.cbUtente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Utente";
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVerificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerificar.Location = new System.Drawing.Point(352, 38);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(98, 40);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lbDtNasc
            // 
            this.lbDtNasc.AutoSize = true;
            this.lbDtNasc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDtNasc.Location = new System.Drawing.Point(352, 81);
            this.lbDtNasc.Name = "lbDtNasc";
            this.lbDtNasc.Size = new System.Drawing.Size(143, 19);
            this.lbDtNasc.TabIndex = 21;
            this.lbDtNasc.Text = "Data Nascimento";
            // 
            // lbContato
            // 
            this.lbContato.AutoSize = true;
            this.lbContato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbContato.Location = new System.Drawing.Point(542, 81);
            this.lbContato.Name = "lbContato";
            this.lbContato.Size = new System.Drawing.Size(70, 19);
            this.lbContato.TabIndex = 20;
            this.lbContato.Text = "Contato";
            // 
            // lbUtente
            // 
            this.lbUtente.AutoSize = true;
            this.lbUtente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUtente.Location = new System.Drawing.Point(219, 81);
            this.lbUtente.Name = "lbUtente";
            this.lbUtente.Size = new System.Drawing.Size(57, 19);
            this.lbUtente.TabIndex = 18;
            this.lbUtente.Text = "Utente";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNome.Location = new System.Drawing.Point(29, 81);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(134, 19);
            this.lbNome.TabIndex = 17;
            this.lbNome.Text = "Nome do Utente";
            // 
            // cbMedico
            // 
            this.cbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMedico.FormattingEnabled = true;
            this.cbMedico.Location = new System.Drawing.Point(352, 159);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(307, 29);
            this.cbMedico.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(352, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Medico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Especialidade";
            // 
            // cbEspecialidade
            // 
            this.cbEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecialidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbEspecialidade.FormattingEnabled = true;
            this.cbEspecialidade.Location = new System.Drawing.Point(28, 159);
            this.cbEspecialidade.Name = "cbEspecialidade";
            this.cbEspecialidade.Size = new System.Drawing.Size(292, 29);
            this.cbEspecialidade.TabIndex = 24;
            this.cbEspecialidade.SelectedIndexChanged += new System.EventHandler(this.cbEspecialidade_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(352, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "Horário";
            // 
            // cbHora
            // 
            this.cbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHora.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbHora.FormattingEnabled = true;
            this.cbHora.Items.AddRange(new object[] {
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30"});
            this.cbHora.Location = new System.Drawing.Point(352, 229);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(114, 29);
            this.cbHora.TabIndex = 28;
            // 
            // dTPdtConsulta
            // 
            this.dTPdtConsulta.CustomFormat = " ";
            this.dTPdtConsulta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dTPdtConsulta.Location = new System.Drawing.Point(29, 231);
            this.dTPdtConsulta.Name = "dTPdtConsulta";
            this.dTPdtConsulta.Size = new System.Drawing.Size(271, 27);
            this.dTPdtConsulta.TabIndex = 30;
            this.dTPdtConsulta.ValueChanged += new System.EventHandler(this.dTPdtConsulta_ValueChanged);
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgendar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgendar.Location = new System.Drawing.Point(123, 276);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(109, 56);
            this.btnAgendar.TabIndex = 31;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(403, 276);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 56);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmInserirConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(708, 354);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.dTPdtConsulta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbHora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbEspecialidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMedico);
            this.Controls.Add(this.lbDtNasc);
            this.Controls.Add(this.lbContato);
            this.Controls.Add(this.lbUtente);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbUtente);
            this.Name = "frmInserirConsulta";
            this.Text = "Inserir Nova Consulta";
            this.Load += new System.EventHandler(this.frmInserirConsulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUtente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lbDtNasc;
        private System.Windows.Forms.Label lbContato;
        private System.Windows.Forms.Label lbUtente;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.ComboBox cbMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEspecialidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbHora;
        private System.Windows.Forms.DateTimePicker dTPdtConsulta;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
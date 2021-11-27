
namespace caixa
{
    partial class Principal
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.tbxMotivo = new System.Windows.Forms.TextBox();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 58);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(33, 15);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // tbxMotivo
            // 
            this.tbxMotivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxMotivo.Location = new System.Drawing.Point(12, 194);
            this.tbxMotivo.Multiline = true;
            this.tbxMotivo.Name = "tbxMotivo";
            this.tbxMotivo.Size = new System.Drawing.Size(292, 63);
            this.tbxMotivo.TabIndex = 1;
            // 
            // tbxValor
            // 
            this.tbxValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxValor.Location = new System.Drawing.Point(12, 134);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(292, 16);
            this.tbxValor.TabIndex = 4;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGravar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGravar.Location = new System.Drawing.Point(12, 263);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(168, 55);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // dtpData
            // 
            this.dtpData.Enabled = false;
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(227, 12);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(78, 23);
            this.dtpData.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor:";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(12, 176);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(48, 15);
            this.lblMotivo.TabIndex = 0;
            this.lblMotivo.Text = "Motivo:";
            // 
            // cbxTipo
            // 
            this.cbxTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Entrada",
            "Saida"});
            this.cbxTipo.Location = new System.Drawing.Point(13, 77);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(292, 23);
            this.cbxTipo.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(186, 263);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 55);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.Green;
            this.btnStatus.ForeColor = System.Drawing.Color.White;
            this.btnStatus.Location = new System.Drawing.Point(101, 12);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(111, 35);
            this.btnStatus.TabIndex = 9;
            this.btnStatus.Text = "Aberto";
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Status do Caixa:";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.tbxMotivo);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox tbxMotivo;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Label label1;
    }
}
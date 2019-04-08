namespace BolnicaApp.Forme
{
    partial class FrmRezervacijaPregleda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRezervacijaPregleda));
            this.gpPovijestBolesti = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.cbVrstaPregleda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.cbPacijenti = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpPovijestBolesti.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpPovijestBolesti
            // 
            this.gpPovijestBolesti.BackColor = System.Drawing.Color.Transparent;
            this.gpPovijestBolesti.Controls.Add(this.button1);
            this.gpPovijestBolesti.Controls.Add(this.label3);
            this.gpPovijestBolesti.Controls.Add(this.txtOpis);
            this.gpPovijestBolesti.Controls.Add(this.cbVrstaPregleda);
            this.gpPovijestBolesti.Controls.Add(this.label2);
            this.gpPovijestBolesti.Controls.Add(this.dtpDatum);
            this.gpPovijestBolesti.Controls.Add(this.label4);
            this.gpPovijestBolesti.Controls.Add(this.btnNatrag);
            this.gpPovijestBolesti.Controls.Add(this.cbPacijenti);
            this.gpPovijestBolesti.Controls.Add(this.label1);
            this.gpPovijestBolesti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gpPovijestBolesti.Location = new System.Drawing.Point(12, 12);
            this.gpPovijestBolesti.Name = "gpPovijestBolesti";
            this.gpPovijestBolesti.Size = new System.Drawing.Size(240, 459);
            this.gpPovijestBolesti.TabIndex = 6;
            this.gpPovijestBolesti.TabStop = false;
            this.gpPovijestBolesti.Text = "Rezerviranje pregleda:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(112, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 42);
            this.button1.TabIndex = 22;
            this.button1.Text = "Rezerviraj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(9, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Opis pregleda:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(13, 231);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(210, 174);
            this.txtOpis.TabIndex = 20;
            // 
            // cbVrstaPregleda
            // 
            this.cbVrstaPregleda.FormattingEnabled = true;
            this.cbVrstaPregleda.Location = new System.Drawing.Point(12, 110);
            this.cbVrstaPregleda.Name = "cbVrstaPregleda";
            this.cbVrstaPregleda.Size = new System.Drawing.Size(211, 21);
            this.cbVrstaPregleda.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Vrsta pregleda:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(12, 172);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(211, 20);
            this.dtpDatum.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(9, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Datum pregleda:";
            // 
            // btnNatrag
            // 
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.Location = new System.Drawing.Point(13, 430);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 23);
            this.btnNatrag.TabIndex = 13;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // cbPacijenti
            // 
            this.cbPacijenti.FormattingEnabled = true;
            this.cbPacijenti.Location = new System.Drawing.Point(12, 48);
            this.cbPacijenti.Name = "cbPacijenti";
            this.cbPacijenti.Size = new System.Drawing.Size(211, 21);
            this.cbPacijenti.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pacijent:";
            // 
            // FrmRezervacijaPregleda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(268, 473);
            this.Controls.Add(this.gpPovijestBolesti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRezervacijaPregleda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervacija pregleda";
            this.Load += new System.EventHandler(this.FrmRezervacijaPregleda_Load);
            this.gpPovijestBolesti.ResumeLayout(false);
            this.gpPovijestBolesti.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpPovijestBolesti;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.ComboBox cbVrstaPregleda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.ComboBox cbPacijenti;
        private System.Windows.Forms.Label label1;
    }
}
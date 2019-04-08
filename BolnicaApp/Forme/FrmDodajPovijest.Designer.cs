namespace BolnicaApp.Forme
{
    partial class FrmDodajPovijest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodajPovijest));
            this.gpPovijestBolesti = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOpisStanja = new System.Windows.Forms.TextBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnDodajBolestPacijentu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPopisBolesti = new System.Windows.Forms.ListBox();
            this.cbPacijenti = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpPovijestBolesti.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpPovijestBolesti
            // 
            this.gpPovijestBolesti.BackColor = System.Drawing.Color.Transparent;
            this.gpPovijestBolesti.Controls.Add(this.label2);
            this.gpPovijestBolesti.Controls.Add(this.txtOpisStanja);
            this.gpPovijestBolesti.Controls.Add(this.btnNatrag);
            this.gpPovijestBolesti.Controls.Add(this.btnDodajBolestPacijentu);
            this.gpPovijestBolesti.Controls.Add(this.label3);
            this.gpPovijestBolesti.Controls.Add(this.lbPopisBolesti);
            this.gpPovijestBolesti.Controls.Add(this.cbPacijenti);
            this.gpPovijestBolesti.Controls.Add(this.label1);
            this.gpPovijestBolesti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gpPovijestBolesti.Location = new System.Drawing.Point(12, 12);
            this.gpPovijestBolesti.Name = "gpPovijestBolesti";
            this.gpPovijestBolesti.Size = new System.Drawing.Size(499, 327);
            this.gpPovijestBolesti.TabIndex = 5;
            this.gpPovijestBolesti.TabStop = false;
            this.gpPovijestBolesti.Text = "Dodavanje bolesti pacijentu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(275, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Opis stanja bolesti:";
            // 
            // txtOpisStanja
            // 
            this.txtOpisStanja.Location = new System.Drawing.Point(278, 113);
            this.txtOpisStanja.Multiline = true;
            this.txtOpisStanja.Name = "txtOpisStanja";
            this.txtOpisStanja.Size = new System.Drawing.Size(206, 142);
            this.txtOpisStanja.TabIndex = 14;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.Location = new System.Drawing.Point(409, 19);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 23);
            this.btnNatrag.TabIndex = 13;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnDodajBolestPacijentu
            // 
            this.btnDodajBolestPacijentu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajBolestPacijentu.Location = new System.Drawing.Point(323, 275);
            this.btnDodajBolestPacijentu.Name = "btnDodajBolestPacijentu";
            this.btnDodajBolestPacijentu.Size = new System.Drawing.Size(161, 37);
            this.btnDodajBolestPacijentu.TabIndex = 12;
            this.btnDodajBolestPacijentu.Text = "Dodaj bolest pacijentu";
            this.btnDodajBolestPacijentu.UseVisualStyleBackColor = true;
            this.btnDodajBolestPacijentu.Click += new System.EventHandler(this.btnDodajBolestPacijentu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Popis bolesti:";
            // 
            // lbPopisBolesti
            // 
            this.lbPopisBolesti.FormattingEnabled = true;
            this.lbPopisBolesti.Location = new System.Drawing.Point(12, 113);
            this.lbPopisBolesti.Name = "lbPopisBolesti";
            this.lbPopisBolesti.Size = new System.Drawing.Size(211, 199);
            this.lbPopisBolesti.TabIndex = 4;
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
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(35, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // FrmDodajPovijest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(520, 350);
            this.Controls.Add(this.gpPovijestBolesti);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDodajPovijest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj bolest pacijentu";
            this.Load += new System.EventHandler(this.FrmDodajPovijest_Load);
            this.gpPovijestBolesti.ResumeLayout(false);
            this.gpPovijestBolesti.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpPovijestBolesti;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnDodajBolestPacijentu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbPopisBolesti;
        private System.Windows.Forms.ComboBox cbPacijenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOpisStanja;
        private System.Windows.Forms.Label label2;
    }
}
namespace BolnicaApp.Forme
{
    partial class FrmRecepti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecepti));
            this.cbPacijenti = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpIzdavanjeRecepata = new System.Windows.Forms.GroupBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnIzdajRecept = new System.Windows.Forms.Button();
            this.btnVratiSve = new System.Windows.Forms.Button();
            this.btnVratiJedan = new System.Windows.Forms.Button();
            this.btnDodajSve = new System.Windows.Forms.Button();
            this.btnDodajJedan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLijekoviRecept = new System.Windows.Forms.ListBox();
            this.lbPopisLijekova = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatumIzdavanja = new System.Windows.Forms.DateTimePicker();
            this.gpIzdavanjeRecepata.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPacijenti
            // 
            this.cbPacijenti.FormattingEnabled = true;
            this.cbPacijenti.Location = new System.Drawing.Point(12, 48);
            this.cbPacijenti.Name = "cbPacijenti";
            this.cbPacijenti.Size = new System.Drawing.Size(177, 21);
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
            this.groupBox1.Location = new System.Drawing.Point(50, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // gpIzdavanjeRecepata
            // 
            this.gpIzdavanjeRecepata.BackColor = System.Drawing.Color.Transparent;
            this.gpIzdavanjeRecepata.Controls.Add(this.btnNatrag);
            this.gpIzdavanjeRecepata.Controls.Add(this.btnIzdajRecept);
            this.gpIzdavanjeRecepata.Controls.Add(this.btnVratiSve);
            this.gpIzdavanjeRecepata.Controls.Add(this.btnVratiJedan);
            this.gpIzdavanjeRecepata.Controls.Add(this.btnDodajSve);
            this.gpIzdavanjeRecepata.Controls.Add(this.btnDodajJedan);
            this.gpIzdavanjeRecepata.Controls.Add(this.label4);
            this.gpIzdavanjeRecepata.Controls.Add(this.label3);
            this.gpIzdavanjeRecepata.Controls.Add(this.lbLijekoviRecept);
            this.gpIzdavanjeRecepata.Controls.Add(this.lbPopisLijekova);
            this.gpIzdavanjeRecepata.Controls.Add(this.label2);
            this.gpIzdavanjeRecepata.Controls.Add(this.dtpDatumIzdavanja);
            this.gpIzdavanjeRecepata.Controls.Add(this.cbPacijenti);
            this.gpIzdavanjeRecepata.Controls.Add(this.label1);
            this.gpIzdavanjeRecepata.Location = new System.Drawing.Point(27, 25);
            this.gpIzdavanjeRecepata.Name = "gpIzdavanjeRecepata";
            this.gpIzdavanjeRecepata.Size = new System.Drawing.Size(499, 393);
            this.gpIzdavanjeRecepata.TabIndex = 3;
            this.gpIzdavanjeRecepata.TabStop = false;
            this.gpIzdavanjeRecepata.Text = "Izdavanje recepata";
            // 
            // btnNatrag
            // 
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.Location = new System.Drawing.Point(407, 352);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 23);
            this.btnNatrag.TabIndex = 13;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnIzdajRecept
            // 
            this.btnIzdajRecept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzdajRecept.Location = new System.Drawing.Point(194, 336);
            this.btnIzdajRecept.Name = "btnIzdajRecept";
            this.btnIzdajRecept.Size = new System.Drawing.Size(109, 39);
            this.btnIzdajRecept.TabIndex = 12;
            this.btnIzdajRecept.Text = "Izdaj recept";
            this.btnIzdajRecept.UseVisualStyleBackColor = true;
            this.btnIzdajRecept.Click += new System.EventHandler(this.btnIzdajRecept_Click);
            // 
            // btnVratiSve
            // 
            this.btnVratiSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVratiSve.Location = new System.Drawing.Point(220, 242);
            this.btnVratiSve.Name = "btnVratiSve";
            this.btnVratiSve.Size = new System.Drawing.Size(53, 23);
            this.btnVratiSve.TabIndex = 11;
            this.btnVratiSve.Text = "<<";
            this.btnVratiSve.UseVisualStyleBackColor = true;
            this.btnVratiSve.Click += new System.EventHandler(this.btnVratiSve_Click);
            // 
            // btnVratiJedan
            // 
            this.btnVratiJedan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVratiJedan.Location = new System.Drawing.Point(220, 213);
            this.btnVratiJedan.Name = "btnVratiJedan";
            this.btnVratiJedan.Size = new System.Drawing.Size(53, 23);
            this.btnVratiJedan.TabIndex = 10;
            this.btnVratiJedan.Text = "<";
            this.btnVratiJedan.UseVisualStyleBackColor = true;
            this.btnVratiJedan.Click += new System.EventHandler(this.btnVratiJedan_Click);
            // 
            // btnDodajSve
            // 
            this.btnDodajSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajSve.Location = new System.Drawing.Point(220, 184);
            this.btnDodajSve.Name = "btnDodajSve";
            this.btnDodajSve.Size = new System.Drawing.Size(53, 23);
            this.btnDodajSve.TabIndex = 9;
            this.btnDodajSve.Text = ">>";
            this.btnDodajSve.UseVisualStyleBackColor = true;
            this.btnDodajSve.Click += new System.EventHandler(this.btnDodajSve_Click);
            // 
            // btnDodajJedan
            // 
            this.btnDodajJedan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajJedan.Location = new System.Drawing.Point(220, 155);
            this.btnDodajJedan.Name = "btnDodajJedan";
            this.btnDodajJedan.Size = new System.Drawing.Size(53, 23);
            this.btnDodajJedan.TabIndex = 8;
            this.btnDodajJedan.Text = ">";
            this.btnDodajJedan.UseVisualStyleBackColor = true;
            this.btnDodajJedan.Click += new System.EventHandler(this.btnDodajJedan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(302, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lijekovi za izdavanje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Popis lijekova:";
            // 
            // lbLijekoviRecept
            // 
            this.lbLijekoviRecept.FormattingEnabled = true;
            this.lbLijekoviRecept.Location = new System.Drawing.Point(305, 113);
            this.lbLijekoviRecept.Name = "lbLijekoviRecept";
            this.lbLijekoviRecept.Size = new System.Drawing.Size(177, 199);
            this.lbLijekoviRecept.TabIndex = 5;
            // 
            // lbPopisLijekova
            // 
            this.lbPopisLijekova.FormattingEnabled = true;
            this.lbPopisLijekova.Location = new System.Drawing.Point(12, 113);
            this.lbPopisLijekova.Name = "lbPopisLijekova";
            this.lbPopisLijekova.Size = new System.Drawing.Size(177, 199);
            this.lbPopisLijekova.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(302, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum izdavanja:";
            // 
            // dtpDatumIzdavanja
            // 
            this.dtpDatumIzdavanja.Location = new System.Drawing.Point(305, 49);
            this.dtpDatumIzdavanja.Name = "dtpDatumIzdavanja";
            this.dtpDatumIzdavanja.Size = new System.Drawing.Size(177, 20);
            this.dtpDatumIzdavanja.TabIndex = 2;
            // 
            // FrmRecepti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 430);
            this.Controls.Add(this.gpIzdavanjeRecepata);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRecepti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izdavanje recepata";
            this.Load += new System.EventHandler(this.FrmRecepti_Load);
            this.gpIzdavanjeRecepata.ResumeLayout(false);
            this.gpIzdavanjeRecepata.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPacijenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpIzdavanjeRecepata;
        private System.Windows.Forms.Button btnVratiSve;
        private System.Windows.Forms.Button btnVratiJedan;
        private System.Windows.Forms.Button btnDodajSve;
        private System.Windows.Forms.Button btnDodajJedan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbLijekoviRecept;
        private System.Windows.Forms.ListBox lbPopisLijekova;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatumIzdavanja;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnIzdajRecept;
    }
}
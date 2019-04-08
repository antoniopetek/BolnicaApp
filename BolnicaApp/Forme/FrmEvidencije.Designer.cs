namespace BolnicaApp.Forme
{
    partial class FrmEvidencije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEvidencije));
            this.gpVrstaPregleda = new System.Windows.Forms.GroupBox();
            this.dgvVrstePregleda = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisiPregled = new System.Windows.Forms.Button();
            this.btnDodajPregled = new System.Windows.Forms.Button();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.txtNazivPregleda = new System.Windows.Forms.TextBox();
            this.txtIdPregleda = new System.Windows.Forms.TextBox();
            this.gpSpecijalizacija = new System.Windows.Forms.GroupBox();
            this.dgvSpecijalizacija = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnObrisiSpecijalizaciju = new System.Windows.Forms.Button();
            this.btnDodajSpecijalizaciju = new System.Windows.Forms.Button();
            this.txtNazivSpecijalizacije = new System.Windows.Forms.TextBox();
            this.txtIdSpecijalizacije = new System.Windows.Forms.TextBox();
            this.gpTipZaposlenika = new System.Windows.Forms.GroupBox();
            this.dgvTipZaposlenika = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnObrisiTipZaposlenika = new System.Windows.Forms.Button();
            this.btnDodajTipZaposlenika = new System.Windows.Forms.Button();
            this.txtNazivTipa = new System.Windows.Forms.TextBox();
            this.txtIdTip = new System.Windows.Forms.TextBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.gpVrstaPregleda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstePregleda)).BeginInit();
            this.gpSpecijalizacija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecijalizacija)).BeginInit();
            this.gpTipZaposlenika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipZaposlenika)).BeginInit();
            this.SuspendLayout();
            // 
            // gpVrstaPregleda
            // 
            this.gpVrstaPregleda.BackColor = System.Drawing.Color.Transparent;
            this.gpVrstaPregleda.Controls.Add(this.dgvVrstePregleda);
            this.gpVrstaPregleda.Controls.Add(this.label3);
            this.gpVrstaPregleda.Controls.Add(this.label2);
            this.gpVrstaPregleda.Controls.Add(this.label1);
            this.gpVrstaPregleda.Controls.Add(this.btnObrisiPregled);
            this.gpVrstaPregleda.Controls.Add(this.btnDodajPregled);
            this.gpVrstaPregleda.Controls.Add(this.txtTrajanje);
            this.gpVrstaPregleda.Controls.Add(this.txtNazivPregleda);
            this.gpVrstaPregleda.Controls.Add(this.txtIdPregleda);
            this.gpVrstaPregleda.Location = new System.Drawing.Point(12, 23);
            this.gpVrstaPregleda.Name = "gpVrstaPregleda";
            this.gpVrstaPregleda.Size = new System.Drawing.Size(257, 421);
            this.gpVrstaPregleda.TabIndex = 0;
            this.gpVrstaPregleda.TabStop = false;
            this.gpVrstaPregleda.Text = "Vrsta pregleda";
            // 
            // dgvVrstePregleda
            // 
            this.dgvVrstePregleda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVrstePregleda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVrstePregleda.Location = new System.Drawing.Point(6, 210);
            this.dgvVrstePregleda.MultiSelect = false;
            this.dgvVrstePregleda.Name = "dgvVrstePregleda";
            this.dgvVrstePregleda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVrstePregleda.Size = new System.Drawing.Size(240, 173);
            this.dgvVrstePregleda.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trajanje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Naziv pregleda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID pregleda:";
            // 
            // btnObrisiPregled
            // 
            this.btnObrisiPregled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiPregled.Location = new System.Drawing.Point(171, 389);
            this.btnObrisiPregled.Name = "btnObrisiPregled";
            this.btnObrisiPregled.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiPregled.TabIndex = 4;
            this.btnObrisiPregled.Text = "Obriši";
            this.btnObrisiPregled.UseVisualStyleBackColor = true;
            this.btnObrisiPregled.Click += new System.EventHandler(this.btnObrisiPregled_Click);
            // 
            // btnDodajPregled
            // 
            this.btnDodajPregled.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajPregled.Location = new System.Drawing.Point(129, 155);
            this.btnDodajPregled.Name = "btnDodajPregled";
            this.btnDodajPregled.Size = new System.Drawing.Size(100, 32);
            this.btnDodajPregled.TabIndex = 3;
            this.btnDodajPregled.Text = "Dodaj";
            this.btnDodajPregled.UseVisualStyleBackColor = true;
            this.btnDodajPregled.Click += new System.EventHandler(this.btnDodajPregled_Click);
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(103, 120);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(126, 20);
            this.txtTrajanje.TabIndex = 2;
            // 
            // txtNazivPregleda
            // 
            this.txtNazivPregleda.Location = new System.Drawing.Point(103, 84);
            this.txtNazivPregleda.Name = "txtNazivPregleda";
            this.txtNazivPregleda.Size = new System.Drawing.Size(126, 20);
            this.txtNazivPregleda.TabIndex = 1;
            // 
            // txtIdPregleda
            // 
            this.txtIdPregleda.Enabled = false;
            this.txtIdPregleda.Location = new System.Drawing.Point(103, 49);
            this.txtIdPregleda.Name = "txtIdPregleda";
            this.txtIdPregleda.Size = new System.Drawing.Size(126, 20);
            this.txtIdPregleda.TabIndex = 0;
            // 
            // gpSpecijalizacija
            // 
            this.gpSpecijalizacija.BackColor = System.Drawing.Color.Transparent;
            this.gpSpecijalizacija.Controls.Add(this.dgvSpecijalizacija);
            this.gpSpecijalizacija.Controls.Add(this.label5);
            this.gpSpecijalizacija.Controls.Add(this.label6);
            this.gpSpecijalizacija.Controls.Add(this.btnObrisiSpecijalizaciju);
            this.gpSpecijalizacija.Controls.Add(this.btnDodajSpecijalizaciju);
            this.gpSpecijalizacija.Controls.Add(this.txtNazivSpecijalizacije);
            this.gpSpecijalizacija.Controls.Add(this.txtIdSpecijalizacije);
            this.gpSpecijalizacija.Location = new System.Drawing.Point(287, 23);
            this.gpSpecijalizacija.Name = "gpSpecijalizacija";
            this.gpSpecijalizacija.Size = new System.Drawing.Size(257, 419);
            this.gpSpecijalizacija.TabIndex = 1;
            this.gpSpecijalizacija.TabStop = false;
            this.gpSpecijalizacija.Text = "Specijalizacija";
            // 
            // dgvSpecijalizacija
            // 
            this.dgvSpecijalizacija.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSpecijalizacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecijalizacija.Location = new System.Drawing.Point(7, 173);
            this.dgvSpecijalizacija.MultiSelect = false;
            this.dgvSpecijalizacija.Name = "dgvSpecijalizacija";
            this.dgvSpecijalizacija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpecijalizacija.Size = new System.Drawing.Size(240, 210);
            this.dgvSpecijalizacija.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Naziv specijalizacije:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID specijalizacije:";
            // 
            // btnObrisiSpecijalizaciju
            // 
            this.btnObrisiSpecijalizaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiSpecijalizaciju.Location = new System.Drawing.Point(172, 389);
            this.btnObrisiSpecijalizaciju.Name = "btnObrisiSpecijalizaciju";
            this.btnObrisiSpecijalizaciju.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiSpecijalizaciju.TabIndex = 13;
            this.btnObrisiSpecijalizaciju.Text = "Obriši";
            this.btnObrisiSpecijalizaciju.UseVisualStyleBackColor = true;
            this.btnObrisiSpecijalizaciju.Click += new System.EventHandler(this.btnObrisiSpecijalizaciju_Click);
            // 
            // btnDodajSpecijalizaciju
            // 
            this.btnDodajSpecijalizaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajSpecijalizaciju.Location = new System.Drawing.Point(138, 120);
            this.btnDodajSpecijalizaciju.Name = "btnDodajSpecijalizaciju";
            this.btnDodajSpecijalizaciju.Size = new System.Drawing.Size(109, 32);
            this.btnDodajSpecijalizaciju.TabIndex = 12;
            this.btnDodajSpecijalizaciju.Text = "Dodaj";
            this.btnDodajSpecijalizaciju.UseVisualStyleBackColor = true;
            this.btnDodajSpecijalizaciju.Click += new System.EventHandler(this.btnDodajSpecijalizaciju_Click);
            // 
            // txtNazivSpecijalizacije
            // 
            this.txtNazivSpecijalizacije.Location = new System.Drawing.Point(138, 84);
            this.txtNazivSpecijalizacije.Name = "txtNazivSpecijalizacije";
            this.txtNazivSpecijalizacije.Size = new System.Drawing.Size(109, 20);
            this.txtNazivSpecijalizacije.TabIndex = 10;
            // 
            // txtIdSpecijalizacije
            // 
            this.txtIdSpecijalizacije.Enabled = false;
            this.txtIdSpecijalizacije.Location = new System.Drawing.Point(138, 49);
            this.txtIdSpecijalizacije.Name = "txtIdSpecijalizacije";
            this.txtIdSpecijalizacije.Size = new System.Drawing.Size(109, 20);
            this.txtIdSpecijalizacije.TabIndex = 9;
            // 
            // gpTipZaposlenika
            // 
            this.gpTipZaposlenika.BackColor = System.Drawing.Color.Transparent;
            this.gpTipZaposlenika.Controls.Add(this.dgvTipZaposlenika);
            this.gpTipZaposlenika.Controls.Add(this.label4);
            this.gpTipZaposlenika.Controls.Add(this.label7);
            this.gpTipZaposlenika.Controls.Add(this.btnObrisiTipZaposlenika);
            this.gpTipZaposlenika.Controls.Add(this.btnDodajTipZaposlenika);
            this.gpTipZaposlenika.Controls.Add(this.txtNazivTipa);
            this.gpTipZaposlenika.Controls.Add(this.txtIdTip);
            this.gpTipZaposlenika.Location = new System.Drawing.Point(566, 23);
            this.gpTipZaposlenika.Name = "gpTipZaposlenika";
            this.gpTipZaposlenika.Size = new System.Drawing.Size(257, 419);
            this.gpTipZaposlenika.TabIndex = 2;
            this.gpTipZaposlenika.TabStop = false;
            this.gpTipZaposlenika.Text = "Tip zaposlenika";
            // 
            // dgvTipZaposlenika
            // 
            this.dgvTipZaposlenika.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTipZaposlenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipZaposlenika.Location = new System.Drawing.Point(6, 173);
            this.dgvTipZaposlenika.MultiSelect = false;
            this.dgvTipZaposlenika.Name = "dgvTipZaposlenika";
            this.dgvTipZaposlenika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipZaposlenika.Size = new System.Drawing.Size(240, 210);
            this.dgvTipZaposlenika.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tip zaposlenika:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "ID tip:";
            // 
            // btnObrisiTipZaposlenika
            // 
            this.btnObrisiTipZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiTipZaposlenika.Location = new System.Drawing.Point(171, 389);
            this.btnObrisiTipZaposlenika.Name = "btnObrisiTipZaposlenika";
            this.btnObrisiTipZaposlenika.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiTipZaposlenika.TabIndex = 21;
            this.btnObrisiTipZaposlenika.Text = "Obriši";
            this.btnObrisiTipZaposlenika.UseVisualStyleBackColor = true;
            this.btnObrisiTipZaposlenika.Click += new System.EventHandler(this.btnObrisiTipZaposlenika_Click);
            // 
            // btnDodajTipZaposlenika
            // 
            this.btnDodajTipZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajTipZaposlenika.Location = new System.Drawing.Point(129, 120);
            this.btnDodajTipZaposlenika.Name = "btnDodajTipZaposlenika";
            this.btnDodajTipZaposlenika.Size = new System.Drawing.Size(100, 32);
            this.btnDodajTipZaposlenika.TabIndex = 20;
            this.btnDodajTipZaposlenika.Text = "Dodaj";
            this.btnDodajTipZaposlenika.UseVisualStyleBackColor = true;
            this.btnDodajTipZaposlenika.Click += new System.EventHandler(this.btnDodajTipZaposlenika_Click);
            // 
            // txtNazivTipa
            // 
            this.txtNazivTipa.Location = new System.Drawing.Point(112, 84);
            this.txtNazivTipa.Name = "txtNazivTipa";
            this.txtNazivTipa.Size = new System.Drawing.Size(117, 20);
            this.txtNazivTipa.TabIndex = 19;
            // 
            // txtIdTip
            // 
            this.txtIdTip.Enabled = false;
            this.txtIdTip.Location = new System.Drawing.Point(112, 49);
            this.txtIdTip.Name = "txtIdTip";
            this.txtIdTip.Size = new System.Drawing.Size(117, 20);
            this.txtIdTip.TabIndex = 18;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.Location = new System.Drawing.Point(719, 453);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(104, 34);
            this.btnNatrag.TabIndex = 3;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // FrmEvidencije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 493);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.gpTipZaposlenika);
            this.Controls.Add(this.gpSpecijalizacija);
            this.Controls.Add(this.gpVrstaPregleda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEvidencije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencije";
            this.gpVrstaPregleda.ResumeLayout(false);
            this.gpVrstaPregleda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstePregleda)).EndInit();
            this.gpSpecijalizacija.ResumeLayout(false);
            this.gpSpecijalizacija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecijalizacija)).EndInit();
            this.gpTipZaposlenika.ResumeLayout(false);
            this.gpTipZaposlenika.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipZaposlenika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpVrstaPregleda;
        private System.Windows.Forms.GroupBox gpSpecijalizacija;
        private System.Windows.Forms.GroupBox gpTipZaposlenika;
        private System.Windows.Forms.DataGridView dgvVrstePregleda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisiPregled;
        private System.Windows.Forms.Button btnDodajPregled;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.TextBox txtNazivPregleda;
        private System.Windows.Forms.TextBox txtIdPregleda;
        private System.Windows.Forms.DataGridView dgvSpecijalizacija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnObrisiSpecijalizaciju;
        private System.Windows.Forms.Button btnDodajSpecijalizaciju;
        private System.Windows.Forms.TextBox txtNazivSpecijalizacije;
        private System.Windows.Forms.TextBox txtIdSpecijalizacije;
        private System.Windows.Forms.DataGridView dgvTipZaposlenika;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnObrisiTipZaposlenika;
        private System.Windows.Forms.Button btnDodajTipZaposlenika;
        private System.Windows.Forms.TextBox txtNazivTipa;
        private System.Windows.Forms.TextBox txtIdTip;
        private System.Windows.Forms.Button btnNatrag;
    }
}
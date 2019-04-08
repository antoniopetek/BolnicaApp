namespace BolnicaApp.Forme
{
    partial class FrmZdravstveniKarton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmZdravstveniKarton));
            this.gpPregled = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPacijenti = new System.Windows.Forms.DataGridView();
            this.dgvPovijest = new System.Windows.Forms.DataGridView();
            this.gpPregled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPovijest)).BeginInit();
            this.SuspendLayout();
            // 
            // gpPregled
            // 
            this.gpPregled.BackColor = System.Drawing.Color.Transparent;
            this.gpPregled.Controls.Add(this.label3);
            this.gpPregled.Controls.Add(this.txtPretraga);
            this.gpPregled.Controls.Add(this.btnNatrag);
            this.gpPregled.Controls.Add(this.btnDodaj);
            this.gpPregled.Controls.Add(this.label2);
            this.gpPregled.Controls.Add(this.label1);
            this.gpPregled.Controls.Add(this.dgvPacijenti);
            this.gpPregled.Controls.Add(this.dgvPovijest);
            this.gpPregled.Location = new System.Drawing.Point(12, 12);
            this.gpPregled.Name = "gpPregled";
            this.gpPregled.Size = new System.Drawing.Size(565, 442);
            this.gpPregled.TabIndex = 3;
            this.gpPregled.TabStop = false;
            this.gpPregled.Text = "Pregled povijesti bolesti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(341, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pretraga:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(415, 34);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(144, 20);
            this.txtPretraga.TabIndex = 6;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // btnNatrag
            // 
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.Location = new System.Drawing.Point(468, 399);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(91, 37);
            this.btnNatrag.TabIndex = 5;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(434, 268);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(125, 41);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj bolest pacijentu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Povijest bolesti:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Popis pacijenata:";
            // 
            // dgvPacijenti
            // 
            this.dgvPacijenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPacijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacijenti.Location = new System.Drawing.Point(15, 60);
            this.dgvPacijenti.MultiSelect = false;
            this.dgvPacijenti.Name = "dgvPacijenti";
            this.dgvPacijenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacijenti.Size = new System.Drawing.Size(544, 168);
            this.dgvPacijenti.TabIndex = 0;
            this.dgvPacijenti.SelectionChanged += new System.EventHandler(this.dgvPacijenti_SelectionChanged);
            // 
            // dgvPovijest
            // 
            this.dgvPovijest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPovijest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPovijest.Location = new System.Drawing.Point(15, 268);
            this.dgvPovijest.MultiSelect = false;
            this.dgvPovijest.Name = "dgvPovijest";
            this.dgvPovijest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPovijest.Size = new System.Drawing.Size(413, 168);
            this.dgvPovijest.TabIndex = 1;
            // 
            // FrmZdravstveniKarton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(589, 460);
            this.Controls.Add(this.gpPregled);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmZdravstveniKarton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zdravsteveni kartoni";
            this.Load += new System.EventHandler(this.FrmZdravstveniKarton_Load);
            this.gpPregled.ResumeLayout(false);
            this.gpPregled.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPovijest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpPregled;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPacijenti;
        private System.Windows.Forms.DataGridView dgvPovijest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPretraga;
    }
}
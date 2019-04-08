namespace BolnicaApp.Forme
{
    partial class FrmPregledRecepata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPregledRecepata));
            this.dgvRecepti = new System.Windows.Forms.DataGridView();
            this.dgvLijekovi = new System.Windows.Forms.DataGridView();
            this.gpPregled = new System.Windows.Forms.GroupBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).BeginInit();
            this.gpPregled.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRecepti
            // 
            this.dgvRecepti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRecepti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecepti.Location = new System.Drawing.Point(15, 60);
            this.dgvRecepti.MultiSelect = false;
            this.dgvRecepti.Name = "dgvRecepti";
            this.dgvRecepti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecepti.Size = new System.Drawing.Size(475, 168);
            this.dgvRecepti.TabIndex = 0;
            this.dgvRecepti.SelectionChanged += new System.EventHandler(this.dgvRecepti_SelectionChanged);
            // 
            // dgvLijekovi
            // 
            this.dgvLijekovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLijekovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLijekovi.Location = new System.Drawing.Point(15, 268);
            this.dgvLijekovi.MultiSelect = false;
            this.dgvLijekovi.Name = "dgvLijekovi";
            this.dgvLijekovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLijekovi.Size = new System.Drawing.Size(323, 168);
            this.dgvLijekovi.TabIndex = 1;
            // 
            // gpPregled
            // 
            this.gpPregled.BackColor = System.Drawing.Color.Transparent;
            this.gpPregled.Controls.Add(this.btnNatrag);
            this.gpPregled.Controls.Add(this.btnDodaj);
            this.gpPregled.Controls.Add(this.label2);
            this.gpPregled.Controls.Add(this.label1);
            this.gpPregled.Controls.Add(this.dgvRecepti);
            this.gpPregled.Controls.Add(this.dgvLijekovi);
            this.gpPregled.Location = new System.Drawing.Point(12, 12);
            this.gpPregled.Name = "gpPregled";
            this.gpPregled.Size = new System.Drawing.Size(510, 442);
            this.gpPregled.TabIndex = 2;
            this.gpPregled.TabStop = false;
            this.gpPregled.Text = "Pregled recepata";
            // 
            // btnNatrag
            // 
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.Location = new System.Drawing.Point(399, 399);
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
            this.btnDodaj.Location = new System.Drawing.Point(365, 268);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(125, 41);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj novi recept";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lijekovi na odabranom receptu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Popis svih recepata:";
            // 
            // FrmPregledRecepata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(538, 466);
            this.Controls.Add(this.gpPregled);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPregledRecepata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPregledRecepata";
            this.Load += new System.EventHandler(this.FrmPregledRecepata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).EndInit();
            this.gpPregled.ResumeLayout(false);
            this.gpPregled.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecepti;
        private System.Windows.Forms.DataGridView dgvLijekovi;
        private System.Windows.Forms.GroupBox gpPregled;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
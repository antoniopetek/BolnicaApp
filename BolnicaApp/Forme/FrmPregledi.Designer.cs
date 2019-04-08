namespace BolnicaApp.Forme
{
    partial class FrmPregledi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPregledi));
            this.dgvPregledi = new System.Windows.Forms.DataGridView();
            this.gpPopisPregleda = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnDodajPregled = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledi)).BeginInit();
            this.gpPopisPregleda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPregledi
            // 
            this.dgvPregledi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledi.Location = new System.Drawing.Point(6, 57);
            this.dgvPregledi.MultiSelect = false;
            this.dgvPregledi.Name = "dgvPregledi";
            this.dgvPregledi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPregledi.Size = new System.Drawing.Size(660, 245);
            this.dgvPregledi.TabIndex = 0;
            // 
            // gpPopisPregleda
            // 
            this.gpPopisPregleda.BackColor = System.Drawing.Color.Transparent;
            this.gpPopisPregleda.Controls.Add(this.label1);
            this.gpPopisPregleda.Controls.Add(this.dtpDatum);
            this.gpPopisPregleda.Controls.Add(this.dgvPregledi);
            this.gpPopisPregleda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gpPopisPregleda.Location = new System.Drawing.Point(12, 12);
            this.gpPopisPregleda.Name = "gpPopisPregleda";
            this.gpPopisPregleda.Size = new System.Drawing.Size(672, 310);
            this.gpPopisPregleda.TabIndex = 3;
            this.gpPopisPregleda.TabStop = false;
            this.gpPopisPregleda.Text = "Popis svih pregleda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datum pregleda:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDatum.Location = new System.Drawing.Point(503, 30);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(163, 21);
            this.dtpDatum.TabIndex = 1;
            this.dtpDatum.ValueChanged += new System.EventHandler(this.dtpDatum_ValueChanged);
            // 
            // btnDodajPregled
            // 
            this.btnDodajPregled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajPregled.Location = new System.Drawing.Point(527, 328);
            this.btnDodajPregled.Name = "btnDodajPregled";
            this.btnDodajPregled.Size = new System.Drawing.Size(151, 41);
            this.btnDodajPregled.TabIndex = 4;
            this.btnDodajPregled.Text = "Rezerviraj pregled";
            this.btnDodajPregled.UseVisualStyleBackColor = true;
            this.btnDodajPregled.Click += new System.EventHandler(this.btnDodajPregled_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(427, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Natrag";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPregledi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(698, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDodajPregled);
            this.Controls.Add(this.gpPopisPregleda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPregledi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregledi";
            this.Load += new System.EventHandler(this.FrmPregledi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledi)).EndInit();
            this.gpPopisPregleda.ResumeLayout(false);
            this.gpPopisPregleda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPregledi;
        private System.Windows.Forms.GroupBox gpPopisPregleda;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajPregled;
        private System.Windows.Forms.Button button1;
    }
}
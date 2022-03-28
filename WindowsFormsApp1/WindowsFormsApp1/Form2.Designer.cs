namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.lblJenis = new System.Windows.Forms.Label();
            this.lblMerek = new System.Windows.Forms.Label();
            this.lblUkuran = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbXl = new System.Windows.Forms.RadioButton();
            this.rdbL = new System.Windows.Forms.RadioButton();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.rdbS = new System.Windows.Forms.RadioButton();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.dtpBarang = new System.Windows.Forms.DateTimePicker();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPakaian = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JenisPakaian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MerekPakaian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ukuran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarangMasuk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokMasuk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMerek = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPakaian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gudang Pakaian\r\n";
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Location = new System.Drawing.Point(6, 25);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(73, 13);
            this.lblJenis.TabIndex = 1;
            this.lblJenis.Text = "Jenis Pakaian";
            // 
            // lblMerek
            // 
            this.lblMerek.AutoSize = true;
            this.lblMerek.Location = new System.Drawing.Point(6, 49);
            this.lblMerek.Name = "lblMerek";
            this.lblMerek.Size = new System.Drawing.Size(79, 13);
            this.lblMerek.TabIndex = 2;
            this.lblMerek.Text = "Merek Pakaian";
            // 
            // lblUkuran
            // 
            this.lblUkuran.AutoSize = true;
            this.lblUkuran.Location = new System.Drawing.Point(6, 75);
            this.lblUkuran.Name = "lblUkuran";
            this.lblUkuran.Size = new System.Drawing.Size(42, 13);
            this.lblUkuran.TabIndex = 3;
            this.lblUkuran.Text = "Ukuran";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tanggal Barang Masuk";
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(6, 125);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(64, 13);
            this.lblStok.TabIndex = 5;
            this.lblStok.Text = "Stok Masuk";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMerek);
            this.groupBox1.Controls.Add(this.rdbXl);
            this.groupBox1.Controls.Add(this.rdbL);
            this.groupBox1.Controls.Add(this.rdbM);
            this.groupBox1.Controls.Add(this.rdbS);
            this.groupBox1.Controls.Add(this.txtStok);
            this.groupBox1.Controls.Add(this.dtpBarang);
            this.groupBox1.Controls.Add(this.lblJenis);
            this.groupBox1.Controls.Add(this.lblMerek);
            this.groupBox1.Controls.Add(this.cmbJenis);
            this.groupBox1.Controls.Add(this.lblUkuran);
            this.groupBox1.Controls.Add(this.lblStok);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 154);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // rdbXl
            // 
            this.rdbXl.AutoSize = true;
            this.rdbXl.Location = new System.Drawing.Point(255, 73);
            this.rdbXl.Name = "rdbXl";
            this.rdbXl.Size = new System.Drawing.Size(38, 17);
            this.rdbXl.TabIndex = 6;
            this.rdbXl.TabStop = true;
            this.rdbXl.Text = "XL";
            this.rdbXl.UseVisualStyleBackColor = true;
            // 
            // rdbL
            // 
            this.rdbL.AutoSize = true;
            this.rdbL.Location = new System.Drawing.Point(218, 73);
            this.rdbL.Name = "rdbL";
            this.rdbL.Size = new System.Drawing.Size(31, 17);
            this.rdbL.TabIndex = 5;
            this.rdbL.TabStop = true;
            this.rdbL.Text = "L";
            this.rdbL.UseVisualStyleBackColor = true;
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Location = new System.Drawing.Point(178, 73);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(34, 17);
            this.rdbM.TabIndex = 4;
            this.rdbM.TabStop = true;
            this.rdbM.Text = "M";
            this.rdbM.UseVisualStyleBackColor = true;
            // 
            // rdbS
            // 
            this.rdbS.AutoSize = true;
            this.rdbS.Location = new System.Drawing.Point(140, 73);
            this.rdbS.Name = "rdbS";
            this.rdbS.Size = new System.Drawing.Size(32, 17);
            this.rdbS.TabIndex = 3;
            this.rdbS.TabStop = true;
            this.rdbS.Text = "S";
            this.rdbS.UseVisualStyleBackColor = true;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(140, 122);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(115, 20);
            this.txtStok.TabIndex = 0;
            // 
            // dtpBarang
            // 
            this.dtpBarang.Location = new System.Drawing.Point(140, 96);
            this.dtpBarang.Name = "dtpBarang";
            this.dtpBarang.Size = new System.Drawing.Size(153, 20);
            this.dtpBarang.TabIndex = 0;
            // 
            // cmbJenis
            // 
            this.cmbJenis.FormattingEnabled = true;
            this.cmbJenis.Items.AddRange(new object[] {
            "Kaos",
            "Kemeja",
            "Sweater",
            "Coat",
            "Hoodie",
            "Tunik",
            "Batik",
            "Outer"});
            this.cmbJenis.Location = new System.Drawing.Point(140, 19);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new System.Drawing.Size(153, 21);
            this.cmbJenis.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPakaian);
            this.groupBox2.Location = new System.Drawing.Point(12, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 188);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // dgvPakaian
            // 
            this.dgvPakaian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPakaian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.JenisPakaian,
            this.MerekPakaian,
            this.Ukuran,
            this.BarangMasuk,
            this.StokMasuk});
            this.dgvPakaian.Location = new System.Drawing.Point(6, 10);
            this.dgvPakaian.Name = "dgvPakaian";
            this.dgvPakaian.Size = new System.Drawing.Size(651, 150);
            this.dgvPakaian.TabIndex = 3;
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            // 
            // JenisPakaian
            // 
            this.JenisPakaian.HeaderText = "Jenis Pakaian";
            this.JenisPakaian.Name = "JenisPakaian";
            // 
            // MerekPakaian
            // 
            this.MerekPakaian.HeaderText = "Merek Pakaian";
            this.MerekPakaian.Name = "MerekPakaian";
            // 
            // Ukuran
            // 
            this.Ukuran.HeaderText = "Ukuran";
            this.Ukuran.Name = "Ukuran";
            // 
            // BarangMasuk
            // 
            this.BarangMasuk.HeaderText = "Barang Masuk";
            this.BarangMasuk.Name = "BarangMasuk";
            // 
            // StokMasuk
            // 
            this.StokMasuk.HeaderText = "Stok Masuk";
            this.StokMasuk.Name = "StokMasuk";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(12, 263);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 4;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(93, 263);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(91, 23);
            this.btnHapus.TabIndex = 5;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(269, 263);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 6;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtMerek
            // 
            this.txtMerek.Location = new System.Drawing.Point(140, 46);
            this.txtMerek.Name = "txtMerek";
            this.txtMerek.Size = new System.Drawing.Size(153, 20);
            this.txtMerek.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPakaian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.Label lblMerek;
        private System.Windows.Forms.Label lblUkuran;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.DataGridView dgvPakaian;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.DateTimePicker dtpBarang;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.RadioButton rdbXl;
        private System.Windows.Forms.RadioButton rdbL;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.RadioButton rdbS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn JenisPakaian;
        private System.Windows.Forms.DataGridViewTextBoxColumn MerekPakaian;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ukuran;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarangMasuk;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokMasuk;
        private System.Windows.Forms.TextBox txtMerek;
    }
}
namespace UTS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            labelTitle = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            btnReset = new Button();
            btnHitung = new Button();
            inputJamKerja = new TextBox();
            jamkerja_karyawan = new Label();
            label2 = new Label();
            inputPendidikan = new ComboBox();
            inputGolongan = new ComboBox();
            inputNamaKaryawan = new TextBox();
            inputNip = new TextBox();
            pendidikan_karyawan = new Label();
            golongan_karyawan = new Label();
            nama_karyawan = new Label();
            nip_karyawan = new Label();
            groupBox1 = new GroupBox();
            textTotalGaji = new TextBox();
            label9 = new Label();
            textUpahLembur = new TextBox();
            label8 = new Label();
            textTunjanganPendidikan = new TextBox();
            label7 = new Label();
            textTunjanganJabatan = new TextBox();
            textGajiPokok = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textName = new TextBox();
            textNip = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panelHeader.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.BackColor = SystemColors.ActiveCaption;
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Location = new Point(12, 12);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(936, 128);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = SystemColors.ActiveCaption;
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.FlatStyle = FlatStyle.Flat;
            labelTitle.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.ActiveCaptionText;
            labelTitle.ImageAlign = ContentAlignment.BottomRight;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(936, 128);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "HITUNG GAJI KARYAWAN HONOR";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            labelTitle.Click += labelTitle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 167);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 146);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(936, 557);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnReset);
            groupBox2.Controls.Add(btnHitung);
            groupBox2.Controls.Add(inputJamKerja);
            groupBox2.Controls.Add(jamkerja_karyawan);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(inputPendidikan);
            groupBox2.Controls.Add(inputGolongan);
            groupBox2.Controls.Add(inputNamaKaryawan);
            groupBox2.Controls.Add(inputNip);
            groupBox2.Controls.Add(pendidikan_karyawan);
            groupBox2.Controls.Add(golongan_karyawan);
            groupBox2.Controls.Add(nama_karyawan);
            groupBox2.Controls.Add(nip_karyawan);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(5, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(459, 547);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "DATA KARYAWAN";
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnReset.BackColor = SystemColors.ScrollBar;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = SystemColors.ActiveCaptionText;
            btnReset.Location = new Point(122, 434);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(151, 39);
            btnReset.TabIndex = 12;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnHitung
            // 
            btnHitung.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnHitung.BackColor = SystemColors.InactiveCaption;
            btnHitung.FlatAppearance.BorderSize = 0;
            btnHitung.FlatStyle = FlatStyle.Flat;
            btnHitung.ForeColor = SystemColors.ActiveCaptionText;
            btnHitung.Location = new Point(279, 434);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(151, 39);
            btnHitung.TabIndex = 11;
            btnHitung.Text = "HITUNG GAJI";
            btnHitung.UseVisualStyleBackColor = false;
            btnHitung.Click += btnHitung_Click;
            // 
            // inputJamKerja
            // 
            inputJamKerja.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputJamKerja.Location = new Point(24, 378);
            inputJamKerja.Name = "inputJamKerja";
            inputJamKerja.Size = new Size(402, 27);
            inputJamKerja.TabIndex = 10;
            // 
            // jamkerja_karyawan
            // 
            jamkerja_karyawan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            jamkerja_karyawan.AutoSize = true;
            jamkerja_karyawan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jamkerja_karyawan.Location = new Point(28, 355);
            jamkerja_karyawan.Name = "jamkerja_karyawan";
            jamkerja_karyawan.Size = new Size(142, 20);
            jamkerja_karyawan.TabIndex = 9;
            jamkerja_karyawan.Text = "JUMLAH JAM KERJA";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 316);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 8;
            label2.Text = "ABSENSI KARYAWAN";
            // 
            // inputPendidikan
            // 
            inputPendidikan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputPendidikan.CausesValidation = false;
            inputPendidikan.FormattingEnabled = true;
            inputPendidikan.Items.AddRange(new object[] { "SMK/SMA", "D3", "S1" });
            inputPendidikan.Location = new Point(26, 255);
            inputPendidikan.Name = "inputPendidikan";
            inputPendidikan.Size = new Size(402, 28);
            inputPendidikan.TabIndex = 7;
            // 
            // inputGolongan
            // 
            inputGolongan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputGolongan.FormattingEnabled = true;
            inputGolongan.Items.AddRange(new object[] { "1", "2", "3" });
            inputGolongan.Location = new Point(28, 187);
            inputGolongan.Name = "inputGolongan";
            inputGolongan.Size = new Size(402, 28);
            inputGolongan.TabIndex = 6;
            // 
            // inputNamaKaryawan
            // 
            inputNamaKaryawan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputNamaKaryawan.Location = new Point(26, 124);
            inputNamaKaryawan.Name = "inputNamaKaryawan";
            inputNamaKaryawan.Size = new Size(402, 27);
            inputNamaKaryawan.TabIndex = 5;
            // 
            // inputNip
            // 
            inputNip.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputNip.Location = new Point(28, 60);
            inputNip.Name = "inputNip";
            inputNip.Size = new Size(402, 27);
            inputNip.TabIndex = 4;
            // 
            // pendidikan_karyawan
            // 
            pendidikan_karyawan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pendidikan_karyawan.AutoSize = true;
            pendidikan_karyawan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendidikan_karyawan.Location = new Point(28, 232);
            pendidikan_karyawan.Name = "pendidikan_karyawan";
            pendidikan_karyawan.Size = new Size(178, 20);
            pendidikan_karyawan.TabIndex = 3;
            pendidikan_karyawan.Text = "PENDIDIKAN KARYAWAN";
            // 
            // golongan_karyawan
            // 
            golongan_karyawan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            golongan_karyawan.AutoSize = true;
            golongan_karyawan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            golongan_karyawan.Location = new Point(26, 164);
            golongan_karyawan.Name = "golongan_karyawan";
            golongan_karyawan.Size = new Size(171, 20);
            golongan_karyawan.TabIndex = 2;
            golongan_karyawan.Text = "GOLONGAN KARYAWAN";
            // 
            // nama_karyawan
            // 
            nama_karyawan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nama_karyawan.AutoSize = true;
            nama_karyawan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nama_karyawan.Location = new Point(26, 101);
            nama_karyawan.Name = "nama_karyawan";
            nama_karyawan.Size = new Size(135, 20);
            nama_karyawan.TabIndex = 1;
            nama_karyawan.Text = "NAMA KARYAWAN";
            // 
            // nip_karyawan
            // 
            nip_karyawan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nip_karyawan.AutoSize = true;
            nip_karyawan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nip_karyawan.Location = new Point(26, 37);
            nip_karyawan.Name = "nip_karyawan";
            nip_karyawan.Size = new Size(32, 20);
            nip_karyawan.TabIndex = 0;
            nip_karyawan.Text = "NIP";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textTotalGaji);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textUpahLembur);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textTunjanganPendidikan);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textTunjanganJabatan);
            groupBox1.Controls.Add(textGajiPokok);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textName);
            groupBox1.Controls.Add(textNip);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(472, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(459, 547);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "HASIL PERHITUNGAN";
            // 
            // textTotalGaji
            // 
            textTotalGaji.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textTotalGaji.Location = new Point(15, 457);
            textTotalGaji.Name = "textTotalGaji";
            textTotalGaji.ReadOnly = true;
            textTotalGaji.Size = new Size(402, 27);
            textTotalGaji.TabIndex = 26;
            textTotalGaji.TabStop = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(13, 434);
            label9.Name = "label9";
            label9.Size = new Size(84, 20);
            label9.TabIndex = 25;
            label9.Text = "TOTAL GAJI";
            // 
            // textUpahLembur
            // 
            textUpahLembur.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textUpahLembur.Location = new Point(15, 388);
            textUpahLembur.Name = "textUpahLembur";
            textUpahLembur.ReadOnly = true;
            textUpahLembur.Size = new Size(402, 27);
            textUpahLembur.TabIndex = 24;
            textUpahLembur.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(15, 365);
            label8.Name = "label8";
            label8.Size = new Size(107, 20);
            label8.TabIndex = 23;
            label8.Text = "UPAH LEMBUR";
            // 
            // textTunjanganPendidikan
            // 
            textTunjanganPendidikan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textTunjanganPendidikan.Location = new Point(17, 319);
            textTunjanganPendidikan.Name = "textTunjanganPendidikan";
            textTunjanganPendidikan.ReadOnly = true;
            textTunjanganPendidikan.Size = new Size(402, 27);
            textTunjanganPendidikan.TabIndex = 22;
            textTunjanganPendidikan.TabStop = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(17, 296);
            label7.Name = "label7";
            label7.Size = new Size(186, 20);
            label7.TabIndex = 21;
            label7.Text = "TUNJANGAN PENDIDIKAN";
            // 
            // textTunjanganJabatan
            // 
            textTunjanganJabatan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textTunjanganJabatan.Location = new Point(15, 255);
            textTunjanganJabatan.Name = "textTunjanganJabatan";
            textTunjanganJabatan.ReadOnly = true;
            textTunjanganJabatan.Size = new Size(402, 27);
            textTunjanganJabatan.TabIndex = 20;
            textTunjanganJabatan.TabStop = false;
            // 
            // textGajiPokok
            // 
            textGajiPokok.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textGajiPokok.Location = new Point(17, 191);
            textGajiPokok.Name = "textGajiPokok";
            textGajiPokok.ReadOnly = true;
            textGajiPokok.Size = new Size(402, 27);
            textGajiPokok.TabIndex = 19;
            textGajiPokok.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 168);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 17;
            label5.Text = "GAJI POKOK";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 232);
            label6.Name = "label6";
            label6.Size = new Size(160, 20);
            label6.TabIndex = 18;
            label6.Text = "TUNJANGAN JABATAN";
            // 
            // textName
            // 
            textName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textName.Location = new Point(13, 124);
            textName.Name = "textName";
            textName.ReadOnly = true;
            textName.Size = new Size(402, 27);
            textName.TabIndex = 16;
            textName.TabStop = false;
            // 
            // textNip
            // 
            textNip.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textNip.Location = new Point(15, 60);
            textNip.Name = "textNip";
            textNip.ReadOnly = true;
            textNip.Size = new Size(402, 27);
            textNip.TabIndex = 15;
            textNip.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 37);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 13;
            label4.Text = "NIP";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 101);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 14;
            label3.Text = "NAMA KARYAWAN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(962, 791);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(panelHeader);
            Name = "Form1";
            Text = "Form1";
            panelHeader.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label labelTitle;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private Label nip_karyawan;
        private Label nama_karyawan;
        private Label pendidikan_karyawan;
        private Label golongan_karyawan;
        private ComboBox inputGolongan;
        private TextBox inputNamaKaryawan;
        private TextBox inputNip;
        private ComboBox inputPendidikan;
        private TextBox inputJamKerja;
        private Label jamkerja_karyawan;
        private Label label2;
        private Button btnHitung;
        private Button btnReset;
        private GroupBox groupBox1;
        private TextBox textName;
        private TextBox textNip;
        private Label label4;
        private Label label3;
        private TextBox textTunjanganJabatan;
        private TextBox textGajiPokok;
        private Label label5;
        private Label label6;
        private TextBox textTotalGaji;
        private Label label9;
        private TextBox textUpahLembur;
        private Label label8;
        private TextBox textTunjanganPendidikan;
        private Label label7;
    }
}

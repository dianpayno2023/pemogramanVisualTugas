namespace UTS
{
    partial class UC_Absensi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            tanggal = new DateTimePicker();
            label4 = new Label();
            comboNamaKaryawan = new ComboBox();
            label2 = new Label();
            panel3 = new Panel();
            button2 = new Button();
            btnSimpanJam = new Button();
            jamKeluar = new DateTimePicker();
            jamMasuk = new DateTimePicker();
            label3 = new Label();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel4 = new Panel();
            panel5 = new Panel();
            textLembur = new TextBox();
            label9 = new Label();
            textTidakTelat = new TextBox();
            label8 = new Label();
            textTelat = new TextBox();
            label7 = new Label();
            label6 = new Label();
            panel6 = new Panel();
            tableAbsensiKaryawan = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableAbsensiKaryawan).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveBorder;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1052, 50);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 15);
            label1.Name = "label1";
            label1.Size = new Size(204, 20);
            label1.TabIndex = 0;
            label1.Text = "Hitung Jam Kerja Karyawan";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tanggal);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(comboNamaKaryawan);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(367, 209);
            panel2.TabIndex = 1;
            // 
            // tanggal
            // 
            tanggal.Enabled = false;
            tanggal.Location = new Point(13, 28);
            tanggal.Name = "tanggal";
            tanggal.Size = new Size(351, 27);
            tanggal.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 3);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 3;
            label4.Text = "Tanggal";
            // 
            // comboNamaKaryawan
            // 
            comboNamaKaryawan.FormattingEnabled = true;
            comboNamaKaryawan.Location = new Point(14, 88);
            comboNamaKaryawan.Name = "comboNamaKaryawan";
            comboNamaKaryawan.Size = new Size(350, 28);
            comboNamaKaryawan.TabIndex = 1;
            comboNamaKaryawan.SelectedIndexChanged += comboNamaKaryawan_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 65);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 0;
            label2.Text = "Nama Karyawan";
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(btnSimpanJam);
            panel3.Controls.Add(jamKeluar);
            panel3.Controls.Add(jamMasuk);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(382, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(370, 206);
            panel3.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GrayText;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(101, 150);
            button2.Name = "button2";
            button2.Size = new Size(130, 29);
            button2.TabIndex = 7;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnSimpanJam
            // 
            btnSimpanJam.BackColor = SystemColors.MenuHighlight;
            btnSimpanJam.FlatAppearance.BorderSize = 0;
            btnSimpanJam.FlatStyle = FlatStyle.Flat;
            btnSimpanJam.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpanJam.ForeColor = SystemColors.ButtonHighlight;
            btnSimpanJam.Location = new Point(237, 150);
            btnSimpanJam.Name = "btnSimpanJam";
            btnSimpanJam.Size = new Size(130, 29);
            btnSimpanJam.TabIndex = 6;
            btnSimpanJam.Text = "Simpan";
            btnSimpanJam.UseVisualStyleBackColor = false;
            btnSimpanJam.Click += btnSimpanJam_Click;
            // 
            // jamKeluar
            // 
            jamKeluar.Format = DateTimePickerFormat.Time;
            jamKeluar.Location = new Point(14, 86);
            jamKeluar.Name = "jamKeluar";
            jamKeluar.ShowUpDown = true;
            jamKeluar.Size = new Size(353, 27);
            jamKeluar.TabIndex = 5;
            // 
            // jamMasuk
            // 
            jamMasuk.Format = DateTimePickerFormat.Time;
            jamMasuk.Location = new Point(14, 27);
            jamMasuk.Name = "jamMasuk";
            jamMasuk.ShowUpDown = true;
            jamMasuk.Size = new Size(353, 27);
            jamMasuk.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 3);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 3;
            label3.Text = "Jam Masuk";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 65);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 0;
            label5.Text = "Jam Keluar";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(1052, 236);
            panel4.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(textLembur);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(textTidakTelat);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(textTelat);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(757, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 207);
            panel5.TabIndex = 6;
            // 
            // textLembur
            // 
            textLembur.Location = new Point(122, 110);
            textLembur.Name = "textLembur";
            textLembur.Size = new Size(125, 27);
            textLembur.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 113);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 5;
            label9.Text = "Lembur";
            // 
            // textTidakTelat
            // 
            textTidakTelat.Location = new Point(122, 67);
            textTidakTelat.Name = "textTidakTelat";
            textTidakTelat.Size = new Size(125, 27);
            textTidakTelat.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 70);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 3;
            label8.Text = "Tidak Telat";
            // 
            // textTelat
            // 
            textTelat.Location = new Point(122, 34);
            textTelat.Name = "textTelat";
            textTelat.Size = new Size(125, 27);
            textTelat.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 34);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 1;
            label7.Text = "Telat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 4);
            label6.Name = "label6";
            label6.Size = new Size(182, 20);
            label6.TabIndex = 0;
            label6.Text = "Sumary Absensi Per Hari";
            // 
            // panel6
            // 
            panel6.Controls.Add(tableAbsensiKaryawan);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 286);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(10);
            panel6.Size = new Size(1052, 431);
            panel6.TabIndex = 7;
            // 
            // tableAbsensiKaryawan
            // 
            tableAbsensiKaryawan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableAbsensiKaryawan.BackgroundColor = SystemColors.GradientInactiveCaption;
            tableAbsensiKaryawan.BorderStyle = BorderStyle.None;
            tableAbsensiKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableAbsensiKaryawan.Dock = DockStyle.Fill;
            tableAbsensiKaryawan.Location = new Point(10, 10);
            tableAbsensiKaryawan.Name = "tableAbsensiKaryawan";
            tableAbsensiKaryawan.RowHeadersVisible = false;
            tableAbsensiKaryawan.RowHeadersWidth = 51;
            tableAbsensiKaryawan.Size = new Size(1032, 411);
            tableAbsensiKaryawan.TabIndex = 0;
            tableAbsensiKaryawan.CellContentClick += tableAbsensiKaryawan_CellContentClick;
            // 
            // UC_Absensi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "UC_Absensi";
            Size = new Size(1052, 717);
            Load += UC_Absensi_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableAbsensiKaryawan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private ComboBox comboNamaKaryawan;
        private Label label2;
        private DateTimePicker tanggal;
        private Label label4;
        private Panel panel3;
        private DateTimePicker jamMasuk;
        private Label label3;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
        private Button btnSimpanJam;
        private DateTimePicker jamKeluar;
        private Button button2;
        private Panel panel4;
        private Panel panel5;
        private Label label8;
        private TextBox textTelat;
        private Label label7;
        private Label label6;
        private TextBox textLembur;
        private Label label9;
        private TextBox textTidakTelat;
        private Panel panel6;
        private DataGridView tableAbsensiKaryawan;

    }
}

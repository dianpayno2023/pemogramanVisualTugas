using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace UTS
{
    public partial class UC_DataKaryawan : UserControl
    {

        public UC_DataKaryawan()
        {
            InitializeComponent();

        }

        private void LoadJabatan()
        {
            List<string> jabatan = new List<string>()
            {
                "C Level",
                "Manager",
                "Head Unit",
                "Staff"
            };

            comboJabatan.DataSource = jabatan;
        }
        private void LoadPendidikan()
        {
            List<string> pendidikan = new List<string>()
            {
                "S2",
                "S1",
                "D3",
                "SMK/SMA"
            };

            comboPendidikan.DataSource = pendidikan;
        }


        private void InitListDataKaryawan()
        {
            DataStore.listDataKaryawan = new DataTable();
            DataStore.listDataKaryawan.Columns.Add("No");
            DataStore.listDataKaryawan.Columns.Add("NIP");
            DataStore.listDataKaryawan.Columns.Add("Nama Karyawan");
            DataStore.listDataKaryawan.Columns.Add("Jabatan");
            DataStore.listDataKaryawan.Columns.Add("Tunjangan Jabatan");
            DataStore.listDataKaryawan.Columns.Add("Pendidikan");
            DataStore.listDataKaryawan.Columns.Add("Tempat Lahir");
            DataStore.listDataKaryawan.Columns.Add("Tanggal Lahir");
            DataStore.listDataKaryawan.Columns.Add("Alamat");

            tableDataKaryawan.DataSource = DataStore.listDataKaryawan;
            tableDataKaryawan.Columns["No"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tableDataKaryawan.Columns["No"].Width = 50;

            DataRow row = DataStore.listDataKaryawan.NewRow();

            row["No"] = 1;
            row["NIP"] = "987654321";
            row["Nama Karyawan"] = "DIAN HERDIANA";
            row["Jabatan"] = "Manager";
            row["Tunjangan Jabatan"] = 1000000;
            row["Pendidikan"] = "S1";
            row["Tempat Lahir"] = "Jakarta";
            row["Tanggal Lahir"] = "01/01/1998";
            row["Alamat"] = "Pasar Minggu Jakarta Selatan";


            DataStore.listDataKaryawan.Rows.Add(row);


        }


        private void UC_DataKaryawan_Load(object sender, EventArgs e)
        {
            LoadJabatan();
            LoadPendidikan();
            InitListDataKaryawan();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableDataKaryawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void resetForm()
        {
            textNama.Clear();
            textNip.Clear();
            textAlamat.Clear();
            textTempatLahir.Clear();

        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            string nama = textNama.Text.Trim().ToUpper();
            string nip = textNip.Text.Trim();
            bool nipValid = textNip.Text.All(char.IsDigit) && textNip.Text.Length == 10;
            string tempatlahir = textTempatLahir.Text.Trim();
            string alamat = textAlamat.Text.Trim();
            string jabatan = comboJabatan.Text;
            string pendidikan = comboPendidikan.Text;
            string tanggalLahir = dateTimePickerTanggalLahir.Value.ToString("dd/mm/yyyyy");
            int tunjangan;


            switch (jabatan)
            {
                case "C Level":
                    tunjangan = 2000000;
                    break;
                case "Manager":
                    tunjangan = 1000000;
                    break;
                case "Head Unit":
                    tunjangan = 500000;
                    break;
                case "Staff":
                    tunjangan = 100000;
                    break;
                default:
                    tunjangan = 0;
                    break;
            }

            if (!nipValid)
            {
                MessageBox.Show("NIP harus berupa angka dan 10 digit");
                textNip.Focus();
                return;

            }


            DataRow row = DataStore.listDataKaryawan.NewRow();

            row["No"] = DataStore.listDataKaryawan.Rows.Count + 1;
            row["NIP"] = nip;
            row["Nama Karyawan"] = nama;
            row["Jabatan"] = jabatan;
            row["Tunjangan Jabatan"] = tunjangan;
            row["Pendidikan"] = pendidikan;
            row["Tempat Lahir"] = tempatlahir;
            row["Tanggal Lahir"] = tanggalLahir; // langsung DateTime
            row["Alamat"] = alamat;


            DataStore.listDataKaryawan.Rows.Add(row);

            resetForm();

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void ExportDataKaryawanToCsv()
        {
            if (DataStore.listDataKaryawan == null || DataStore.listDataKaryawan.Rows.Count == 0)
                throw new Exception("Data karyawan kosong");

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV File (*.csv)|*.csv";
                sfd.Title = "Simpan Data Karyawan";
                sfd.FileName = $"DataKaryawan_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.csv";

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                using (StreamWriter writer = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                {
                    DataTable dt = DataStore.listDataKaryawan;

                    // Header
                    string[] headers = dt.Columns
                        .Cast<DataColumn>()
                        .Select(c => c.ColumnName)
                        .ToArray();
                    writer.WriteLine(string.Join(",", headers));

                    // Data
                    foreach (DataRow row in dt.Rows)
                    {
                        string[] values = row.ItemArray
                            .Select(v => v.ToString().Replace(",", " "))
                            .ToArray();

                        writer.WriteLine(string.Join(",", values));
                    }
                }
            }
        }

        private void btnExportToCsv_Click(object sender, EventArgs e)
        {
            try
            {
                ExportDataKaryawanToCsv();
                MessageBox.Show("Data berhasil diexport ke CSV", "Sukses",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            Font contentFont = new Font("Arial", 10);
            Font font = new Font("Arial", 10);

            float yPos = 20;
            float leftMargin = e.MarginBounds.Left;
            float rightMargin = e.MarginBounds.Right;
            float pageWidth = e.MarginBounds.Width;

   
            StringFormat centerAlign = new StringFormat();
            centerAlign.Alignment = StringAlignment.Center;

            StringFormat rightAlign = new StringFormat();
            rightAlign.Alignment = StringAlignment.Far;

            // Center Text
            e.Graphics.DrawString(
                "LAPORAN DATA KARYAWAN",
                new Font("Arial", 14, FontStyle.Bold),
                Brushes.Black,
                new RectangleF(leftMargin, yPos, pageWidth, 30),
                centerAlign
            );

            yPos += 40;

            // RIGHT TEXT
            e.Graphics.DrawString(
                 "Tanggal Cetak: " + DateTime.Now.ToString("dd/MM/yyyy"),
                font,
                Brushes.Black,
                new RectangleF(leftMargin, yPos, pageWidth, 20),
                rightAlign
            );
            yPos += 40;


            //Header
            e.Graphics.DrawString("No", headerFont, Brushes.Black, leftMargin, yPos);
            e.Graphics.DrawString("NIP", headerFont, Brushes.Black, leftMargin + 40, yPos);
            e.Graphics.DrawString("Nama", headerFont, Brushes.Black, leftMargin + 100, yPos);
            e.Graphics.DrawString("Jabatan", headerFont, Brushes.Black, leftMargin + 250, yPos);
            e.Graphics.DrawString("TTL", headerFont, Brushes.Black, leftMargin + 350, yPos);
            e.Graphics.DrawString("", headerFont, Brushes.Black, leftMargin + 400, yPos);
            e.Graphics.DrawString("Alamat", headerFont, Brushes.Black, leftMargin + 500, yPos);

            yPos += 25;
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos);
            yPos += 10;

            //List Data
            foreach (DataRow row in DataStore.listDataKaryawan.Rows)
            {
                e.Graphics.DrawString(row["No"].ToString(), contentFont, Brushes.Black, leftMargin, yPos);
                e.Graphics.DrawString(row["NIP"].ToString(), contentFont, Brushes.Black, leftMargin + 20, yPos);
                e.Graphics.DrawString(row["Nama Karyawan"].ToString(), contentFont, Brushes.Black, leftMargin + 100, yPos);
                e.Graphics.DrawString(row["Jabatan"].ToString(), contentFont, Brushes.Black, leftMargin + 250, yPos);
                e.Graphics.DrawString(row["Tempat Lahir"].ToString(), contentFont, Brushes.Black, leftMargin + 350, yPos);
                e.Graphics.DrawString(row["Tanggal Lahir"].ToString(), contentFont, Brushes.Black, leftMargin + 400, yPos);
                e.Graphics.DrawString(row["Alamat"].ToString(), contentFont, Brushes.Black, leftMargin + 500, yPos);
                yPos += 20;

                // Pindah halaman jika penuh
                if (yPos > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();

            // sambungkan event PrintPage
            printDoc.PrintPage += PrintDoc_PrintPage;

            // === PRINT PREVIEW DI SINI ===
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDoc;
            preview.WindowState = FormWindowState.Maximized; // optional
            preview.ShowDialog();

        }
    }
}

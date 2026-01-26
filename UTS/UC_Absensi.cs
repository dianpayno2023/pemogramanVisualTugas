using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS
{
    public partial class UC_Absensi : UserControl
    {
        private DataTable listAbsenKaryawan;
        public UC_Absensi()
        {
            InitializeComponent();
        }
        private void LoadNamaKaryawan()
        {
            if (DataStore.listDataKaryawan == null) return;

            comboNamaKaryawan.DataSource = DataStore.listDataKaryawan;
            comboNamaKaryawan.DisplayMember = "Nama Karyawan";
            comboNamaKaryawan.ValueMember = "NIP";
        }

        private void InitListAbsenKaryawan()
        {
            listAbsenKaryawan = new DataTable();
            listAbsenKaryawan.Columns.Add("No");
            listAbsenKaryawan.Columns.Add("Tanggal");
            listAbsenKaryawan.Columns.Add("NIP");
            listAbsenKaryawan.Columns.Add("Nama Karyawan");
            listAbsenKaryawan.Columns.Add("Jabatan");
            listAbsenKaryawan.Columns.Add("Jam Masuk");
            listAbsenKaryawan.Columns.Add("Jam Keluar");
            listAbsenKaryawan.Columns.Add("Keterangan");

            tableAbsensiKaryawan.DataSource = listAbsenKaryawan;
            tableAbsensiKaryawan.Columns["No"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tableAbsensiKaryawan.Columns["No"].Width = 50;

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void tableAbsensiKaryawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_Absensi_Load_1(object sender, EventArgs e)
        {
            InitListAbsenKaryawan();
            LoadNamaKaryawan();
        }

        private void comboNamaKaryawan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboNamaKaryawan.SelectedItem == null) return;

            DataRowView row = comboNamaKaryawan.SelectedItem as DataRowView;
            if (row == null) return;

            string nip = row["NIP"].ToString();
            string nama = row["Nama Karyawan"].ToString();
            string jabatan = row["Jabatan"].ToString();
        }

        private void btnSimpanJam_Click(object sender, EventArgs e)
        {

            try
            {
                DataRowView rowKaryawan = comboNamaKaryawan.SelectedItem as DataRowView;
                TimeSpan jamMasukTime = jamMasuk.Value.TimeOfDay;
                TimeSpan jamKeluarTime = jamKeluar.Value.TimeOfDay;
                TimeSpan durasiKerja = jamKeluarTime - jamMasukTime;
                if (jamKeluar.Value <= jamMasuk.Value)
                {
                    throw new Exception("Jam keluar harus lebih besar dari jam masuk");
                }
                string keterangan = "NORMAL";
                if (jamMasukTime > new TimeSpan(9, 0, 0))
                {
                    keterangan = "TELAT";
                }
                if (durasiKerja.TotalHours > 8)
                {
                    keterangan = "LEMBUR";
                }
                DataRow rowAbsen = listAbsenKaryawan.NewRow();
                rowAbsen["No"] = listAbsenKaryawan.Rows.Count + 1;
                rowAbsen["Tanggal"] = tanggal.Value.ToString("yyyy/MM/dd");
                rowAbsen["NIP"] = rowKaryawan["NIP"];
                rowAbsen["Nama Karyawan"] = rowKaryawan["Nama Karyawan"];
                rowAbsen["Jabatan"] = rowKaryawan["Jabatan"];
                rowAbsen["Jam Masuk"] = jamMasuk.Value.ToString("HH:mm");
                rowAbsen["Jam Keluar"] = jamKeluar.Value.ToString("HH:mm");
                rowAbsen["Keterangan"] = keterangan;
                listAbsenKaryawan.Rows.Add(rowAbsen);

                int totalTelat = 0;
                int totalLembur = 0;
                int totalTidaktelat = 0;

                foreach (DataRow row in listAbsenKaryawan.Rows)
                {
                    string ket = row["Keterangan"].ToString();

                    if (ket == "TELAT")
                        totalTelat++;

                    if (ket == "LEMBUR")
                        totalLembur++;
                    if (ket != "TELAT")
                        totalTidaktelat++;

                }

                textTelat.Text = totalTelat.ToString();
                textLembur.Text = totalLembur.ToString();
                textTidakTelat.Text = totalTidaktelat.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }
    }
}

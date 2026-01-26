namespace UTS
{
    public partial class Form1 : Form
    {
        // Konstanta
        double gajiPokok = 3500000;
        double upahLembur = 12500;
        int golongan;
        string pendidikan;
        double tunjanganJabatan;
        double tunjanganPendidikan;
        double totalLembur;
        double totalGaji;
        public Form1()
        {
            InitializeComponent();


        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            if (inputNip.Text == "")
            {
                MessageBox.Show("NIP tidak boleh kosong");
                return;

            }
            else if (inputNamaKaryawan.Text == "")
            {
                MessageBox.Show("Nama Karyawan tidak boleh kosong");
                return;

            }
            else if (inputGolongan.SelectedItem == null)
            {
                MessageBox.Show("Pilih golongan terlebih dahulu!");
                return;
            }
            else if (inputPendidikan.SelectedItem == null)
            {
                MessageBox.Show("Pilih pendidikan terlebih dahulu!");
                return;

            }
            else if (inputJamKerja.Text == "")
            {
                MessageBox.Show("Jumlah Jam Kerja tidak boleh kosong");
                return;

            }

            golongan = int.Parse(inputGolongan.SelectedItem.ToString());
            switch (golongan)
            {
                case 1:
                    tunjanganJabatan = gajiPokok * 0.05;
                    break;
                case 2:
                    tunjanganJabatan = gajiPokok * 0.10;
                    break;
                case 3:
                    tunjanganJabatan = gajiPokok * 0.15;
                    break;
                default:
                    tunjanganJabatan = 0;
                    MessageBox.Show("Golongan tidak valid!");
                    break;
            }

            pendidikan = inputPendidikan.SelectedItem.ToString().Trim();
            switch (pendidikan)
            {
                case "SMK/SMA":
                    tunjanganPendidikan = gajiPokok * 0.025;
                    break;
                case "D3":
                    tunjanganPendidikan = gajiPokok * 0.05;
                    break;
                case "S1":
                    tunjanganPendidikan = gajiPokok * 0.075;
                    break;
                default:
                    tunjanganPendidikan = 0;
                    MessageBox.Show("Pendidikan tidak valid!");
                    break;
            }
            int jamperMinggu = 8 * 5;
            int normalJam = jamperMinggu * 4;
            if (!int.TryParse(inputJamKerja.Text.Trim(), out int jam))
            {
                MessageBox.Show("Jam kerja harus angka!");
                inputJamKerja.Focus();
                return;
            }
            ;
            if (jam < normalJam)
            {
                totalLembur = 0 * upahLembur;
            }
            else
            {
                int jamLembur = jam - normalJam;
                totalLembur = jamLembur * upahLembur;

            }

            textNip.Text = inputNip.Text;
            textName.Text = inputNamaKaryawan.Text;
            textGajiPokok.Text = $"Rp.{gajiPokok:N0}";
            textTunjanganJabatan.Text = $"Rp. {tunjanganJabatan:N0}";
            textTunjanganPendidikan.Text = $"Rp. {tunjanganPendidikan:N0}";
            textUpahLembur.Text = $"Rp. {totalLembur:N0}";
            totalGaji = gajiPokok + tunjanganJabatan + tunjanganPendidikan + totalLembur;
            textTotalGaji.Text = $"Rp. {totalGaji:N0}";

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            inputNip.Text = "";
            inputNamaKaryawan.Text = "";
            inputJamKerja.Text = "";
            inputGolongan.SelectedIndex = -1;
            inputPendidikan.SelectedIndex = -1;
            textNip.Text = "";
            textName.Text = "";
            textGajiPokok.Text = "";
            textTunjanganJabatan.Text = "";
            textTunjanganPendidikan.Text = "";
            textUpahLembur.Text = "";
            textTotalGaji.Text = "";
            inputNip.Focus();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xaml.Permissions;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public void Total()
        {
            int subtotalMakanan = 0, subtotalMinuman = 0;

            // Ambil nilai dari textbox subtotal
            int.TryParse(txtsubtotalmakanan.Text, out subtotalMakanan);
            int.TryParse(txtsubtotalminuman.Text, out subtotalMinuman);

            int total = subtotalMakanan + subtotalMinuman;

            // Simpan hasil ke textbox total
            txttotal.Text = total.ToString();
        }

        public void HitungKembalian()
        {
            int total = 0, bayar = 0, kembali = 0;

            // Ambil total dari txttotal (hasil subtotal makanan + minuman)
            int.TryParse(txttotal.Text, out total);
            int.TryParse(txtbayar.Text, out bayar);

            if (string.IsNullOrWhiteSpace(txtbayar.Text))
            {
                txtkembali.Text = "";
                return;
            }

            kembali = bayar - total;

            if (kembali < 0)
            {
                // tampilkan minus dan info uang kurang
                txtkembali.Text = $"-Rp {Math.Abs(kembali)} (Uang kurang)";
            }
            else
            {
                // tampilkan normal
                txtkembali.Text = $"Rp {kembali}";
            }
        }
        private void HitungSubtotalMakanan()
        {
            int hargaMakanan = 0;
            int jumlahMakanan = (int)nummakanan.Value;

            int.TryParse(txthargamakanan.Text, out hargaMakanan);

            int subtotalMakanan = hargaMakanan * jumlahMakanan;
            txtsubtotalmakanan.Text = subtotalMakanan.ToString();

            Total(); // update total
        }

        // Hitung subtotal minuman
        private void HitungSubtotalMinuman()
        {
            int hargaMinuman = 0;
            int jumlahMinuman = (int)numminuman.Value;

            int.TryParse(txthargaminuman.Text, out hargaMinuman);

            int subtotalMinuman = hargaMinuman * jumlahMinuman;
            txtsubtotalminuman.Text = subtotalMinuman.ToString();

            Total(); // update total
        }



        public Form2()
        {
            InitializeComponent();

        }

        // Pilih makanan → harga keluar
        private void cmbmakanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pilih;
            pilih = cmbmakanan.SelectedIndex;
            switch (pilih)
            {
                case 0:
                    txthargamakanan.Text = "20000";
                    break;
                case 1:
                    txthargamakanan.Text = "18000";
                    break;
                case 2:
                    txthargamakanan.Text = "15000";
                    break;
                case 3:
                    txthargamakanan.Text = "12000";
                    break;
                case 4:
                    txthargamakanan.Text = "25000";
                    break;
            }
            Total();
        }

        // Kalau jumlah berubah
        private void nummakanan_ValueChanged(object sender, EventArgs e)
        {
            HitungSubtotalMakanan();
        }


        // Tombol keluar
        private void btnkeluar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin keluar?",
                "Konfirmasi Keluar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // keluar
            }
            // kalau pilih No, tidak melakukan apa-apa
        }

        private void txthargamakanan_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbminuman_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pilih;
            pilih = cmbminuman.SelectedIndex;

            switch (pilih)
            {
                case 0:
                    txthargaminuman.Text = "4000"; // Es Teh
                    break;
                case 1:
                    txthargaminuman.Text = "6000"; // Es Jeruk
                    break;
                case 2:
                    txthargaminuman.Text = "10000"; // Jus Alpukat
                    break;
                case 3:
                    txthargaminuman.Text = "5000"; // Jus Alpukat
                    break;
                case 4:
                    txthargaminuman.Text = "7000"; // Jus Alpukat
                    break;

            }
            Total();
        }

        private void numminuman_ValueChanged(object sender, EventArgs e)
        {
            HitungSubtotalMinuman();
        }


        private void txthargaminuman_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsubtotalminuman_TextChanged(object sender, EventArgs e)
        {

        }

        private void txthargaminuman_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txthargamakanan_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtsubtotalmakanan_TextChanged(object sender, EventArgs e)
        {
            int pilih;
            pilih = cmbmakanan.SelectedIndex;
            switch (pilih)
            {
                case 0:
                    txthargamakanan.Text = "20000";
                    break;
                case 1:
                    txthargamakanan.Text = "18000";
                    break;
                case 2:
                    txthargamakanan.Text = "15000";
                    break;
                case 3:
                    txthargamakanan.Text = "12000";
                    break;
                case 4:
                    txthargamakanan.Text = "25000";
                    break;
            }
            HitungSubtotalMakanan();
        }

        private void txtsubtotalminuman_TextChanged_1(object sender, EventArgs e)
        {
            int pilih;
            pilih = cmbminuman.SelectedIndex;

            switch (pilih)
            {
                case 0:
                    txthargaminuman.Text = "4000"; // Es Teh
                    break;
                case 1:
                    txthargaminuman.Text = "6000"; // Es Jeruk
                    break;
                case 2:
                    txthargaminuman.Text = "10000"; // Jus Alpukat
                    break;
                case 3:
                    txthargaminuman.Text = "5000"; // Teh Botol
                    break;
                case 4:
                    txthargaminuman.Text = "7000"; // Kopi
                    break;
            }
            HitungSubtotalMinuman();
        }

        private void txthargamakanan_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnproses_Click(object sender, EventArgs e)
        {
            // Hitung subtotal makanan & minuman
            HitungSubtotalMakanan();
            HitungSubtotalMinuman();

            // Hitung total
            Total();

            // Hitung kembalian (kalau sudah ada input bayar)
            HitungKembalian();

            // Ambil data
            string makanan = cmbmakanan.SelectedItem?.ToString() ?? "-";
            string minuman = cmbminuman.SelectedItem?.ToString() ?? "-";
            string hargaMakanan = txthargamakanan.Text;
            string hargaMinuman = txthargaminuman.Text;
            string subtotalMakanan = txtsubtotalmakanan.Text;
            string subtotalMinuman = txtsubtotalminuman.Text;
            string total = txttotal.Text;
            string bayar = txtbayar.Text;
            string kembali = txtkembali.Text;

            // ✅ Ambil nama kasir dari TextBox
            string kasir = txtnamakasir.Text;

            string waktu = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            // STRUK dengan format rapi
            string struk =
                "             WM29\n" +
                "   Jl. Soekarno, Purwokerto\n" +
                "-----------------------------------\n" +
                $"Tanggal : {waktu}\n" +
                $"Nama Kasir   : {kasir}\n" +   // ✅ nama kasir tampil di struk
                "-----------------------------------\n" +
                makanan.PadRight(15) + $"{nummakanan.Value} x Rp{hargaMakanan}".PadLeft(15) + "\n" +
                minuman.PadRight(15) + $"{numminuman.Value} x Rp{hargaMinuman}".PadLeft(15) + "\n" +
                "-----------------------------------\n" +
                "TOTAL".PadRight(15) + $"Rp {total}".PadLeft(15) + "\n" +
                "BAYAR".PadRight(15) + $"Rp {bayar}".PadLeft(15) + "\n" +
                "KEMBALI".PadRight(15) + $"{kembali}".PadLeft(15) + "\n" +
                "-----------------------------------\n" +
                "   Terima Kasih sudah berbelanja\n" +
                "            di WM29!\n";

            // Tampilkan struk di MessageBox
            MessageBox.Show(struk, "Struk Penjualan", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Setelah pesan OK → bersihkan form
            btnclear_Click(null, null);
        }


        private void txttotal_TextChanged_1(object sender, EventArgs e)
        {
            int total = 0, bayar = 0, kembali = 0;

            // Ambil total belanja
            int.TryParse(txttotal.Text, out total);

            // Ambil uang bayar
            int.TryParse(txtbayar.Text, out bayar);

            // Hitung kembalian
            kembali = bayar - total;
        }

        private void txtbayar_TextChanged(object sender, EventArgs e)
        {
            HitungKembalian();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // Reset ComboBox
            cmbmakanan.SelectedIndex = -1;
            cmbminuman.SelectedIndex = -1;

            // Kosongkan TextBox harga & subtotal
            txthargamakanan.Clear();
            txthargaminuman.Clear();
            txtsubtotalmakanan.Clear();
            txtsubtotalminuman.Clear();

            // Reset NumericUpDown ke 0
            nummakanan.Value = 0;
            numminuman.Value = 0;

            // Kosongkan total, bayar, dan kembalian
            txttotal.Clear();
            txtbayar.Clear();
            txtkembali.Clear();

            // Setelah clear → disable lagi tombol clear & keluar (opsional)
        }



        private void txtkembali_TextChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void txtnamakasir_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
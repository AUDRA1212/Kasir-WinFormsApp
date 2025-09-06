namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtpassword.Text;

            // Ganti dengan nama kamu sendiri
            if (username == "audra" && password == "audra")
            {
                MessageBox.Show("Login berhasil!", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Buka form kasir setelah login berhasil
                Form2 kasir = new Form2(); // ? perbaikan
                kasir.Show();
                this.Hide(); // sembunyikan form login
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Clear();
                txtpassword.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

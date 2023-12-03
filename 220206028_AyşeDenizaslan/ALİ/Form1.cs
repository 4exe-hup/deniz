using System.Timers;

namespace ALİ
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer bildirimTimer;

        public Form1()
        {
            InitializeComponent();

            bildirimTimer = new System.Timers.Timer();
            bildirimTimer.Elapsed += new ElapsedEventHandler(BildirimGonder);


        }
        private void BildirimGonder(object sender, ElapsedEventArgs e)
        {
            // Bildirim gönderme kodu buraya gelecek
            // Bu kısımda kullanıcının bilgisayarına bildirim gönderme işlemini gerçekleştirin
            MessageBox.Show("Bildirim: Bilgisayarınıza bir mesaj geldi!");
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == null || string.IsNullOrEmpty(textBox1.Text) || numericUpDown1.Value == null || numericUpDown1.Value == 0)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int saatAraligi = (int)numericUpDown1.Value;
                string isim = textBox1.Text;
                // Timer'ı ayarla
                bildirimTimer.Interval = saatAraligi * 60 * 60 * 1000; // Saati milisaniyeye çevir
                bildirimTimer.Enabled = true;

                MessageBox.Show($"Bildirim her {saatAraligi} saatte bir gönderilecek.");

                Form2 form2 = new Form2(isim, saatAraligi);
                form2.Show();
                
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ALİ
{
    public partial class Form2 : Form
    {

        private int _kere;
        private string _isim;


        public Form2(string isim, int kere)
        {

            InitializeComponent();
            label8.Text = "SELAM " + isim;

            if (kere == 1 || kere == 2)
            {
                label7.Text = "size göre günlük olarak ortalama 4 L su içmelisiniz";
                label3.Text = "seçtiğiniz hatırlatma aralığı çok uygundu !";
            }
            else if (kere == 3 || kere == 4)
            {
                label7.Text = "size göre günlük olarak ortalama 3 L su içmelisiniz";
                label3.Text = "seçtiğiniz hatırlatma aralığı orta ile uygundu !";
            }
            else if (kere == 5 || kere == 6)
            {
                label7.Text = "size göre günlük olarak ortalama 2 L su içmelisiniz";
                label3.Text = "seçtiğiniz hatırlatma aralığı sağlınız için uygun olmayabilir !";
            }
            else if (kere == 7 || kere == 8)
            {
                label7.Text = "size göre günlük olarak ortalama 1.5 L su içmelisiniz";
                label3.Text = "seçtiğiniz hatırlatma aralığı tehlikelidir !";
            }
            else
            {
                label7.Text = "size göre günlük olarak ortalama 0.5 L su içmelisiniz";
                label3.Text = "seçtiğiniz hatırlatma aralığı çok tehlikelidir ! hemen değiştirin";
            }
            DateTime bugun = DateTime.Now;

            // Günü kontrol et
            if (bugun.DayOfWeek == DayOfWeek.Saturday || bugun.DayOfWeek == DayOfWeek.Sunday)
            {
                label4.Text = "Bugün Cumartesi veya Pazar! boş zamanınızda daha fazla su içebilirsiniz ";

            }
            else
            {
                label4.Text = "Bugün Hafta İçi. işte yada okulda , su içmeyi unutmayınız !";

            }


        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form1'in referansını alarak kapatma işlemi
            Form1 form1 = Application.OpenForms["Form1"] as Form1;

            if (form1 != null)
            {
                form1.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

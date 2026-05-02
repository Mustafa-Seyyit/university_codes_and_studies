using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FormKronometre : Form
    {
        public FormKronometre()
        {
            InitializeComponent();
        }

        private void timerTarihSaat_Tick(object sender, EventArgs e)
        {
            lblAnikTarih.Text = DateTime.Now.ToLongDateString();//Tarih+gün
            lblAnlikSaat.Text = DateTime.Now.ToLongTimeString(); //saat-dakika-saniye
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //1
            Application.Exit();


            //Close(); //Şu an çalıştığımız form Main form olduğu için eğer bu formu kapatırsam otomatik olarak uygulamada kapanır.
        }

        private void FormKronometre_Load(object sender, EventArgs e)
        {
            timerTarihSaat.Start();//anlık tarih ve saati göstermek için timer'ı başlatıyoruz.

        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timerKronometre.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timerKronometre.Stop();
        }

        KronometreData kronoData = new KronometreData();

        private void timerKronometre_Tick(object sender, EventArgs e)
        {

            kronoData.salise++;

            if(kronoData.salise == 60)
            {
                kronoData.salise = 0;
                kronoData.saniye++;
            }

            if(kronoData.saniye == 60)
            {
                kronoData.saniye = 0;
                kronoData.dakika++;
            }

            if(kronoData.dakika == 60)
            {
                kronoData.dakika = 0;
                kronoData.saat++;
            }

            fillKronoDatatoLabels();
        }

        public void fillKronoDatatoLabels()
        {
            lblSalise.Text = String.Format("{0:00}", kronoData.salise);
            lblSaniye.Text = String.Format("{0:00}", kronoData.saniye);
            lblDakika.Text = String.Format("{0:00}", kronoData.dakika);
            lblSaat.Text = String.Format("{0:00}", kronoData.saat);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            lstSureler.Items.Add((lstSureler.Items.Count + 1) +"-"+kronoData.ToString());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lstSureler.Items.Clear();
            kronoData = new KronometreData();
            fillKronoDatatoLabels();
            timerKronometre.Stop();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            using(SaveFileDialog sfd = new SaveFileDialog() { FileName = "Sonuclar.txt",Filter = "Text File|*.txt", ValidateNames = true })
            {

                if(sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
                {

                    StreamWriter sw = new StreamWriter(sfd.FileName);


                    foreach (var item in lstSureler.Items)
                        sw.WriteLine(item.ToString());


                    sw.WriteLine(System.Environment.NewLine+" "+DateTime.Now.ToShortDateString()+" "+DateTime.Now.ToLongTimeString());


                    sw.Dispose();
                    MessageBox.Show("File is saved successfully");

                }


            }
        }
    }
}

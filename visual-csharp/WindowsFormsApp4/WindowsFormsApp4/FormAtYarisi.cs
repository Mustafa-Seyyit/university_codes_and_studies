using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FormAtYarisi : Form
    {
        public FormAtYarisi()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timerRace2.Start();
        }

        private void timerRace2_Tick(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            int maxStepSize = 20; //ne kadar büyük olursa atlar o kadar hızlı hareket eder.


            PictureBox leaderHorse = null; //önde giden
            PictureBox winnerHorse = null; // kazanan

            foreach(PictureBox pbHorse in new [] { pbHorse1,pbHorse2,pbHorse3,pbHorse4 })
            {
                pbHorse.Location = new Point(pbHorse.Location.X + rnd1.Next(0, rnd2.Next(0, maxStepSize)), pbHorse.Location.Y);

                if (leaderHorse == null || pbHorse.Location.X > leaderHorse.Location.X)
                    leaderHorse = pbHorse;

                if (pbHorse.Location.X + pbHorse.Width >= txtFinishLine.Location.X) //kontrol edilen At finish çizgisini geçti mi?
                    if (winnerHorse == null || pbHorse.Location.X > winnerHorse.Location.X) //winenr horse null ise direkt winner horse olarak at değilse yani winnerhorse daha önce başka bir picturebox ise bu sefer aralarında karşılaştırma yap. Hangisi finish çizgisini daha fazla geçtiyse onu kazanan yap.
                        winnerHorse = pbHorse;

            }


            //buraya gelindiğinde Leader Horse içinde en önde giden at vardır
            if(leaderHorse != null)
            {
                lblRaceResult.Text = leaderHorse.Name + "Yarışı Önde Götürüyor";
            }

            if (winnerHorse != null)
            {
                lblRaceResult.Text = "Yarışı " + winnerHorse.Name + " Kazandı";

                timerRace2.Stop();
            }
        }
    }
}

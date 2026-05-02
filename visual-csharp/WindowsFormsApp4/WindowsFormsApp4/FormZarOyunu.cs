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
    public partial class FormZarOyunu : Form
    {
        public FormZarOyunu()
        {
            InitializeComponent();
        }

        int order = 1;//hangi kullanıcıda sıra olduğunu belirtir.
        private void btnP1Roll_Click(object sender, EventArgs e)
        {
            order = 1;//sıra 1. kullanıcıda

            timerDice.Start();//timer'ı başlat

        }

        private void btnP2Roll_Click(object sender, EventArgs e)
        {

            order = 2;//sıra 2. kullanıcıda
            timerDice.Start();//timer'ı başlat
        }


        int diceCounter = 0;//zarlar ne kadar süreyle sallansın. süreyi arttırısanız zarlar daha uzun süre sallanacak
        int p1TotalScore = 0;
        int p2TotalScore = 0;
        int winScore = 10;

        private void timerDice_Tick(object sender, EventArgs e)
        {
            diceCounter++;
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 7);//1-6 arasında değer üret
            int dice2= rnd.Next(1, 7);

            pbDice1.Image = (Image)Properties.Resources.ResourceManager.GetObject("dice"+dice1);//
            pbDice2.Image = (Image)Properties.Resources.ResourceManager.GetObject("dice"+dice2);//


            if(diceCounter == 30)
            { // artık zarların durması lazım


                if(order == 1)
                {
                    p1TotalScore += dice1 + dice2;
                    lblP1Dice1.Text = dice1.ToString();
                    lblP1Dice2.Text = dice2.ToString();
                    btnP1Roll.Enabled = false;//sıra artık 2. kullanıcıda
                    btnP2Roll.Enabled = true;//sıra 2. kullanıcıya geçsin
                    lblP1TotalScore.Text = p1TotalScore.ToString();

                }
                else if (order == 2)
                {
                    p2TotalScore += dice1 + dice2;
                    lblP2Dice1.Text = dice1.ToString();
                    lblP2Dice2.Text = dice2.ToString();
                    btnP1Roll.Enabled = true;//sıra artık 2. kullanıcıda
                    btnP2Roll.Enabled = false;//sıra 2. kullanıcıya geçsin
                    lblP2TotalScore.Text = p2TotalScore.ToString();

                    //2 kullanıcıda zarı attıktan sonra kazananı bulmamız gerekiyor
                    if(p1TotalScore > winScore || p2TotalScore > winScore)
                    if(p1TotalScore > p2TotalScore)
                        {
                            lblPlayerStatus.Text = "Kazanan 1. Kullanıcı";
                            MessageBox.Show("1. Kullanıcı Kazandı");
                        }
                        else {
                            lblPlayerStatus.Text = "Kazanan 2. Kullanıcı";
                            MessageBox.Show("2. Kullanıcı Kazandı");
                        }
                }

                order = order == 1 ? 2 : 1; //Sıra 1. kullanıcıdayse 2. kullancıya veya tam tersi olacak şekilde sıra değişikli yapıyoruz
                lblPlayerStatus.Text = order == 1 ? "Sıra 1. Kullanıcıda" : "Sıra 2. Kullanıcıda";
                diceCounter = 0;
                timerDice.Stop();

               
            }
        }

        private void FormZarOyunu_Load(object sender, EventArgs e)
        {
            btnP1Roll.Enabled = true;//sıra1. kullanıcıda.
            btnP2Roll.Enabled = false;
        }
    }
}

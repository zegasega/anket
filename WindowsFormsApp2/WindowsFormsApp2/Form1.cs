using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;
        int percentage;
        int[] userAnswers;

        public Form1()
        {
            InitializeComponent();
            totalQuestions = 10;
            userAnswers = new int[totalQuestions];
            askQuestions(questionNumber);
        }

       
        private void checkAnswersEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            userAnswers[questionNumber - 1] = buttonTag;

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
                MessageBox.Show(
                    "Sorular Bitti" + Environment.NewLine +
                    "Doğru Cevap Sayısı : " + score + Environment.NewLine +
                    "Toplam Doğru Oranı: " + percentage + "%" + Environment.NewLine +
                    "Çıkmak İçin Tamama Bas"
                );
                
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }

            questionNumber++;
            askQuestions(questionNumber);
        }

        private void askQuestions(int qnum)
        {

            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.bannerlord;

                    lblQuestion.Text = "Mount and Blade 2 Bannerlord Oyununda Kaç Farklı Krallık Bulunmaktadır";

                    button1.Text = "3";
                    button2.Text = "5";
                    button3.Text = "8";
                    button4.Text = "10";

                    correctAnswer = 3;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.rdr2;

                    lblQuestion.Text = "Red Dead Redemption Oyunundaki Ana Karakterin Atının Adı Nedir";

                    button1.Text = "Karanlık";
                    button2.Text = "Gölge";
                    button3.Text = "Bozkır";
                    button4.Text = "Buçuk";

                    correctAnswer = 4;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.witcher;

                    lblQuestion.Text = "The Witcher 3'deki Ana Karakterimizin Adı Nedir";

                    button1.Text = "Radovid";
                    button2.Text = "Dandelion";
                    button3.Text = "Geralt";
                    button4.Text = "Vesemir";

                    correctAnswer = 3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.pbg;

                    lblQuestion.Text = "FPS Oyunu Olan PUBG'nin Açılımı Nedir";

                    button1.Text = "PlayerUnknown's Battlegrounds";
                    button2.Text = "Pretty Unreal Battle Game";
                    button3.Text = "Pro Ultimate Battle Ground";
                    button4.Text = "Popular Undercover Battle Game";

                    correctAnswer = 1;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.csgo;

                    lblQuestion.Text = "Counter Strike Global Offensive(CSGO) Ne Zaman Çıkmıştır";

                    button1.Text = "2010";
                    button2.Text = "2012";
                    button3.Text = "2014";
                    button4.Text = "2016";

                    correctAnswer = 2;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.fps;

                    lblQuestion.Text = "FPS Kısaltması Hangi Oyun Türünü İfade Eder";

                    button1.Text = "Fantasy Puzzle Solver";
                    button2.Text = "Fast Paced Simulation";
                    button3.Text = " First Person Shooter";
                    button4.Text = "Fighting Platform Strategy";

                    correctAnswer = 3;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.gta5;

                    lblQuestion.Text = "GTA V Geçtiği Kurgusal Şehir Hangisidir";

                    button1.Text = "Los Santos";
                    button2.Text = "San Fierro";
                    button3.Text = "Vice City";
                    button4.Text = "Liberty City";

                    correctAnswer = 1;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.tommyvercetti;

                    lblQuestion.Text = "GTA: Vice City Oyununun Ana Karakteri Kimdir ";

                    button1.Text = "Big Smoke";
                    button2.Text = "Lance Vance";
                    button3.Text = "Carl Johnson";
                    button4.Text = "Tommy Vercetti";

                    correctAnswer = 4;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.crysis;

                    lblQuestion.Text = "Crysis Oyunu Hangi Oyun Motoruyla Geliştirilmiştir";

                    button1.Text = "Frostbite Engine";
                    button2.Text = "Unreal Engine";
                    button3.Text = "CryEngine";
                    button4.Text = "Source Engine";

                    correctAnswer = 3;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.detroit;

                    lblQuestion.Text = "Detroit Become Human Oyununda İnsanlarla Androidler Arasındakı İlişki Nasıl Tasvir Edilir";

                    button1.Text = "Tamamen eşitlik";
                    button2.Text = "Dostluk";
                    button3.Text = "Karışık ve çeşitli";
                    button4.Text = "Sadece düşmanlık";

                    correctAnswer = 3;
                    break;




            }





        }
    }
}

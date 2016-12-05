using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
namespace CSGO_B_exicute
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Click(object sender, EventArgs e)
        {


            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            Font drawFont = new Font("Times New Roman", 12, FontStyle.Regular);
            SolidBrush drawBrush = new SolidBrush(Color.LimeGreen);
            Font dnewFont = new Font("Times New Roman", 20, FontStyle.Regular);
            SolidBrush newBrush = new SolidBrush(Color.LimeGreen);
            Pen drawPen = new Pen(Color.White, 2);
            Pen blackkPen = new Pen(Color.Black, 2);
            SolidBrush blackBrush = new SolidBrush(Color.Black);

            Thread.Sleep(500);
            g.DrawString("Here is your task:", drawFont, drawBrush, 10, 10);
            Thread.Sleep(1500);
            g.DrawString("Attack the death star using your lazers to take down there sheilds", drawFont, drawBrush, 10, 50);
            Thread.Sleep(2000);
            g.DrawString("Then, use your torbedoes to destroy the death star.", drawFont, drawBrush, 10, 90);
            Thread.Sleep(2000);
            g.Clear(Color.Black);
            Thread.Sleep(2000);

            Thread.Sleep(1000);
            g.Clear(Color.Black);

            g.DrawEllipse(drawPen, 100, 100, 250, 250);
            g.DrawRectangle(drawPen, 215, 100, 25, 100);
            g.FillRectangle(blackBrush, 215, 76, 25, 25);

            int y = 45;

            //test
            for (int x = this.Width - 10; x >= 195; x = x - 1)
            {
                //act
                g.Clear(Color.Black);
                g.DrawPie(drawPen, x, y, 50, 50, 20, 40);
                g.DrawEllipse(drawPen, 100, 100, 250, 250);
                g.DrawRectangle(drawPen, 215, 100, 25, 100);
                g.FillRectangle(blackBrush, 215, 93, 25, 25);
                Thread.Sleep(10);
            }
            int bomby = 45;

            SoundPlayer play = new SoundPlayer(Properties.Resources.lazer);
            play.Play();

            while (bomby < 190)
            {

                //act
                Thread.Sleep(10);
                g.Clear(Color.Black);
                g.FillEllipse(drawBrush, 215, bomby, 25, 25);
                g.DrawPie(drawPen, 215, 45, 50, 50, 20, 40);
                g.DrawEllipse(drawPen, 100, 100, 250, 250);
                g.DrawRectangle(drawPen, 215, 100, 25, 100);
                g.FillRectangle(blackBrush, 215, 93, 25, 25);

                bomby++;

            }
            SoundPlayer player = new SoundPlayer(Properties.Resources.boom);
            player.Play();
            for (int x = 1; x < 150; x++)
            {
                //act
                
                Thread.Sleep(10);
                g.Clear(Color.Black);
                g.FillEllipse(drawBrush, 223 - x / 2, 190 - x / 2, 10 + x, 10 + x);
                g.DrawPie(drawPen, 215, 45, 50, 50, 20, 40);
                g.DrawEllipse(drawPen, 100, 100, 250, 250);
                g.DrawRectangle(drawPen, 215, 100, 25, 100);
                g.FillRectangle(blackBrush, 215, 93, 25, 25);
               


            }
            Thread.Sleep(1000);
            g.Clear(Color.Black);
            g.DrawString("GOOD LUCK", dnewFont, newBrush, 200, 40);
            Thread.Sleep(1000);














        }
    }
}
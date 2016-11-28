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


            Thread.Sleep(500);
            g.DrawString("Here is your task:", drawFont, drawBrush, 10, 10);
            Thread.Sleep(1500);
            g.DrawString("Attack the death star using your lazers to take down there sheilds", drawFont, drawBrush, 10, 50);
            Thread.Sleep(2000);
            g.DrawString("Then, use your torbedoes to destroy the death star.", drawFont, drawBrush, 10, 90);
            Thread.Sleep(2000);
            g.Clear(Color.Black);
            Thread.Sleep(2000);
            g.DrawString("GOOD LUCK", dnewFont, newBrush, 200, 40);
            g.Clear(Color.Black);     
               















        }
    }
}

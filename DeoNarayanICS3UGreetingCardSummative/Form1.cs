using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

/*
Created By: Deo Narayan
Date: September 24, 2018
Description: This is a program for a Christmas card which begins as an envelope with a snowing gif. Once the envelope is 
clicked, a Christmas card appears with deck the halls playing, a talking Santa, and a Christmas tree. Once the program is done,
click the run again button to run the program again.
*/


namespace DeoNarayanICS3UGreetingCardSummative
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void drawLabel_Click(object sender, EventArgs e)
        {

        }

        private void Envolope_Click(object sender, EventArgs e)
        {
            //Refresh();
            //Graphics Variables
            //local graphics variable of the form
            Graphics gForm = this.CreateGraphics();

            //local graphics variable of the christmasTreeLabel
            Graphics gChristmasTreeLabel = christmasTreeLabel.CreateGraphics();

            //pen for creating the white border of the christmas card
            Pen whitePen = new Pen(Color.White, 10);

            //font and brush for christmas card title
            Font timesFont = new Font("TimesNewRoman", 35, FontStyle.Bold);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            
            //font and brush for text in the speech bubble
            Font arialFont = new Font("Arial", 8, FontStyle.Bold);
            SolidBrush blackBrush = new SolidBrush(Color.Black);

            //brushes for alternating ornament colours
            SolidBrush aquaBrush = new SolidBrush(Color.Aqua);
            SolidBrush redBrush = new SolidBrush(Color.Red);

            //removing (making invisible) preexisting labels to 'reset' the form
            envelopeLabel.Visible = false;
            fallingSnowImage.Visible = false;

            //Christmas Song
            //deck the halls plays as the card 'opens'
            SoundPlayer christmasSongPlayer = new SoundPlayer(Properties.Resources.ChristmasSong);
            christmasSongPlayer.Play();

            //Features of the Card (minus the title)
            //creates red background
            gForm.Clear(Color.Red);

            //makes santa and the christmas tree visible (before the title appears)
            santaLabel.Visible = true;
            christmasTreeLabel.Visible = true;
            santaLabel.Refresh();
            christmasTreeLabel.Refresh();

            //Christmas Card Border
            gForm.DrawLine(whitePen, 0, 323, 500, 323);
            gForm.DrawLine(whitePen, 5, 0, 5, 355);
            gForm.DrawLine(whitePen, 481, 0, 481, 325);

            //Creates Title (letter by letter; aligned with the music pulses)
            //draws 'Merry'
            gForm.DrawString("M", timesFont, whiteBrush, 60, 50);
            Thread.Sleep(400);
            gForm.DrawString("e", timesFont, whiteBrush, 100, 50);
            Thread.Sleep(200);
            gForm.DrawString("r", timesFont, whiteBrush, 127, 50);
            Thread.Sleep(400);
            gForm.DrawString("r", timesFont, whiteBrush, 145, 50);
            Thread.Sleep(400);
            gForm.DrawString("y", timesFont, whiteBrush, 164, 50);
            Thread.Sleep(1600);

            //draws 'Christmas'
            gForm.DrawString("C", timesFont, whiteBrush, 200, 50);
            Thread.Sleep(200);
            gForm.DrawString("h", timesFont, whiteBrush, 235, 50);
            Thread.Sleep(200);
            gForm.DrawString("r", timesFont, whiteBrush, 262, 50);
            Thread.Sleep(200);
            gForm.DrawString("i", timesFont, whiteBrush, 279, 50);
            Thread.Sleep(200);
            gForm.DrawString("s", timesFont, whiteBrush, 291, 50);
            Thread.Sleep(450);
            gForm.DrawString("t", timesFont, whiteBrush, 316, 50);
            Thread.Sleep(200);
            gForm.DrawString("m", timesFont, whiteBrush, 330, 50);
            Thread.Sleep(350);
            gForm.DrawString("a", timesFont, whiteBrush, 370, 50);
            Thread.Sleep(350);
            gForm.DrawString("s", timesFont, whiteBrush, 397, 50);
            Thread.Sleep(1500);

            //Santa Sound
            //santa speaks immediately after deck the halls finishes
            SoundPlayer HoHoHoPlayer = new SoundPlayer(Properties.Resources.HoHoHo);
            HoHoHoPlayer.Play();

            //Speech Bubble
            //draws speech bubble
            gForm.FillEllipse(whiteBrush, 270, 135, 100, 40);
            gForm.FillPie(whiteBrush, 315, 152, 105, 65, 200, 40);

            //drawstring 'Merry Christmas' on the speech bubble
            gForm.DrawString("Merry Christmas", arialFont, blackBrush, 276, 149);
            Thread.Sleep(1700);

            //draws the speech bubble again to erase the text
            gForm.FillEllipse(whiteBrush, 270, 135, 100, 40);
            gForm.FillPie(whiteBrush, 315, 152, 105, 65, 200, 40);

            //drawstring 'Ho Ho Ho' appears when santa says it
            gForm.DrawString("Ho Ho Ho", arialFont, blackBrush, 294, 149);
            Thread.Sleep(2000);

            //removes speech bubble from screen once santa stops talking
            gForm.FillEllipse(redBrush, 270, 135, 100, 40);
            gForm.FillPie(redBrush, 315, 152, 105, 65, 200, 40);

            //Christmas Ornaments
            //christmas ornaments alternate colours
            gChristmasTreeLabel.FillEllipse(redBrush, 35, 60, 15, 15);
            gChristmasTreeLabel.FillEllipse(aquaBrush, 70, 68, 15, 15);
            gChristmasTreeLabel.FillEllipse(redBrush, 45, 100, 15, 15);
            Thread.Sleep(750);
            gChristmasTreeLabel.FillEllipse(aquaBrush, 35, 60, 15, 15);
            gChristmasTreeLabel.FillEllipse(redBrush, 70, 68, 15, 15);
            gChristmasTreeLabel.FillEllipse(aquaBrush, 45, 100, 15, 15);
            Thread.Sleep(750);
            gChristmasTreeLabel.FillEllipse(redBrush, 35, 60, 15, 15);
            gChristmasTreeLabel.FillEllipse(aquaBrush, 70, 68, 15, 15);
            gChristmasTreeLabel.FillEllipse(redBrush, 45, 100, 15, 15);
            Thread.Sleep(750);
            gChristmasTreeLabel.FillEllipse(aquaBrush, 35, 60, 15, 15);
            gChristmasTreeLabel.FillEllipse(redBrush, 70, 68, 15, 15);
            gChristmasTreeLabel.FillEllipse(aquaBrush, 45, 100, 15, 15);
            Thread.Sleep(750);
            gChristmasTreeLabel.FillEllipse(redBrush, 35, 60, 15, 15);
            gChristmasTreeLabel.FillEllipse(aquaBrush, 70, 68, 15, 15);
            gChristmasTreeLabel.FillEllipse(redBrush, 45, 100, 15, 15);
            Thread.Sleep(750);
            gChristmasTreeLabel.FillEllipse(aquaBrush, 35, 60, 15, 15);
            gChristmasTreeLabel.FillEllipse(redBrush, 70, 68, 15, 15);
            gChristmasTreeLabel.FillEllipse(aquaBrush, 45, 100, 15, 15);
            Thread.Sleep(750);
            gChristmasTreeLabel.FillEllipse(redBrush, 35, 60, 15, 15);
            gChristmasTreeLabel.FillEllipse(aquaBrush, 70, 68, 15, 15);
            gChristmasTreeLabel.FillEllipse(redBrush, 45, 100, 15, 15);
            Thread.Sleep(750);
            gChristmasTreeLabel.FillEllipse(aquaBrush, 35, 60, 15, 15);
            gChristmasTreeLabel.FillEllipse(redBrush, 70, 68, 15, 15);
            gChristmasTreeLabel.FillEllipse(aquaBrush, 45, 100, 15, 15);
            Thread.Sleep(750);
            gChristmasTreeLabel.FillEllipse(redBrush, 35, 60, 15, 15);
            gChristmasTreeLabel.FillEllipse(aquaBrush, 70, 68, 15, 15);
            gChristmasTreeLabel.FillEllipse(redBrush, 45, 100, 15, 15);
            Thread.Sleep(750);
            gChristmasTreeLabel.FillEllipse(aquaBrush, 35, 60, 15, 15);
            gChristmasTreeLabel.FillEllipse(redBrush, 70, 68, 15, 15);
            gChristmasTreeLabel.FillEllipse(aquaBrush, 45, 100, 15, 15);
            Thread.Sleep(750);
            gChristmasTreeLabel.FillEllipse(redBrush, 35, 60, 15, 15);
            gChristmasTreeLabel.FillEllipse(aquaBrush, 70, 68, 15, 15);
            gChristmasTreeLabel.FillEllipse(redBrush, 45, 100, 15, 15);
            Thread.Sleep(750);
            gChristmasTreeLabel.FillEllipse(aquaBrush, 35, 60, 15, 15);
            gChristmasTreeLabel.FillEllipse(redBrush, 70, 68, 15, 15);
            gChristmasTreeLabel.FillEllipse(aquaBrush, 45, 100, 15, 15);
            Thread.Sleep(3000);

            //Envolope Label
            //transform evelopeLabel into a small label that says 'run again'
            envelopeLabel.Visible = true;
            envelopeLabel.Image = null;
            envelopeLabel.Text = "Run Again";
            envelopeLabel.BackColor = Color.White;
            envelopeLabel.ForeColor = Color.Black;
            envelopeLabel.Width = this.Width/5;
            envelopeLabel.Height = this.Height/10;
            envelopeLabel.Location = new Point(185, 270);

            //Recreating Christmas Card
            //because I caused the screen to refresh by making changes to the envelopeLabel, I must recreate the features of the card
            //card background red
            gForm.Clear(Color.Red);

            //white border of card
            gForm.DrawLine(whitePen, 0, 323, 500, 323);
            gForm.DrawLine(whitePen, 5, 0, 5, 355);
            gForm.DrawLine(whitePen, 481, 0, 481, 325);

            //draws 'Merry'
            gForm.DrawString("M", timesFont, whiteBrush, 60, 50);
            gForm.DrawString("e", timesFont, whiteBrush, 100, 50);
            gForm.DrawString("r", timesFont, whiteBrush, 127, 50);
            gForm.DrawString("r", timesFont, whiteBrush, 145, 50);
            gForm.DrawString("y", timesFont, whiteBrush, 164, 50);

            //draws 'Christmas'
            gForm.DrawString("C", timesFont, whiteBrush, 200, 50);
            gForm.DrawString("h", timesFont, whiteBrush, 235, 50);
            gForm.DrawString("r", timesFont, whiteBrush, 262, 50);
            gForm.DrawString("i", timesFont, whiteBrush, 279, 50);
            gForm.DrawString("s", timesFont, whiteBrush, 291, 50);
            gForm.DrawString("t", timesFont, whiteBrush, 316, 50);
            gForm.DrawString("m", timesFont, whiteBrush, 330, 50);
            gForm.DrawString("a", timesFont, whiteBrush, 370, 50);
            gForm.DrawString("s", timesFont, whiteBrush, 397, 50);
        }
    }
}

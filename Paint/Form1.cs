using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        bool ShouldPaint { set; get; } = false; //determine whether to paint or not
        private Color brushColor = System.Drawing.Color.Black; // set the drawing color
        private int width; //define brush width
        private int height; //define brush height

        public Form1()
        {
            InitializeComponent();
        }
        // this method is to start drawing when the left mouse button is pressed on the area of drawing
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //Start the drwaing process
            ShouldPaint = true;
        }
        // this method is to stop drawing when the left mouse button is released
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //Start the drwaing process
            ShouldPaint = false;
        }
        // this method is to continue drawing while mouse button is pressed
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Drawing
            if (ShouldPaint)
            {
                using (Graphics graphics = CreateGraphics()) 
                {
                    graphics.FillRectangle(new SolidBrush(brushColor), e.X, e.Y, width, height); //creating a brush with specified width and height
                }
            }
        }
        // this method is for a clear button, which on click erases everything that was drawn from the area 
        private void clear_Click(object sender, EventArgs e)
        {
            using (Graphics graphics = CreateGraphics())
            {
                graphics.Clear(Color.WhiteSmoke);
            }
        }
        // this method determines which color was picked by the user and changes the brush color to the changed one
        private void Button_Click(object sender, EventArgs e)
        {
            //if red was picked
            if(sender == Red)
            {
                brushColor = Color.Red;
            }
            //if orange was picked
            if (sender == Orange)
            {
                brushColor = Color.Orange;
            }
            //if yellow was picked
            if (sender == Yellow)
            {
                brushColor = Color.Yellow;
            }
            //if green was picked
            if (sender == Green)
            {
                brushColor = Color.ForestGreen;
            }
            //if blue was picked
            if (sender == Blue)
            {
                brushColor = Color.SteelBlue;
            }
            //if navy was picked
            if (sender == Navy)
            {
                brushColor = Color.MediumBlue;
            }
            //if purple was picked
            if (sender == Purple)
            {
                brushColor = Color.Indigo;
            }
            //if black was picked
            if (sender == Black)
            {
                brushColor = Color.Black;
            }
            //if white was picked
            if (sender == White)
            {
                brushColor = Color.White;
            }
            //if brown was picked
            if (sender == Brown)
            {
                brushColor = Color.SaddleBrown;
            }
            //if grey was picked
            if (sender == Grey)
            {
                brushColor = Color.DarkGray;
            }
        }
        // this method allows a user to change a brush size depending on the checked radio button
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //if small button is checked
            if(sender == Small)
            {
                width = 5;
                height = 5;
            }
            //if medium button is checked
            if (sender == Medium)
            {
                width = 10;
                height = 10;
            }
            //if large button is checked
            if (sender == Large)
            {
                width = 15;
                height = 15;
            }
        }

    }
}
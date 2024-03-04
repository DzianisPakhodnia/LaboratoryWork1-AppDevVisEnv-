using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Math;
using static LaboratoryWork1_AppDevVisEnv_.Integral;

namespace LaboratoryWork1_AppDevVisEnv_
{
    public partial class Form1 : Form
    { 
        private double x1 { set; get; }
        private double x2 { set; get; }
        private double h { set; get; }
        private double y { set; get; }
        private double area { set; get; } = 0;
        
        public Form1()
        {
            InitializeComponent();
            chart1.Series[0].Points.Clear();

            x1 = Convert.ToDouble(textBoxLowBorder.Text);
            x2 = Convert.ToDouble(textBoxHighBorder.Text);
            h = Convert.ToDouble(textBoxStep.Text);
            
            for (double x = x1; x <= x2; x += h)
            {
                y = mathFunction(x);
                chart1.Series[1].Points.AddXY(x, y);
            }
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButtonMethodTrapezoid_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[1].Points.Clear();
            chart1.Series[0].Points.Clear();
            x1 = Convert.ToDouble(textBoxLowBorder.Text);
            x2 = Convert.ToDouble(textBoxHighBorder.Text);
            h = Convert.ToDouble(textBoxStep.Text);

            label5.Text = Convert.ToString(TrapezoidMethod(ref chart1, x1, x2, h, area));
            
        }

        private void radioButtonMethodLeftRectangles_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[1].Points.Clear();
            chart1.Series[0].Points.Clear();

            x1 = Convert.ToDouble(textBoxLowBorder.Text);
            x2 = Convert.ToDouble(textBoxHighBorder.Text);
            h = Convert.ToDouble(textBoxStep.Text);

            label5.Text= Convert.ToString(leftRectangleMethod(ref chart1, x1, x2, h, area));
        }

        private void radioButtonRightRectangles_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[1].Points.Clear();
            chart1.Series[0].Points.Clear();


            x1 = Convert.ToDouble(textBoxLowBorder.Text);
            x2 = Convert.ToDouble(textBoxHighBorder.Text);
            h = Convert.ToDouble(textBoxStep.Text);

            label5.Text = Convert.ToString(rightRectangleMethod(ref chart1,x1,x2,h,area));
        }
        private void radioButtonMediumRectangle_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[1].Points.Clear();
            chart1.Series[0].Points.Clear();

            x1 = Convert.ToDouble(textBoxLowBorder.Text);
            x2 = Convert.ToDouble(textBoxHighBorder.Text);
            h = Convert.ToDouble(textBoxStep.Text);

            label5.Text = Convert.ToString(middleRectangleMethod(ref chart1, x1, x2,h, area));
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                chart1.Series[0].Enabled = false; 
            }
            else
            {
                chart1.Series[0].Enabled = true; 
            }
        }

        
    }
}

using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;



namespace LaboratoryWork1_AppDevVisEnv_
{
    public partial class Form1 : Form
    {
        
        private Integral integral; 
        private DrawIntegral drawIntegral;
        
        public Form1()
        {
            InitializeComponent();
            chart1.Series[0].Points.Clear();
            double x1 = Convert.ToDouble(textBoxLowBorder.Text);
            double x2 = Convert.ToDouble(textBoxHighBorder.Text);
            double h = Convert.ToDouble(textBoxStep.Text);
            labelLowBorderIntegral.Text = Convert.ToString(x1);
            labelHighBorderIntegral.Text = Convert.ToString(x2);
            integral = new Integral(x1, x2, h);
            
            chart1= new DrawIntegral();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButtonMethodTrapezoid_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[1].Points.Clear();
            chart1.Series[0].Points.Clear();
            double x1 = Convert.ToDouble(textBoxLowBorder.Text);
            double x2 = Convert.ToDouble(textBoxHighBorder.Text);
            double h = Convert.ToDouble(textBoxStep.Text);
            labelLowBorderIntegral.Text = Convert.ToString(x1);
            labelHighBorderIntegral.Text = Convert.ToString(x2);

            labelResult.Text = Convert.ToString(integral.TrapezoidMethod());
            
        }

        private void radioButtonMethodLeftRectangles_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[1].Points.Clear();
            chart1.Series[0].Points.Clear();

            double x1 = Convert.ToDouble(textBoxLowBorder.Text);
            double x2 = Convert.ToDouble(textBoxHighBorder.Text);
            double h = Convert.ToDouble(textBoxStep.Text);
            labelLowBorderIntegral.Text = Convert.ToString(x1);
            labelHighBorderIntegral.Text = Convert.ToString(x2);

            labelResult.Text= Convert.ToString(integral.leftRectangleMethod());
        }

        private void radioButtonRightRectangles_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[1].Points.Clear();
            chart1.Series[0].Points.Clear();


            double x1 = Convert.ToDouble(textBoxLowBorder.Text);
            double x2 = Convert.ToDouble(textBoxHighBorder.Text);
            double h = Convert.ToDouble(textBoxStep.Text);
            labelLowBorderIntegral.Text = Convert.ToString(x1);
            labelHighBorderIntegral.Text = Convert.ToString(x2);

            labelResult.Text = Convert.ToString(integral.rightRectangleMethod());
        }
        private void radioButtonMediumRectangle_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[1].Points.Clear();
            chart1.Series[0].Points.Clear();

            double x1 = Convert.ToDouble(textBoxLowBorder.Text);
            double x2 = Convert.ToDouble(textBoxHighBorder.Text);
            double h = Convert.ToDouble(textBoxStep.Text);
            labelLowBorderIntegral.Text = Convert.ToString(x1);
            labelHighBorderIntegral.Text = Convert.ToString(x2);

            labelResult.Text = Convert.ToString(integral.middleRectangleMethod());
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

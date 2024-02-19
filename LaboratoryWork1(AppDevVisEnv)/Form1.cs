using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace LaboratoryWork1_AppDevVisEnv_
{
    public partial class Form1 : Form
    {
        public enum Mods { LEFT_RECTANGLE_METHOD, MIDDLE_RECTANGLE_METHOD, RIGHT_RECTANGLE_METHOD, TRAPEZOID_METHOD }
        private Mods currentMod = Mods.TRAPEZOID_METHOD;
        public Form1()
        {
            InitializeComponent();
            this.chart1.Series[0].Points.Clear();

            double x1 = Convert.ToDouble(textBoxLowBorder.Text);
            double x2 = Convert.ToDouble(textBoxHighBorder.Text);
            double h = Convert.ToDouble(textBoxStep.Text);
            double y;

            for (double x = x1; x <= x2; x += h)
            {
                y = mathFunction(x);
                this.chart1.Series[1].Points.AddXY(x, y);
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void result_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();
            double x1 = Convert.ToDouble(textBoxLowBorder.Text);
            double x2 = Convert.ToDouble(textBoxHighBorder.Text);
            double h = Convert.ToDouble(textBoxStep.Text);
            double y;
            double area = 0;


            for (double x = x1; x <= x2; x += h)
            {
                switch (currentMod)
                {
                    case Mods.LEFT_RECTANGLE_METHOD: 
                        {

                            y = mathFunction(x);

                            chart1.Series[0].Points.AddXY(x, y);
                            if (x + h <= x2)
                            {
                                chart1.Series[0].Points.AddXY(x + h, y);
                            }

                            area += y * h;          
                            break;
                        }
                    case Mods.MIDDLE_RECTANGLE_METHOD:
                        {
                            y = mathFunction(x + h / 2);

                            chart1.Series[0].Points.AddXY(x, y);
                            if (x + h <= x2)

                            {
                                chart1.Series[0].Points.AddXY(x + h, y);
                            }

                            area += y * h;   
                            break;
                        }
                    case Mods.RIGHT_RECTANGLE_METHOD:
                        {
                            y = mathFunction(x + h);

                            chart1.Series[0].Points.AddXY(x, y);
                            if (x + h <= x2)
                            {
                                chart1.Series[0].Points.AddXY(x + h, y);
                            }

                            area += y * h;   
                            break;
                        }
                    case Mods.TRAPEZOID_METHOD:
                        {
                            y = mathFunction(x);

                            chart1.Series[0].Points.AddXY(x, y);

                            area += h * (mathFunction(x) + mathFunction(x + h)) / 2;   
                            break;
                        }



                }
 
            }
            label5.Text = Convert.ToString(area);
        }

        public double mathFunction(double x)
        {
            return Sin(x) / Sqrt(x);
        }

        private void radioButtonMethodTrapezoid_CheckedChanged(object sender, EventArgs e)
        {
            currentMod = Mods.TRAPEZOID_METHOD;
        }

        private void radioButtonMethodLeftRectangles_CheckedChanged(object sender, EventArgs e)
        {
            currentMod = Mods.LEFT_RECTANGLE_METHOD;
        }

        private void radioButtonRightRectangles_CheckedChanged(object sender, EventArgs e)
        {
            currentMod = Mods.RIGHT_RECTANGLE_METHOD;
        }

        private void radioButtonMediumRectangle_CheckedChanged(object sender, EventArgs e)
        {
            currentMod = Mods.MIDDLE_RECTANGLE_METHOD;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                chart1.Series[0].Enabled = false; // Скрыть график
            }
            else
            {
                chart1.Series[0].Enabled = true; // Показать график
            }
        }

        
    }
}

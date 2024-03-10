
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static LaboratoryWork1_AppDevVisEnv_.Integral;


namespace LaboratoryWork1_AppDevVisEnv_
{
    internal class DrawIntegral
    {
        private Chart chart1 {  get; set; }
        private double x1 { get; set; }
        private double x2 { get; set; }
        private double h {  get; set; }

        public DrawIntegral(double x1, double x2, double h, Chart chart1)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.h = h;
            this.chart1 = chart1;
        }

        public DrawIntegral()
        {
            x1 = 1.0;
            x2 = 2.0;
            h = 0.05;

            
        }

        public Chart drawFunction() 
        {
            for (double x = x1; x <= x2; x += h)
            {
                double y = mathFunction(x);
                chart1.Series[1].Points.AddXY(x, y);
            }
            return chart1;
        }
        public void leftRectangleMethod(ref Chart chart1, double x1, double x2, double h)
        {
            for (double x = x1; x <= x2; x += h)
            {
                double y = mathFunction(x);
                chart1.Series[1].Points.AddXY(x, y);
                chart1.Series[0].Points.AddXY(x, y);
                if (x + h <= x2)
                {
                    chart1.Series[0].Points.AddXY(x + h, y);
                }
            }
        }


        public void rightRectangleMethod(ref Chart chart1, double x1, double x2, double h)
        {
            for (double x = x1; x <= x2; x += h)
            {
                double y = mathFunction(x + h);

                chart1.Series[0].Points.AddXY(x, y);
                chart1.Series[1].Points.AddXY(x, mathFunction(x));
                if (x + h <= x2)
                {
                    chart1.Series[0].Points.AddXY(x + h, y);
                }

                

            }
            
        }

        public void middleRectangleMethod(ref Chart chart1, double x1, double x2, double h, double area)
        {
            for (double x = x1; x <= x2; x += h)
            {
                double y = mathFunction(x + h / 2);

                chart1.Series[0].Points.AddXY(x, y);
                chart1.Series[1].Points.AddXY(x, mathFunction(x));

                if (x + h <= x2)

                {
                    chart1.Series[0].Points.AddXY(x + h, y);
                }
            }
        }

        public void TrapezoidMethod(ref Chart chart1, double x1, double x2, double h, double area)
        {
            for (double x = x1; x <= x2; x += h)
            {
                double y = mathFunction(x);
                chart1.Series[1].Points.AddXY(x, y);
                chart1.Series[0].Points.AddXY(x, y);   
            }
            
        }

        
    }
}

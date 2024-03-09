namespace LaboratoryWork1_AppDevVisEnv_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMediumRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonRightRectangles = new System.Windows.Forms.RadioButton();
            this.radioButtonMethodLeftRectangles = new System.Windows.Forms.RadioButton();
            this.radioButtonMethodTrapezoid = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxStep = new System.Windows.Forms.TextBox();
            this.labelLowBorder = new System.Windows.Forms.Label();
            this.textBoxLowBorder = new System.Windows.Forms.TextBox();
            this.textBoxHighBorder = new System.Windows.Forms.TextBox();
            this.labelHighBorder = new System.Windows.Forms.Label();
            this.labelStepBorder = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelLowBorderIntegral = new System.Windows.Forms.Label();
            this.labelHighBorderIntegral = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMediumRectangle);
            this.groupBox1.Controls.Add(this.radioButtonRightRectangles);
            this.groupBox1.Controls.Add(this.radioButtonMethodLeftRectangles);
            this.groupBox1.Controls.Add(this.radioButtonMethodTrapezoid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(45, 128);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(380, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Метод вычислений";
            // 
            // radioButtonMediumRectangle
            // 
            this.radioButtonMediumRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonMediumRectangle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radioButtonMediumRectangle.Location = new System.Drawing.Point(2, 198);
            this.radioButtonMediumRectangle.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonMediumRectangle.Name = "radioButtonMediumRectangle";
            this.radioButtonMediumRectangle.Size = new System.Drawing.Size(376, 55);
            this.radioButtonMediumRectangle.TabIndex = 3;
            this.radioButtonMediumRectangle.Text = "Метод средних прямоугольников";
            this.radioButtonMediumRectangle.UseVisualStyleBackColor = true;
            this.radioButtonMediumRectangle.CheckedChanged += new System.EventHandler(this.radioButtonMediumRectangle_CheckedChanged);
            // 
            // radioButtonRightRectangles
            // 
            this.radioButtonRightRectangles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonRightRectangles.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonRightRectangles.Location = new System.Drawing.Point(2, 134);
            this.radioButtonRightRectangles.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonRightRectangles.Name = "radioButtonRightRectangles";
            this.radioButtonRightRectangles.Size = new System.Drawing.Size(376, 55);
            this.radioButtonRightRectangles.TabIndex = 2;
            this.radioButtonRightRectangles.Text = "Метод правых прямоугольников";
            this.radioButtonRightRectangles.UseVisualStyleBackColor = true;
            this.radioButtonRightRectangles.CheckedChanged += new System.EventHandler(this.radioButtonRightRectangles_CheckedChanged);
            // 
            // radioButtonMethodLeftRectangles
            // 
            this.radioButtonMethodLeftRectangles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonMethodLeftRectangles.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonMethodLeftRectangles.Location = new System.Drawing.Point(2, 79);
            this.radioButtonMethodLeftRectangles.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonMethodLeftRectangles.Name = "radioButtonMethodLeftRectangles";
            this.radioButtonMethodLeftRectangles.Size = new System.Drawing.Size(376, 55);
            this.radioButtonMethodLeftRectangles.TabIndex = 1;
            this.radioButtonMethodLeftRectangles.Text = "Метод левых прямоугольников";
            this.radioButtonMethodLeftRectangles.UseVisualStyleBackColor = true;
            this.radioButtonMethodLeftRectangles.CheckedChanged += new System.EventHandler(this.radioButtonMethodLeftRectangles_CheckedChanged);
            // 
            // radioButtonMethodTrapezoid
            // 
            this.radioButtonMethodTrapezoid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonMethodTrapezoid.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonMethodTrapezoid.Location = new System.Drawing.Point(2, 24);
            this.radioButtonMethodTrapezoid.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonMethodTrapezoid.Name = "radioButtonMethodTrapezoid";
            this.radioButtonMethodTrapezoid.Size = new System.Drawing.Size(376, 55);
            this.radioButtonMethodTrapezoid.TabIndex = 0;
            this.radioButtonMethodTrapezoid.Text = "Метод трапеций";
            this.radioButtonMethodTrapezoid.UseVisualStyleBackColor = true;
            this.radioButtonMethodTrapezoid.CheckedChanged += new System.EventHandler(this.radioButtonMethodTrapezoid_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxStep);
            this.groupBox2.Controls.Add(this.labelLowBorder);
            this.groupBox2.Controls.Add(this.textBoxLowBorder);
            this.groupBox2.Controls.Add(this.textBoxHighBorder);
            this.groupBox2.Controls.Add(this.labelHighBorder);
            this.groupBox2.Controls.Add(this.labelStepBorder);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(45, 408);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(380, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры";
            // 
            // textBoxStep
            // 
            this.textBoxStep.Location = new System.Drawing.Point(275, 94);
            this.textBoxStep.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStep.Name = "textBoxStep";
            this.textBoxStep.Size = new System.Drawing.Size(76, 31);
            this.textBoxStep.TabIndex = 5;
            this.textBoxStep.Text = "0,05";
            // 
            // labelLowBorder
            // 
            this.labelLowBorder.AutoSize = true;
            this.labelLowBorder.Location = new System.Drawing.Point(23, 55);
            this.labelLowBorder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLowBorder.Name = "labelLowBorder";
            this.labelLowBorder.Size = new System.Drawing.Size(94, 25);
            this.labelLowBorder.TabIndex = 0;
            this.labelLowBorder.Text = "Нижняя";
            // 
            // textBoxLowBorder
            // 
            this.textBoxLowBorder.Location = new System.Drawing.Point(29, 94);
            this.textBoxLowBorder.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLowBorder.Name = "textBoxLowBorder";
            this.textBoxLowBorder.Size = new System.Drawing.Size(76, 31);
            this.textBoxLowBorder.TabIndex = 1;
            this.textBoxLowBorder.Text = "1,0";
            // 
            // textBoxHighBorder
            // 
            this.textBoxHighBorder.Location = new System.Drawing.Point(147, 94);
            this.textBoxHighBorder.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHighBorder.Name = "textBoxHighBorder";
            this.textBoxHighBorder.Size = new System.Drawing.Size(76, 31);
            this.textBoxHighBorder.TabIndex = 4;
            this.textBoxHighBorder.Text = "2,0";
            // 
            // labelHighBorder
            // 
            this.labelHighBorder.AutoSize = true;
            this.labelHighBorder.Location = new System.Drawing.Point(142, 55);
            this.labelHighBorder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHighBorder.Name = "labelHighBorder";
            this.labelHighBorder.Size = new System.Drawing.Size(102, 25);
            this.labelHighBorder.TabIndex = 2;
            this.labelHighBorder.Text = "Верхняя";
            // 
            // labelStepBorder
            // 
            this.labelStepBorder.AutoSize = true;
            this.labelStepBorder.Location = new System.Drawing.Point(285, 55);
            this.labelStepBorder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStepBorder.Name = "labelStepBorder";
            this.labelStepBorder.Size = new System.Drawing.Size(53, 25);
            this.labelStepBorder.TabIndex = 3;
            this.labelStepBorder.Text = "Шаг";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(450, 128);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series5.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            series5.BorderColor = System.Drawing.Color.Fuchsia;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series5.LabelBorderWidth = 20;
            series5.Legend = "Legend1";
            series5.Name = "График границы";
            series6.BorderColor = System.Drawing.Color.Red;
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.Red;
            series6.Legend = "Legend1";
            series6.Name = "График функции";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(718, 544);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            title3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title3.ForeColor = System.Drawing.Color.Blue;
            title3.Name = "Title1";
            title3.Text = "Графическое изображение";
            this.chart1.Titles.Add(title3);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(107, 622);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(450, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(210, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 52);
            this.label4.TabIndex = 6;
            this.label4.Text = "Интеграл:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(1024, 570);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 40);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Показать границу области";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.White;
            this.labelResult.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(669, 41);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(81, 28);
            this.labelResult.TabIndex = 11;
            // 
            // labelLowBorderIntegral
            // 
            this.labelLowBorderIntegral.BackColor = System.Drawing.Color.White;
            this.labelLowBorderIntegral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLowBorderIntegral.Location = new System.Drawing.Point(562, 64);
            this.labelLowBorderIntegral.Name = "labelLowBorderIntegral";
            this.labelLowBorderIntegral.Size = new System.Drawing.Size(41, 16);
            this.labelLowBorderIntegral.TabIndex = 12;
            // 
            // labelHighBorderIntegral
            // 
            this.labelHighBorderIntegral.BackColor = System.Drawing.Color.White;
            this.labelHighBorderIntegral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHighBorderIntegral.Location = new System.Drawing.Point(562, 28);
            this.labelHighBorderIntegral.Name = "labelHighBorderIntegral";
            this.labelHighBorderIntegral.Size = new System.Drawing.Size(30, 18);
            this.labelHighBorderIntegral.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1314, 738);
            this.Controls.Add(this.labelHighBorderIntegral);
            this.Controls.Add(this.labelLowBorderIntegral);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonMediumRectangle;
        private System.Windows.Forms.RadioButton radioButtonRightRectangles;
        private System.Windows.Forms.RadioButton radioButtonMethodLeftRectangles;
        private System.Windows.Forms.RadioButton radioButtonMethodTrapezoid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxStep;
        private System.Windows.Forms.TextBox textBoxHighBorder;
        private System.Windows.Forms.Label labelStepBorder;
        private System.Windows.Forms.Label labelHighBorder;
        private System.Windows.Forms.TextBox textBoxLowBorder;
        private System.Windows.Forms.Label labelLowBorder;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelLowBorderIntegral;
        private System.Windows.Forms.Label labelHighBorderIntegral;
    }
}


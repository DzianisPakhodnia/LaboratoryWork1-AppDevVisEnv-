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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.groupBox1.Location = new System.Drawing.Point(60, 158);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(507, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Метод вычислений";
            // 
            // radioButtonMediumRectangle
            // 
            this.radioButtonMediumRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonMediumRectangle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radioButtonMediumRectangle.Location = new System.Drawing.Point(3, 244);
            this.radioButtonMediumRectangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonMediumRectangle.Name = "radioButtonMediumRectangle";
            this.radioButtonMediumRectangle.Size = new System.Drawing.Size(501, 68);
            this.radioButtonMediumRectangle.TabIndex = 3;
            this.radioButtonMediumRectangle.TabStop = true;
            this.radioButtonMediumRectangle.Text = "Метод средних прямоугольников";
            this.radioButtonMediumRectangle.UseVisualStyleBackColor = true;
            this.radioButtonMediumRectangle.CheckedChanged += new System.EventHandler(this.radioButtonMediumRectangle_CheckedChanged);
            // 
            // radioButtonRightRectangles
            // 
            this.radioButtonRightRectangles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonRightRectangles.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonRightRectangles.Location = new System.Drawing.Point(3, 165);
            this.radioButtonRightRectangles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonRightRectangles.Name = "radioButtonRightRectangles";
            this.radioButtonRightRectangles.Size = new System.Drawing.Size(501, 68);
            this.radioButtonRightRectangles.TabIndex = 2;
            this.radioButtonRightRectangles.TabStop = true;
            this.radioButtonRightRectangles.Text = "Метод правых прямоугольников";
            this.radioButtonRightRectangles.UseVisualStyleBackColor = true;
            this.radioButtonRightRectangles.CheckedChanged += new System.EventHandler(this.radioButtonRightRectangles_CheckedChanged);
            // 
            // radioButtonMethodLeftRectangles
            // 
            this.radioButtonMethodLeftRectangles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonMethodLeftRectangles.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonMethodLeftRectangles.Location = new System.Drawing.Point(3, 97);
            this.radioButtonMethodLeftRectangles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonMethodLeftRectangles.Name = "radioButtonMethodLeftRectangles";
            this.radioButtonMethodLeftRectangles.Size = new System.Drawing.Size(501, 68);
            this.radioButtonMethodLeftRectangles.TabIndex = 1;
            this.radioButtonMethodLeftRectangles.TabStop = true;
            this.radioButtonMethodLeftRectangles.Text = "Метод левых прямоугольников";
            this.radioButtonMethodLeftRectangles.UseVisualStyleBackColor = true;
            this.radioButtonMethodLeftRectangles.CheckedChanged += new System.EventHandler(this.radioButtonMethodLeftRectangles_CheckedChanged);
            // 
            // radioButtonMethodTrapezoid
            // 
            this.radioButtonMethodTrapezoid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonMethodTrapezoid.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonMethodTrapezoid.Location = new System.Drawing.Point(3, 29);
            this.radioButtonMethodTrapezoid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonMethodTrapezoid.Name = "radioButtonMethodTrapezoid";
            this.radioButtonMethodTrapezoid.Size = new System.Drawing.Size(501, 68);
            this.radioButtonMethodTrapezoid.TabIndex = 0;
            this.radioButtonMethodTrapezoid.TabStop = true;
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
            this.groupBox2.Location = new System.Drawing.Point(60, 502);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(507, 183);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры";
            // 
            // textBoxStep
            // 
            this.textBoxStep.Location = new System.Drawing.Point(367, 116);
            this.textBoxStep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStep.Name = "textBoxStep";
            this.textBoxStep.Size = new System.Drawing.Size(100, 37);
            this.textBoxStep.TabIndex = 5;
            this.textBoxStep.Text = "0,05";
            // 
            // labelLowBorder
            // 
            this.labelLowBorder.AutoSize = true;
            this.labelLowBorder.Location = new System.Drawing.Point(31, 68);
            this.labelLowBorder.Name = "labelLowBorder";
            this.labelLowBorder.Size = new System.Drawing.Size(119, 31);
            this.labelLowBorder.TabIndex = 0;
            this.labelLowBorder.Text = "Нижняя";
            // 
            // textBoxLowBorder
            // 
            this.textBoxLowBorder.Location = new System.Drawing.Point(39, 116);
            this.textBoxLowBorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLowBorder.Name = "textBoxLowBorder";
            this.textBoxLowBorder.Size = new System.Drawing.Size(100, 37);
            this.textBoxLowBorder.TabIndex = 1;
            this.textBoxLowBorder.Text = "1,0";
            // 
            // textBoxHighBorder
            // 
            this.textBoxHighBorder.Location = new System.Drawing.Point(196, 116);
            this.textBoxHighBorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxHighBorder.Name = "textBoxHighBorder";
            this.textBoxHighBorder.Size = new System.Drawing.Size(100, 37);
            this.textBoxHighBorder.TabIndex = 4;
            this.textBoxHighBorder.Text = "2,0";
            // 
            // labelHighBorder
            // 
            this.labelHighBorder.AutoSize = true;
            this.labelHighBorder.Location = new System.Drawing.Point(189, 68);
            this.labelHighBorder.Name = "labelHighBorder";
            this.labelHighBorder.Size = new System.Drawing.Size(127, 31);
            this.labelHighBorder.TabIndex = 2;
            this.labelHighBorder.Text = "Верхняя";
            // 
            // labelStepBorder
            // 
            this.labelStepBorder.AutoSize = true;
            this.labelStepBorder.Location = new System.Drawing.Point(380, 68);
            this.labelStepBorder.Name = "labelStepBorder";
            this.labelStepBorder.Size = new System.Drawing.Size(65, 31);
            this.labelStepBorder.TabIndex = 3;
            this.labelStepBorder.Text = "Шаг";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(600, 158);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series7.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            series7.BorderColor = System.Drawing.Color.Fuchsia;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series7.LabelBorderWidth = 20;
            series7.Legend = "Legend1";
            series7.Name = "График границы";
            series8.BorderColor = System.Drawing.Color.Red;
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Color = System.Drawing.Color.Red;
            series8.Legend = "Legend1";
            series8.Name = "График функции";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(958, 670);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            title4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title4.ForeColor = System.Drawing.Color.Blue;
            title4.Name = "Title1";
            title4.Text = "Графическое изображение";
            this.chart1.Titles.Add(title4);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(143, 766);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LaboratoryWork1_AppDevVisEnv_.Properties.Resources.FormulaFunction;
            this.pictureBox1.Location = new System.Drawing.Point(605, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(349, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 64);
            this.label4.TabIndex = 6;
            this.label4.Text = "Интеграл:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(895, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(407, 107);
            this.label5.TabIndex = 7;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(1366, 701);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(157, 49);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Показать границу области";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1752, 908);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}


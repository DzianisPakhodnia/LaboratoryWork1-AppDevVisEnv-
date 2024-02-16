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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMediumRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonRightRectangles = new System.Windows.Forms.RadioButton();
            this.radioButtonMethodLeftRectangles = new System.Windows.Forms.RadioButton();
            this.radioButtonMethodTrapezoid = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.radioButtonMediumRectangle.TabStop = true;
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
            this.radioButtonRightRectangles.TabStop = true;
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
            this.radioButtonMethodLeftRectangles.TabStop = true;
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
            this.radioButtonMethodTrapezoid.TabStop = true;
            this.radioButtonMethodTrapezoid.Text = "Метод трапеций";
            this.radioButtonMethodTrapezoid.UseVisualStyleBackColor = true;
            this.radioButtonMethodTrapezoid.CheckedChanged += new System.EventHandler(this.radioButtonMethodTrapezoid_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(275, 94);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(76, 31);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "0,05";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Нижняя";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 94);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(76, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "1,0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 94);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(76, 31);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "2,0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Верхняя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Шаг";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(450, 128);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series3.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            series3.BorderColor = System.Drawing.Color.Fuchsia;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series3.LabelBorderWidth = 20;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series4.BorderColor = System.Drawing.Color.Red;
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(739, 544);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            title2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.ForeColor = System.Drawing.Color.Blue;
            title2.Name = "Title1";
            title2.Text = "Графическое изображение";
            this.chart1.Titles.Add(title2);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(2, 686);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(120, 582);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 64);
            this.button2.TabIndex = 4;
            this.button2.Text = "Посчитать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LaboratoryWork1_AppDevVisEnv_.Properties.Resources.FormulaFunction;
            this.pictureBox1.Location = new System.Drawing.Point(454, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(262, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 52);
            this.label4.TabIndex = 6;
            this.label4.Text = "Интеграл:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(671, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 87);
            this.label5.TabIndex = 7;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1200, 738);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


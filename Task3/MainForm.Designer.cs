namespace Task3
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BtStart = new System.Windows.Forms.Button();
            this.TbKappa = new System.Windows.Forms.TextBox();
            this.LbKappa = new System.Windows.Forms.Label();
            this.TbBigOmega = new System.Windows.Forms.TextBox();
            this.LbBigOmega = new System.Windows.Forms.Label();
            this.TbNu = new System.Windows.Forms.TextBox();
            this.LbNu = new System.Windows.Forms.Label();
            this.SCMain = new System.Windows.Forms.SplitContainer();
            this.ChbF = new System.Windows.Forms.CheckBox();
            this.ChbU = new System.Windows.Forms.CheckBox();
            this.BtClear = new System.Windows.Forms.Button();
            this.BtStop = new System.Windows.Forms.Button();
            this.btSpecificZ = new System.Windows.Forms.Button();
            this.TbTInterval = new System.Windows.Forms.TextBox();
            this.LbTInterval = new System.Windows.Forms.Label();
            this.TbTMax = new System.Windows.Forms.TextBox();
            this.LbTMax = new System.Windows.Forms.Label();
            this.TbTMin = new System.Windows.Forms.TextBox();
            this.LbTMin = new System.Windows.Forms.Label();
            this.TbZInterval = new System.Windows.Forms.TextBox();
            this.LbZInterval = new System.Windows.Forms.Label();
            this.TbZMax = new System.Windows.Forms.TextBox();
            this.LbZMax = new System.Windows.Forms.Label();
            this.TbZMin = new System.Windows.Forms.TextBox();
            this.LbZMin = new System.Windows.Forms.Label();
            this.btSpecificT = new System.Windows.Forms.Button();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SCMain)).BeginInit();
            this.SCMain.Panel1.SuspendLayout();
            this.SCMain.Panel2.SuspendLayout();
            this.SCMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // BtStart
            // 
            this.BtStart.Location = new System.Drawing.Point(19, 257);
            this.BtStart.Margin = new System.Windows.Forms.Padding(4);
            this.BtStart.Name = "BtStart";
            this.BtStart.Size = new System.Drawing.Size(281, 28);
            this.BtStart.TabIndex = 34;
            this.BtStart.Text = "Начать";
            this.BtStart.UseVisualStyleBackColor = true;
            this.BtStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // TbKappa
            // 
            this.TbKappa.Location = new System.Drawing.Point(19, 133);
            this.TbKappa.Margin = new System.Windows.Forms.Padding(4);
            this.TbKappa.Name = "TbKappa";
            this.TbKappa.Size = new System.Drawing.Size(281, 22);
            this.TbKappa.TabIndex = 21;
            this.TbKappa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbKappa
            // 
            this.LbKappa.AutoSize = true;
            this.LbKappa.Location = new System.Drawing.Point(17, 112);
            this.LbKappa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbKappa.Name = "LbKappa";
            this.LbKappa.Size = new System.Drawing.Size(165, 17);
            this.LbKappa.TabIndex = 20;
            this.LbKappa.Text = "Время запаздывания, ϰ";
            // 
            // TbBigOmega
            // 
            this.TbBigOmega.Location = new System.Drawing.Point(19, 86);
            this.TbBigOmega.Margin = new System.Windows.Forms.Padding(4);
            this.TbBigOmega.Name = "TbBigOmega";
            this.TbBigOmega.Size = new System.Drawing.Size(281, 22);
            this.TbBigOmega.TabIndex = 19;
            this.TbBigOmega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbBigOmega
            // 
            this.LbBigOmega.AutoSize = true;
            this.LbBigOmega.Location = new System.Drawing.Point(17, 65);
            this.LbBigOmega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbBigOmega.Name = "LbBigOmega";
            this.LbBigOmega.Size = new System.Drawing.Size(204, 17);
            this.LbBigOmega.TabIndex = 18;
            this.LbBigOmega.Text = "Произвольная постоянная, Ω";
            // 
            // TbNu
            // 
            this.TbNu.Location = new System.Drawing.Point(19, 39);
            this.TbNu.Margin = new System.Windows.Forms.Padding(4);
            this.TbNu.Name = "TbNu";
            this.TbNu.Size = new System.Drawing.Size(281, 22);
            this.TbNu.TabIndex = 17;
            this.TbNu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbNu
            // 
            this.LbNu.AutoSize = true;
            this.LbNu.Location = new System.Drawing.Point(16, 18);
            this.LbNu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbNu.Name = "LbNu";
            this.LbNu.Size = new System.Drawing.Size(292, 17);
            this.LbNu.TabIndex = 16;
            this.LbNu.Text = "Кинематический коэффициент вязкости, ν";
            // 
            // SCMain
            // 
            this.SCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SCMain.Location = new System.Drawing.Point(0, 0);
            this.SCMain.Margin = new System.Windows.Forms.Padding(4);
            this.SCMain.Name = "SCMain";
            // 
            // SCMain.Panel1
            // 
            this.SCMain.Panel1.Controls.Add(this.ChbF);
            this.SCMain.Panel1.Controls.Add(this.ChbU);
            this.SCMain.Panel1.Controls.Add(this.BtClear);
            this.SCMain.Panel1.Controls.Add(this.BtStop);
            this.SCMain.Panel1.Controls.Add(this.btSpecificZ);
            this.SCMain.Panel1.Controls.Add(this.TbTInterval);
            this.SCMain.Panel1.Controls.Add(this.LbTInterval);
            this.SCMain.Panel1.Controls.Add(this.TbTMax);
            this.SCMain.Panel1.Controls.Add(this.LbTMax);
            this.SCMain.Panel1.Controls.Add(this.TbTMin);
            this.SCMain.Panel1.Controls.Add(this.LbTMin);
            this.SCMain.Panel1.Controls.Add(this.TbZInterval);
            this.SCMain.Panel1.Controls.Add(this.LbZInterval);
            this.SCMain.Panel1.Controls.Add(this.TbZMax);
            this.SCMain.Panel1.Controls.Add(this.LbZMax);
            this.SCMain.Panel1.Controls.Add(this.TbZMin);
            this.SCMain.Panel1.Controls.Add(this.LbZMin);
            this.SCMain.Panel1.Controls.Add(this.btSpecificT);
            this.SCMain.Panel1.Controls.Add(this.BtStart);
            this.SCMain.Panel1.Controls.Add(this.TbKappa);
            this.SCMain.Panel1.Controls.Add(this.LbKappa);
            this.SCMain.Panel1.Controls.Add(this.TbBigOmega);
            this.SCMain.Panel1.Controls.Add(this.LbBigOmega);
            this.SCMain.Panel1.Controls.Add(this.TbNu);
            this.SCMain.Panel1.Controls.Add(this.LbNu);
            // 
            // SCMain.Panel2
            // 
            this.SCMain.Panel2.Controls.Add(this.mainChart);
            this.SCMain.Size = new System.Drawing.Size(1067, 658);
            this.SCMain.SplitterDistance = 310;
            this.SCMain.SplitterWidth = 5;
            this.SCMain.TabIndex = 1;
            // 
            // ChbF
            // 
            this.ChbF.AutoSize = true;
            this.ChbF.Location = new System.Drawing.Point(22, 463);
            this.ChbF.Name = "ChbF";
            this.ChbF.Size = new System.Drawing.Size(146, 21);
            this.ChbF.TabIndex = 40;
            this.ChbF.Text = "Угловая скорость";
            this.ChbF.UseVisualStyleBackColor = true;
            // 
            // ChbU
            // 
            this.ChbU.AutoSize = true;
            this.ChbU.Location = new System.Drawing.Point(22, 436);
            this.ChbU.Name = "ChbU";
            this.ChbU.Size = new System.Drawing.Size(271, 21);
            this.ChbU.TabIndex = 39;
            this.ChbU.Text = "Вертикальная компонента скорости";
            this.ChbU.UseVisualStyleBackColor = true;
            // 
            // BtClear
            // 
            this.BtClear.Location = new System.Drawing.Point(19, 329);
            this.BtClear.Margin = new System.Windows.Forms.Padding(4);
            this.BtClear.Name = "BtClear";
            this.BtClear.Size = new System.Drawing.Size(281, 28);
            this.BtClear.TabIndex = 38;
            this.BtClear.Text = "Очистить";
            this.BtClear.UseVisualStyleBackColor = true;
            this.BtClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // BtStop
            // 
            this.BtStop.Enabled = false;
            this.BtStop.Location = new System.Drawing.Point(19, 293);
            this.BtStop.Margin = new System.Windows.Forms.Padding(4);
            this.BtStop.Name = "BtStop";
            this.BtStop.Size = new System.Drawing.Size(281, 28);
            this.BtStop.TabIndex = 37;
            this.BtStop.Text = "Остановить";
            this.BtStop.UseVisualStyleBackColor = true;
            this.BtStop.Click += new System.EventHandler(this.BtStop_Click);
            // 
            // btSpecificZ
            // 
            this.btSpecificZ.Enabled = false;
            this.btSpecificZ.Location = new System.Drawing.Point(20, 401);
            this.btSpecificZ.Margin = new System.Windows.Forms.Padding(4);
            this.btSpecificZ.Name = "btSpecificZ";
            this.btSpecificZ.Size = new System.Drawing.Size(281, 28);
            this.btSpecificZ.TabIndex = 36;
            this.btSpecificZ.Text = "Сохранить с зафиксированным z";
            this.btSpecificZ.UseVisualStyleBackColor = true;
            this.btSpecificZ.Click += new System.EventHandler(this.BtSpecificZ_Click);
            // 
            // TbTInterval
            // 
            this.TbTInterval.Location = new System.Drawing.Point(214, 227);
            this.TbTInterval.Margin = new System.Windows.Forms.Padding(4);
            this.TbTInterval.Name = "TbTInterval";
            this.TbTInterval.Size = new System.Drawing.Size(86, 22);
            this.TbTInterval.TabIndex = 33;
            this.TbTInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbTInterval
            // 
            this.LbTInterval.AutoSize = true;
            this.LbTInterval.Location = new System.Drawing.Point(214, 206);
            this.LbTInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbTInterval.Name = "LbTInterval";
            this.LbTInterval.Size = new System.Drawing.Size(66, 17);
            this.LbTInterval.TabIndex = 32;
            this.LbTInterval.Text = "t интерв.";
            // 
            // TbTMax
            // 
            this.TbTMax.Location = new System.Drawing.Point(112, 227);
            this.TbTMax.Margin = new System.Windows.Forms.Padding(4);
            this.TbTMax.Name = "TbTMax";
            this.TbTMax.Size = new System.Drawing.Size(94, 22);
            this.TbTMax.TabIndex = 31;
            this.TbTMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbTMax
            // 
            this.LbTMax.AutoSize = true;
            this.LbTMax.Location = new System.Drawing.Point(112, 206);
            this.LbTMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbTMax.Name = "LbTMax";
            this.LbTMax.Size = new System.Drawing.Size(51, 17);
            this.LbTMax.TabIndex = 30;
            this.LbTMax.Text = "t макс.";
            // 
            // TbTMin
            // 
            this.TbTMin.Location = new System.Drawing.Point(19, 227);
            this.TbTMin.Margin = new System.Windows.Forms.Padding(4);
            this.TbTMin.Name = "TbTMin";
            this.TbTMin.Size = new System.Drawing.Size(85, 22);
            this.TbTMin.TabIndex = 29;
            this.TbTMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbTMin
            // 
            this.LbTMin.AutoSize = true;
            this.LbTMin.Location = new System.Drawing.Point(17, 206);
            this.LbTMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbTMin.Name = "LbTMin";
            this.LbTMin.Size = new System.Drawing.Size(45, 17);
            this.LbTMin.TabIndex = 28;
            this.LbTMin.Text = "t мин.";
            // 
            // TbZInterval
            // 
            this.TbZInterval.Location = new System.Drawing.Point(214, 180);
            this.TbZInterval.Margin = new System.Windows.Forms.Padding(4);
            this.TbZInterval.Name = "TbZInterval";
            this.TbZInterval.Size = new System.Drawing.Size(86, 22);
            this.TbZInterval.TabIndex = 27;
            this.TbZInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbZInterval
            // 
            this.LbZInterval.AutoSize = true;
            this.LbZInterval.Location = new System.Drawing.Point(211, 159);
            this.LbZInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbZInterval.Name = "LbZInterval";
            this.LbZInterval.Size = new System.Drawing.Size(69, 17);
            this.LbZInterval.TabIndex = 26;
            this.LbZInterval.Text = "z интерв.";
            // 
            // TbZMax
            // 
            this.TbZMax.Location = new System.Drawing.Point(112, 180);
            this.TbZMax.Margin = new System.Windows.Forms.Padding(4);
            this.TbZMax.Name = "TbZMax";
            this.TbZMax.Size = new System.Drawing.Size(94, 22);
            this.TbZMax.TabIndex = 25;
            this.TbZMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbZMax
            // 
            this.LbZMax.AutoSize = true;
            this.LbZMax.Location = new System.Drawing.Point(109, 159);
            this.LbZMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbZMax.Name = "LbZMax";
            this.LbZMax.Size = new System.Drawing.Size(54, 17);
            this.LbZMax.TabIndex = 24;
            this.LbZMax.Text = "z макс.";
            // 
            // TbZMin
            // 
            this.TbZMin.Location = new System.Drawing.Point(20, 180);
            this.TbZMin.Margin = new System.Windows.Forms.Padding(4);
            this.TbZMin.Name = "TbZMin";
            this.TbZMin.Size = new System.Drawing.Size(84, 22);
            this.TbZMin.TabIndex = 23;
            this.TbZMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbZMin
            // 
            this.LbZMin.AutoSize = true;
            this.LbZMin.Location = new System.Drawing.Point(19, 159);
            this.LbZMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbZMin.Name = "LbZMin";
            this.LbZMin.Size = new System.Drawing.Size(48, 17);
            this.LbZMin.TabIndex = 22;
            this.LbZMin.Text = "z мин.";
            // 
            // btSpecificT
            // 
            this.btSpecificT.Enabled = false;
            this.btSpecificT.Location = new System.Drawing.Point(20, 365);
            this.btSpecificT.Margin = new System.Windows.Forms.Padding(4);
            this.btSpecificT.Name = "btSpecificT";
            this.btSpecificT.Size = new System.Drawing.Size(281, 28);
            this.btSpecificT.TabIndex = 35;
            this.btSpecificT.Text = "Сохранить с зафиксированным t";
            this.btSpecificT.UseVisualStyleBackColor = true;
            this.btSpecificT.Click += new System.EventHandler(this.BtSpecificT_Click);
            // 
            // mainChart
            // 
            chartArea1.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea1);
            this.mainChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.mainChart.Legends.Add(legend1);
            this.mainChart.Location = new System.Drawing.Point(0, 0);
            this.mainChart.Margin = new System.Windows.Forms.Padding(4);
            this.mainChart.Name = "mainChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Вертикальная компонента скорости неньютоновской жидкости, f";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Угловая скорость неньютоновской жидкости, u";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Вертикальная компонента скорости ньютоновской жидкости, f";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Угловая скорость ньютоновской жидкости, u";
            this.mainChart.Series.Add(series1);
            this.mainChart.Series.Add(series2);
            this.mainChart.Series.Add(series3);
            this.mainChart.Series.Add(series4);
            this.mainChart.Size = new System.Drawing.Size(752, 658);
            this.mainChart.TabIndex = 0;
            this.mainChart.Text = "chart1";
            // 
            // Timer
            // 
            this.Timer.Interval = 20;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.SCMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Решение задачи в случае вращательно-симметричного течения вязкоупругой жидкости т" +
    "ипа Фойгта";
            this.SCMain.Panel1.ResumeLayout(false);
            this.SCMain.Panel1.PerformLayout();
            this.SCMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SCMain)).EndInit();
            this.SCMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtStart;
        private System.Windows.Forms.TextBox TbKappa;
        private System.Windows.Forms.Label LbKappa;
        private System.Windows.Forms.TextBox TbBigOmega;
        private System.Windows.Forms.Label LbBigOmega;
        private System.Windows.Forms.TextBox TbNu;
        private System.Windows.Forms.Label LbNu;
        private System.Windows.Forms.SplitContainer SCMain;
        private System.Windows.Forms.Button btSpecificT;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.TextBox TbZMax;
        private System.Windows.Forms.Label LbZMax;
        private System.Windows.Forms.TextBox TbZMin;
        private System.Windows.Forms.Label LbZMin;
        private System.Windows.Forms.TextBox TbTInterval;
        private System.Windows.Forms.Label LbTInterval;
        private System.Windows.Forms.TextBox TbTMax;
        private System.Windows.Forms.Label LbTMax;
        private System.Windows.Forms.TextBox TbTMin;
        private System.Windows.Forms.Label LbTMin;
        private System.Windows.Forms.TextBox TbZInterval;
        private System.Windows.Forms.Label LbZInterval;
        private System.Windows.Forms.Button btSpecificZ;
        private System.Windows.Forms.Button BtClear;
        private System.Windows.Forms.Button BtStop;
        private System.Windows.Forms.CheckBox ChbF;
        private System.Windows.Forms.CheckBox ChbU;
    }
}


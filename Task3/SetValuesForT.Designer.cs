namespace Task3
{
    partial class SetValuesForT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbT = new System.Windows.Forms.TextBox();
            this.LbT = new System.Windows.Forms.Label();
            this.TbZInterval = new System.Windows.Forms.TextBox();
            this.LbZInterval = new System.Windows.Forms.Label();
            this.TbZMax = new System.Windows.Forms.TextBox();
            this.LbZMax = new System.Windows.Forms.Label();
            this.TbZMin = new System.Windows.Forms.TextBox();
            this.LbZMin = new System.Windows.Forms.Label();
            this.TbKappa = new System.Windows.Forms.TextBox();
            this.LbKappa = new System.Windows.Forms.Label();
            this.TbBigOmega = new System.Windows.Forms.TextBox();
            this.LbBigOmega = new System.Windows.Forms.Label();
            this.TbNu = new System.Windows.Forms.TextBox();
            this.LbNu = new System.Windows.Forms.Label();
            this.BtSave = new System.Windows.Forms.Button();
            this.TbTAcc = new System.Windows.Forms.TextBox();
            this.LbTAcc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbT
            // 
            this.TbT.Location = new System.Drawing.Point(13, 227);
            this.TbT.Margin = new System.Windows.Forms.Padding(4);
            this.TbT.Name = "TbT";
            this.TbT.Size = new System.Drawing.Size(319, 22);
            this.TbT.TabIndex = 14;
            this.TbT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbT
            // 
            this.LbT.AutoSize = true;
            this.LbT.Location = new System.Drawing.Point(13, 206);
            this.LbT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbT.Name = "LbT";
            this.LbT.Size = new System.Drawing.Size(58, 17);
            this.LbT.TabIndex = 13;
            this.LbT.Text = "Время t";
            // 
            // TbZInterval
            // 
            this.TbZInterval.Location = new System.Drawing.Point(231, 180);
            this.TbZInterval.Margin = new System.Windows.Forms.Padding(4);
            this.TbZInterval.Name = "TbZInterval";
            this.TbZInterval.Size = new System.Drawing.Size(101, 22);
            this.TbZInterval.TabIndex = 12;
            this.TbZInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbZInterval
            // 
            this.LbZInterval.AutoSize = true;
            this.LbZInterval.Location = new System.Drawing.Point(236, 159);
            this.LbZInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbZInterval.Name = "LbZInterval";
            this.LbZInterval.Size = new System.Drawing.Size(69, 17);
            this.LbZInterval.TabIndex = 11;
            this.LbZInterval.Text = "z интерв.";
            // 
            // TbZMax
            // 
            this.TbZMax.Location = new System.Drawing.Point(122, 180);
            this.TbZMax.Margin = new System.Windows.Forms.Padding(4);
            this.TbZMax.Name = "TbZMax";
            this.TbZMax.Size = new System.Drawing.Size(101, 22);
            this.TbZMax.TabIndex = 10;
            this.TbZMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbZMax
            // 
            this.LbZMax.AutoSize = true;
            this.LbZMax.Location = new System.Drawing.Point(127, 159);
            this.LbZMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbZMax.Name = "LbZMax";
            this.LbZMax.Size = new System.Drawing.Size(54, 17);
            this.LbZMax.TabIndex = 9;
            this.LbZMax.Text = "z макс.";
            // 
            // TbZMin
            // 
            this.TbZMin.Location = new System.Drawing.Point(13, 180);
            this.TbZMin.Margin = new System.Windows.Forms.Padding(4);
            this.TbZMin.Name = "TbZMin";
            this.TbZMin.Size = new System.Drawing.Size(101, 22);
            this.TbZMin.TabIndex = 8;
            this.TbZMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbZMin
            // 
            this.LbZMin.AutoSize = true;
            this.LbZMin.Location = new System.Drawing.Point(13, 159);
            this.LbZMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbZMin.Name = "LbZMin";
            this.LbZMin.Size = new System.Drawing.Size(48, 17);
            this.LbZMin.TabIndex = 7;
            this.LbZMin.Text = "z мин.";
            // 
            // TbKappa
            // 
            this.TbKappa.Location = new System.Drawing.Point(13, 133);
            this.TbKappa.Margin = new System.Windows.Forms.Padding(4);
            this.TbKappa.Name = "TbKappa";
            this.TbKappa.Size = new System.Drawing.Size(319, 22);
            this.TbKappa.TabIndex = 6;
            this.TbKappa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbKappa
            // 
            this.LbKappa.AutoSize = true;
            this.LbKappa.Location = new System.Drawing.Point(10, 112);
            this.LbKappa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbKappa.Name = "LbKappa";
            this.LbKappa.Size = new System.Drawing.Size(165, 17);
            this.LbKappa.TabIndex = 5;
            this.LbKappa.Text = "Время запаздывания, ϰ";
            // 
            // TbBigOmega
            // 
            this.TbBigOmega.Location = new System.Drawing.Point(13, 86);
            this.TbBigOmega.Margin = new System.Windows.Forms.Padding(4);
            this.TbBigOmega.Name = "TbBigOmega";
            this.TbBigOmega.Size = new System.Drawing.Size(319, 22);
            this.TbBigOmega.TabIndex = 4;
            this.TbBigOmega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbBigOmega
            // 
            this.LbBigOmega.AutoSize = true;
            this.LbBigOmega.Location = new System.Drawing.Point(13, 65);
            this.LbBigOmega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbBigOmega.Name = "LbBigOmega";
            this.LbBigOmega.Size = new System.Drawing.Size(204, 17);
            this.LbBigOmega.TabIndex = 3;
            this.LbBigOmega.Text = "Произвольная постоянная, Ω";
            // 
            // TbNu
            // 
            this.TbNu.Location = new System.Drawing.Point(13, 39);
            this.TbNu.Margin = new System.Windows.Forms.Padding(4);
            this.TbNu.Name = "TbNu";
            this.TbNu.Size = new System.Drawing.Size(319, 22);
            this.TbNu.TabIndex = 2;
            this.TbNu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbNu
            // 
            this.LbNu.AutoSize = true;
            this.LbNu.Location = new System.Drawing.Point(13, 18);
            this.LbNu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbNu.Name = "LbNu";
            this.LbNu.Size = new System.Drawing.Size(292, 17);
            this.LbNu.TabIndex = 1;
            this.LbNu.Text = "Кинематический коэффициент вязкости, ν";
            // 
            // BtSave
            // 
            this.BtSave.Location = new System.Drawing.Point(71, 304);
            this.BtSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(201, 46);
            this.BtSave.TabIndex = 17;
            this.BtSave.Text = "Сохранить таблицу";
            this.BtSave.UseVisualStyleBackColor = true;
            this.BtSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // TbTAcc
            // 
            this.TbTAcc.Location = new System.Drawing.Point(16, 274);
            this.TbTAcc.Margin = new System.Windows.Forms.Padding(4);
            this.TbTAcc.Name = "TbTAcc";
            this.TbTAcc.Size = new System.Drawing.Size(316, 22);
            this.TbTAcc.TabIndex = 16;
            this.TbTAcc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbTAcc
            // 
            this.LbTAcc.AutoSize = true;
            this.LbTAcc.Location = new System.Drawing.Point(13, 253);
            this.LbTAcc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbTAcc.Name = "LbTAcc";
            this.LbTAcc.Size = new System.Drawing.Size(53, 17);
            this.LbTAcc.TabIndex = 15;
            this.LbTAcc.Text = "Точн. t";
            // 
            // SetValuesForT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 371);
            this.Controls.Add(this.TbTAcc);
            this.Controls.Add(this.LbTAcc);
            this.Controls.Add(this.BtSave);
            this.Controls.Add(this.TbT);
            this.Controls.Add(this.LbT);
            this.Controls.Add(this.TbZInterval);
            this.Controls.Add(this.LbZInterval);
            this.Controls.Add(this.TbZMax);
            this.Controls.Add(this.LbZMax);
            this.Controls.Add(this.TbZMin);
            this.Controls.Add(this.LbZMin);
            this.Controls.Add(this.TbKappa);
            this.Controls.Add(this.LbKappa);
            this.Controls.Add(this.TbBigOmega);
            this.Controls.Add(this.LbBigOmega);
            this.Controls.Add(this.TbNu);
            this.Controls.Add(this.LbNu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SetValuesForT";
            this.Text = "Значения для t";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.TextBox TbT;
        private System.Windows.Forms.Label LbT;
        private System.Windows.Forms.TextBox TbZInterval;
        private System.Windows.Forms.Label LbZInterval;
        private System.Windows.Forms.TextBox TbZMax;
        private System.Windows.Forms.Label LbZMax;
        private System.Windows.Forms.TextBox TbZMin;
        private System.Windows.Forms.Label LbZMin;
        private System.Windows.Forms.TextBox TbKappa;
        private System.Windows.Forms.Label LbKappa;
        private System.Windows.Forms.TextBox TbBigOmega;
        private System.Windows.Forms.Label LbBigOmega;
        private System.Windows.Forms.TextBox TbNu;
        private System.Windows.Forms.Label LbNu;
        private System.Windows.Forms.Button BtSave;
        private System.Windows.Forms.TextBox TbTAcc;
        private System.Windows.Forms.Label LbTAcc;
    }
}
namespace Task3
{
    partial class SetValuesForZ
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
            this.TbZ = new System.Windows.Forms.TextBox();
            this.LbZ = new System.Windows.Forms.Label();
            this.TbTInterval = new System.Windows.Forms.TextBox();
            this.LbTInterval = new System.Windows.Forms.Label();
            this.TbTMax = new System.Windows.Forms.TextBox();
            this.LbTMax = new System.Windows.Forms.Label();
            this.TbTMin = new System.Windows.Forms.TextBox();
            this.LbTMin = new System.Windows.Forms.Label();
            this.TbKappa = new System.Windows.Forms.TextBox();
            this.LbKappa = new System.Windows.Forms.Label();
            this.TbBigOmega = new System.Windows.Forms.TextBox();
            this.LbBigOmega = new System.Windows.Forms.Label();
            this.TbNu = new System.Windows.Forms.TextBox();
            this.LbNu = new System.Windows.Forms.Label();
            this.BtSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbZ
            // 
            this.TbZ.Location = new System.Drawing.Point(13, 236);
            this.TbZ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbZ.Name = "TbZ";
            this.TbZ.Size = new System.Drawing.Size(319, 22);
            this.TbZ.TabIndex = 14;
            this.TbZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbZ
            // 
            this.LbZ.AutoSize = true;
            this.LbZ.Location = new System.Drawing.Point(10, 215);
            this.LbZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbZ.Name = "LbZ";
            this.LbZ.Size = new System.Drawing.Size(99, 17);
            this.LbZ.TabIndex = 13;
            this.LbZ.Text = "Координата z";
            // 
            // TbTInterval
            // 
            this.TbTInterval.Location = new System.Drawing.Point(231, 187);
            this.TbTInterval.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbTInterval.Name = "TbTInterval";
            this.TbTInterval.Size = new System.Drawing.Size(101, 22);
            this.TbTInterval.TabIndex = 12;
            this.TbTInterval.TextChanged += new System.EventHandler(this.TbTInterval_TextChanged);
            this.TbTInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbTInterval
            // 
            this.LbTInterval.AutoSize = true;
            this.LbTInterval.Location = new System.Drawing.Point(228, 166);
            this.LbTInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbTInterval.Name = "LbTInterval";
            this.LbTInterval.Size = new System.Drawing.Size(66, 17);
            this.LbTInterval.TabIndex = 11;
            this.LbTInterval.Text = "t интерв.";
            // 
            // TbTMax
            // 
            this.TbTMax.Location = new System.Drawing.Point(122, 187);
            this.TbTMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbTMax.Name = "TbTMax";
            this.TbTMax.Size = new System.Drawing.Size(101, 22);
            this.TbTMax.TabIndex = 10;
            this.TbTMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbTMax
            // 
            this.LbTMax.AutoSize = true;
            this.LbTMax.Location = new System.Drawing.Point(119, 166);
            this.LbTMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbTMax.Name = "LbTMax";
            this.LbTMax.Size = new System.Drawing.Size(51, 17);
            this.LbTMax.TabIndex = 9;
            this.LbTMax.Text = "t макс.";
            // 
            // TbTMin
            // 
            this.TbTMin.Location = new System.Drawing.Point(13, 187);
            this.TbTMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbTMin.Name = "TbTMin";
            this.TbTMin.Size = new System.Drawing.Size(101, 22);
            this.TbTMin.TabIndex = 8;
            this.TbTMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbTMin
            // 
            this.LbTMin.AutoSize = true;
            this.LbTMin.Location = new System.Drawing.Point(10, 166);
            this.LbTMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbTMin.Name = "LbTMin";
            this.LbTMin.Size = new System.Drawing.Size(45, 17);
            this.LbTMin.TabIndex = 7;
            this.LbTMin.Text = "t мин.";
            // 
            // TbKappa
            // 
            this.TbKappa.Location = new System.Drawing.Point(13, 133);
            this.TbKappa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.TbBigOmega.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.TbNu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.BtSave.Location = new System.Drawing.Point(74, 266);
            this.BtSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(201, 46);
            this.BtSave.TabIndex = 17;
            this.BtSave.Text = "Сохранить таблицу";
            this.BtSave.UseVisualStyleBackColor = true;
            this.BtSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // SetValuesForZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 371);
            this.Controls.Add(this.BtSave);
            this.Controls.Add(this.TbZ);
            this.Controls.Add(this.LbZ);
            this.Controls.Add(this.TbTInterval);
            this.Controls.Add(this.LbTInterval);
            this.Controls.Add(this.TbTMax);
            this.Controls.Add(this.LbTMax);
            this.Controls.Add(this.TbTMin);
            this.Controls.Add(this.LbTMin);
            this.Controls.Add(this.TbKappa);
            this.Controls.Add(this.LbKappa);
            this.Controls.Add(this.TbBigOmega);
            this.Controls.Add(this.LbBigOmega);
            this.Controls.Add(this.TbNu);
            this.Controls.Add(this.LbNu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SetValuesForZ";
            this.Text = "Значения для t";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.TextBox TbZ;
        private System.Windows.Forms.Label LbZ;
        private System.Windows.Forms.TextBox TbTInterval;
        private System.Windows.Forms.Label LbTInterval;
        private System.Windows.Forms.TextBox TbTMax;
        private System.Windows.Forms.Label LbTMax;
        private System.Windows.Forms.TextBox TbTMin;
        private System.Windows.Forms.Label LbTMin;
        private System.Windows.Forms.TextBox TbKappa;
        private System.Windows.Forms.Label LbKappa;
        private System.Windows.Forms.TextBox TbBigOmega;
        private System.Windows.Forms.Label LbBigOmega;
        private System.Windows.Forms.TextBox TbNu;
        private System.Windows.Forms.Label LbNu;
        private System.Windows.Forms.Button BtSave;
    }
}
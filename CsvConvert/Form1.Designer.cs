namespace CsvConvert
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getPathBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.outputPath = new System.Windows.Forms.TextBox();
            this.outputPathLabel = new System.Windows.Forms.Label();
            this.InputFileLabel = new System.Windows.Forms.Label();
            this.getOutputPathBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // getPathBtn
            // 
            this.getPathBtn.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.getPathBtn.Location = new System.Drawing.Point(1203, 343);
            this.getPathBtn.Name = "getPathBtn";
            this.getPathBtn.Size = new System.Drawing.Size(154, 40);
            this.getPathBtn.TabIndex = 0;
            this.getPathBtn.Text = "瀏覽...";
            this.getPathBtn.UseVisualStyleBackColor = true;
            this.getPathBtn.Click += new System.EventHandler(this.getPathBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(723, 340);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(455, 34);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(423, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "欲分析得減薄缺陷編號(1~xx)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(524, 589);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "輸出檔案";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputPath
            // 
            this.outputPath.Location = new System.Drawing.Point(723, 595);
            this.outputPath.Name = "outputPath";
            this.outputPath.ReadOnly = true;
            this.outputPath.Size = new System.Drawing.Size(455, 34);
            this.outputPath.TabIndex = 1;
            this.outputPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // outputPathLabel
            // 
            this.outputPathLabel.AutoSize = true;
            this.outputPathLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputPathLabel.Location = new System.Drawing.Point(492, 768);
            this.outputPathLabel.Name = "outputPathLabel";
            this.outputPathLabel.Size = new System.Drawing.Size(995, 29);
            this.outputPathLabel.TabIndex = 4;
            this.outputPathLabel.Text = "版權所有©2020 台塑企業麥寮廠｜ 建議瀏覽解析度1024x768以上 ｜ 程式撰寫：工業技術研究院";
            // 
            // InputFileLabel
            // 
            this.InputFileLabel.AutoSize = true;
            this.InputFileLabel.BackColor = System.Drawing.Color.Transparent;
            this.InputFileLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InputFileLabel.Location = new System.Drawing.Point(423, 343);
            this.InputFileLabel.Name = "InputFileLabel";
            this.InputFileLabel.Size = new System.Drawing.Size(267, 36);
            this.InputFileLabel.TabIndex = 4;
            this.InputFileLabel.Text = "請選擇要匯入的檔案";
            // 
            // getOutputPathBtn
            // 
            this.getOutputPathBtn.Enabled = false;
            this.getOutputPathBtn.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.getOutputPathBtn.Location = new System.Drawing.Point(1203, 595);
            this.getOutputPathBtn.Name = "getOutputPathBtn";
            this.getOutputPathBtn.Size = new System.Drawing.Size(154, 40);
            this.getOutputPathBtn.TabIndex = 5;
            this.getOutputPathBtn.Text = "瀏覽...";
            this.getOutputPathBtn.UseVisualStyleBackColor = true;
            this.getOutputPathBtn.Click += new System.EventHandler(this.getOutputPathBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(812, 454);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 34);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(623, 168);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(734, 109);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1917, 832);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.getOutputPathBtn);
            this.Controls.Add(this.InputFileLabel);
            this.Controls.Add(this.outputPathLabel);
            this.Controls.Add(this.outputPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.getPathBtn);
            this.Name = "Form1";
            this.Text = "CsvConverter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getPathBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox outputPath;
        private System.Windows.Forms.Label outputPathLabel;
        private System.Windows.Forms.Label InputFileLabel;
        private System.Windows.Forms.Button getOutputPathBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


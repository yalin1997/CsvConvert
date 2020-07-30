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
            this.getPathBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.outputPath = new System.Windows.Forms.TextBox();
            this.outputPathLabel = new System.Windows.Forms.Label();
            this.輸入檔案 = new System.Windows.Forms.Label();
            this.getOutputPathBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getPathBtn
            // 
            this.getPathBtn.Location = new System.Drawing.Point(699, 228);
            this.getPathBtn.Name = "getPathBtn";
            this.getPathBtn.Size = new System.Drawing.Size(154, 61);
            this.getPathBtn.TabIndex = 0;
            this.getPathBtn.Text = "瀏覽";
            this.getPathBtn.UseVisualStyleBackColor = true;
            this.getPathBtn.Click += new System.EventHandler(this.getPathBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(455, 34);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "共有 ? 個特徵 要第幾個?";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(641, 365);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(34, 34);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "開始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputPath
            // 
            this.outputPath.Location = new System.Drawing.Point(247, 465);
            this.outputPath.Name = "outputPath";
            this.outputPath.Size = new System.Drawing.Size(455, 34);
            this.outputPath.TabIndex = 1;
            this.outputPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // outputPathLabel
            // 
            this.outputPathLabel.AutoSize = true;
            this.outputPathLabel.Location = new System.Drawing.Point(128, 468);
            this.outputPathLabel.Name = "outputPathLabel";
            this.outputPathLabel.Size = new System.Drawing.Size(96, 26);
            this.outputPathLabel.TabIndex = 4;
            this.outputPathLabel.Text = "輸出路徑";
            // 
            // 輸入檔案
            // 
            this.輸入檔案.AutoSize = true;
            this.輸入檔案.Location = new System.Drawing.Point(128, 245);
            this.輸入檔案.Name = "輸入檔案";
            this.輸入檔案.Size = new System.Drawing.Size(96, 26);
            this.輸入檔案.TabIndex = 4;
            this.輸入檔案.Text = "輸出路徑";
            // 
            // getOutputPathBtn
            // 
            this.getOutputPathBtn.Location = new System.Drawing.Point(708, 446);
            this.getOutputPathBtn.Name = "getOutputPathBtn";
            this.getOutputPathBtn.Size = new System.Drawing.Size(168, 71);
            this.getOutputPathBtn.TabIndex = 5;
            this.getOutputPathBtn.Text = "瀏覽";
            this.getOutputPathBtn.UseVisualStyleBackColor = true;
            this.getOutputPathBtn.Click += new System.EventHandler(this.getOutputPathBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 774);
            this.Controls.Add(this.getOutputPathBtn);
            this.Controls.Add(this.輸入檔案);
            this.Controls.Add(this.outputPathLabel);
            this.Controls.Add(this.outputPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.getPathBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getPathBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox outputPath;
        private System.Windows.Forms.Label outputPathLabel;
        private System.Windows.Forms.Label 輸入檔案;
        private System.Windows.Forms.Button getOutputPathBtn;
    }
}


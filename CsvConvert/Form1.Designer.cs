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
            this.button1 = new System.Windows.Forms.Button();
            this.outputPath = new System.Windows.Forms.TextBox();
            this.outputPathLabel = new System.Windows.Forms.Label();
            this.輸入檔案 = new System.Windows.Forms.Label();
            this.getOutputPathBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // getPathBtn
            // 
            this.getPathBtn.Location = new System.Drawing.Point(408, 132);
            this.getPathBtn.Margin = new System.Windows.Forms.Padding(2);
            this.getPathBtn.Name = "getPathBtn";
            this.getPathBtn.Size = new System.Drawing.Size(90, 35);
            this.getPathBtn.TabIndex = 0;
            this.getPathBtn.Text = "瀏覽";
            this.getPathBtn.UseVisualStyleBackColor = true;
            this.getPathBtn.Click += new System.EventHandler(this.getPathBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 140);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(267, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "共有 ? 個特徵 要第幾個?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 339);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "開始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputPath
            // 
            this.outputPath.Location = new System.Drawing.Point(144, 268);
            this.outputPath.Margin = new System.Windows.Forms.Padding(2);
            this.outputPath.Name = "outputPath";
            this.outputPath.ReadOnly = true;
            this.outputPath.Size = new System.Drawing.Size(267, 23);
            this.outputPath.TabIndex = 1;
            this.outputPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // outputPathLabel
            // 
            this.outputPathLabel.AutoSize = true;
            this.outputPathLabel.Location = new System.Drawing.Point(75, 270);
            this.outputPathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputPathLabel.Name = "outputPathLabel";
            this.outputPathLabel.Size = new System.Drawing.Size(55, 15);
            this.outputPathLabel.TabIndex = 4;
            this.outputPathLabel.Text = "輸出路徑";
            // 
            // 輸入檔案
            // 
            this.輸入檔案.AutoSize = true;
            this.輸入檔案.Location = new System.Drawing.Point(75, 141);
            this.輸入檔案.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.輸入檔案.Name = "輸入檔案";
            this.輸入檔案.Size = new System.Drawing.Size(55, 15);
            this.輸入檔案.TabIndex = 4;
            this.輸入檔案.Text = "輸出路徑";
            // 
            // getOutputPathBtn
            // 
            this.getOutputPathBtn.Enabled = false;
            this.getOutputPathBtn.Location = new System.Drawing.Point(413, 257);
            this.getOutputPathBtn.Margin = new System.Windows.Forms.Padding(2);
            this.getOutputPathBtn.Name = "getOutputPathBtn";
            this.getOutputPathBtn.Size = new System.Drawing.Size(98, 41);
            this.getOutputPathBtn.TabIndex = 5;
            this.getOutputPathBtn.Text = "瀏覽";
            this.getOutputPathBtn.UseVisualStyleBackColor = true;
            this.getOutputPathBtn.Click += new System.EventHandler(this.getOutputPathBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(374, 207);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(40, 23);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 447);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.getOutputPathBtn);
            this.Controls.Add(this.輸入檔案);
            this.Controls.Add(this.outputPathLabel);
            this.Controls.Add(this.outputPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.getPathBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label 輸入檔案;
        private System.Windows.Forms.Button getOutputPathBtn;
        private System.Windows.Forms.TextBox textBox2;
    }
}


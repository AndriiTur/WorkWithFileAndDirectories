namespace WorkWithFileAndDirectories
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
            this.TextBoxPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OutTextBox = new System.Windows.Forms.TextBox();
            this.FindMaxSizeFileButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MaskTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxPath
            // 
            this.TextBoxPath.Location = new System.Drawing.Point(12, 28);
            this.TextBoxPath.Name = "TextBoxPath";
            this.TextBoxPath.Size = new System.Drawing.Size(333, 20);
            this.TextBoxPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Path";
            // 
            // OutTextBox
            // 
            this.OutTextBox.Location = new System.Drawing.Point(12, 92);
            this.OutTextBox.Multiline = true;
            this.OutTextBox.Name = "OutTextBox";
            this.OutTextBox.Size = new System.Drawing.Size(333, 282);
            this.OutTextBox.TabIndex = 0;
            // 
            // FindMaxSizeFileButton
            // 
            this.FindMaxSizeFileButton.Location = new System.Drawing.Point(382, 25);
            this.FindMaxSizeFileButton.Name = "FindMaxSizeFileButton";
            this.FindMaxSizeFileButton.Size = new System.Drawing.Size(75, 23);
            this.FindMaxSizeFileButton.TabIndex = 2;
            this.FindMaxSizeFileButton.Text = "FindMaxSizeFile";
            this.FindMaxSizeFileButton.UseVisualStyleBackColor = true;
            this.FindMaxSizeFileButton.Click += new System.EventHandler(this.FindMaxSizeFileButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 20);
            this.textBox1.TabIndex = 0;
            // 
            // MaskTextBox
            // 
            this.MaskTextBox.Location = new System.Drawing.Point(12, 66);
            this.MaskTextBox.Name = "MaskTextBox";
            this.MaskTextBox.Size = new System.Drawing.Size(333, 20);
            this.MaskTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SearchingFile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 386);
            this.Controls.Add(this.FindMaxSizeFileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutTextBox);
            this.Controls.Add(this.MaskTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TextBoxPath);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "SearchingFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutTextBox;
        private System.Windows.Forms.Button FindMaxSizeFileButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox MaskTextBox;
        private System.Windows.Forms.Label label2;
    }
}


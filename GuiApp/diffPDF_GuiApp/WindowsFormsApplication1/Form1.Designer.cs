namespace DiffPdfDirectoryApplicationGUI
{
    partial class DiffPdfDirGui
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
            this.Directory1Button = new System.Windows.Forms.Button();
            this.Directory2Button = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ComparisonOutputDirectoryButton = new System.Windows.Forms.Button();
            this.Directory1Text = new System.Windows.Forms.TextBox();
            this.Directory2Text = new System.Windows.Forms.TextBox();
            this.ComparisonOutputDirectoryText = new System.Windows.Forms.TextBox();
            this.StartComparison = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ComparisonCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Directory1Button
            // 
            this.Directory1Button.Location = new System.Drawing.Point(13, 28);
            this.Directory1Button.Name = "Directory1Button";
            this.Directory1Button.Size = new System.Drawing.Size(75, 23);
            this.Directory1Button.TabIndex = 1;
            this.Directory1Button.Text = "Directory 1";
            this.Directory1Button.UseVisualStyleBackColor = true;
            this.Directory1Button.Click += new System.EventHandler(this.Directory1Button_Click);
            // 
            // Directory2Button
            // 
            this.Directory2Button.Location = new System.Drawing.Point(13, 70);
            this.Directory2Button.Name = "Directory2Button";
            this.Directory2Button.Size = new System.Drawing.Size(75, 23);
            this.Directory2Button.TabIndex = 2;
            this.Directory2Button.Text = "Directory 2";
            this.Directory2Button.UseVisualStyleBackColor = true;
            this.Directory2Button.Click += new System.EventHandler(this.Directory2Button_Click);
            // 
            // ComparisonOutputDirectoryButton
            // 
            this.ComparisonOutputDirectoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComparisonOutputDirectoryButton.AutoSize = true;
            this.ComparisonOutputDirectoryButton.Location = new System.Drawing.Point(12, 114);
            this.ComparisonOutputDirectoryButton.Name = "ComparisonOutputDirectoryButton";
            this.ComparisonOutputDirectoryButton.Size = new System.Drawing.Size(152, 23);
            this.ComparisonOutputDirectoryButton.TabIndex = 3;
            this.ComparisonOutputDirectoryButton.Text = "Comparison Output Directory";
            this.ComparisonOutputDirectoryButton.UseVisualStyleBackColor = true;
            this.ComparisonOutputDirectoryButton.Click += new System.EventHandler(this.ComparisonOutputDirectoryButton_Click);
            // 
            // Directory1Text
            // 
            this.Directory1Text.Location = new System.Drawing.Point(94, 28);
            this.Directory1Text.Name = "Directory1Text";
            this.Directory1Text.Size = new System.Drawing.Size(743, 20);
            this.Directory1Text.TabIndex = 4;
            this.Directory1Text.TextChanged += new System.EventHandler(this.Directory1Text_TextChanged);
            // 
            // Directory2Text
            // 
            this.Directory2Text.Location = new System.Drawing.Point(94, 73);
            this.Directory2Text.Name = "Directory2Text";
            this.Directory2Text.Size = new System.Drawing.Size(743, 20);
            this.Directory2Text.TabIndex = 5;
            this.Directory2Text.TextChanged += new System.EventHandler(this.Directory2Text_TextChanged);
            // 
            // ComparisonOutputDirectoryText
            // 
            this.ComparisonOutputDirectoryText.Location = new System.Drawing.Point(170, 117);
            this.ComparisonOutputDirectoryText.Name = "ComparisonOutputDirectoryText";
            this.ComparisonOutputDirectoryText.Size = new System.Drawing.Size(667, 20);
            this.ComparisonOutputDirectoryText.TabIndex = 6;
            this.ComparisonOutputDirectoryText.TextChanged += new System.EventHandler(this.ComparisonOutputDirectoryText_TextChanged);
            // 
            // StartComparison
            // 
            this.StartComparison.Location = new System.Drawing.Point(330, 170);
            this.StartComparison.Name = "StartComparison";
            this.StartComparison.Size = new System.Drawing.Size(109, 23);
            this.StartComparison.TabIndex = 7;
            this.StartComparison.Text = "Start Comparison";
            this.StartComparison.UseVisualStyleBackColor = true;
            this.StartComparison.Click += new System.EventHandler(this.StartComparison_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(128, 199);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(541, 23);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Visible = false;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // ComparisonCount
            // 
            this.ComparisonCount.BackColor = System.Drawing.SystemColors.Control;
            this.ComparisonCount.Location = new System.Drawing.Point(676, 201);
            this.ComparisonCount.Name = "ComparisonCount";
            this.ComparisonCount.ReadOnly = true;
            this.ComparisonCount.Size = new System.Drawing.Size(69, 20);
            this.ComparisonCount.TabIndex = 9;
            this.ComparisonCount.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 262);
            this.Controls.Add(this.ComparisonCount);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.StartComparison);
            this.Controls.Add(this.ComparisonOutputDirectoryText);
            this.Controls.Add(this.Directory2Text);
            this.Controls.Add(this.Directory1Text);
            this.Controls.Add(this.ComparisonOutputDirectoryButton);
            this.Controls.Add(this.Directory2Button);
            this.Controls.Add(this.Directory1Button);
            this.Name = "Form1";
            this.Text = "DiffPDF Directory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Directory1Button;
        private System.Windows.Forms.Button Directory2Button;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button ComparisonOutputDirectoryButton;
        private System.Windows.Forms.TextBox Directory1Text;
        private System.Windows.Forms.TextBox Directory2Text;
        private System.Windows.Forms.TextBox ComparisonOutputDirectoryText;
        private System.Windows.Forms.Button StartComparison;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox ComparisonCount;


    }
}


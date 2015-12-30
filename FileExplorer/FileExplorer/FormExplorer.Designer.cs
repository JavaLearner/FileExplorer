namespace FileExplorer
{
    partial class FileExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileExplorer));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.labelSource = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(9, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(44, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(68, 9);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(44, 23);
            this.btnForward.TabIndex = 1;
            this.btnForward.Text = ">>";
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(674, 9);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Open";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(118, 14);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(29, 13);
            this.labelSource.TabIndex = 3;
            this.labelSource.Text = "Path";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(153, 11);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(515, 20);
            this.textBox.TabIndex = 4;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(9, 48);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(740, 299);
            this.webBrowser1.TabIndex = 5;
            // 
            // FileExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 359);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Explorer v 0.01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}


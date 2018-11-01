namespace Exam2
{
    partial class HomeUi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MobileIMEButton = new System.Windows.Forms.Button();
            this.MobilePriceButton = new System.Windows.Forms.Button();
            this.MobileEntryButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MobileIMEButton);
            this.groupBox1.Controls.Add(this.MobilePriceButton);
            this.groupBox1.Controls.Add(this.MobileEntryButton);
            this.groupBox1.Location = new System.Drawing.Point(31, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Index";
            // 
            // MobileIMEButton
            // 
            this.MobileIMEButton.Location = new System.Drawing.Point(16, 77);
            this.MobileIMEButton.Name = "MobileIMEButton";
            this.MobileIMEButton.Size = new System.Drawing.Size(225, 23);
            this.MobileIMEButton.TabIndex = 2;
            this.MobileIMEButton.Text = "Search Mobile Handset by IME";
            this.MobileIMEButton.UseVisualStyleBackColor = true;
            this.MobileIMEButton.Click += new System.EventHandler(this.MobileIMEButton_Click);
            // 
            // MobilePriceButton
            // 
            this.MobilePriceButton.Location = new System.Drawing.Point(16, 48);
            this.MobilePriceButton.Name = "MobilePriceButton";
            this.MobilePriceButton.Size = new System.Drawing.Size(225, 23);
            this.MobilePriceButton.TabIndex = 1;
            this.MobilePriceButton.Text = "Search Mobile Handset by Price Range";
            this.MobilePriceButton.UseVisualStyleBackColor = true;
            this.MobilePriceButton.Click += new System.EventHandler(this.MobilePriceButton_Click);
            // 
            // MobileEntryButton
            // 
            this.MobileEntryButton.Location = new System.Drawing.Point(16, 19);
            this.MobileEntryButton.Name = "MobileEntryButton";
            this.MobileEntryButton.Size = new System.Drawing.Size(225, 23);
            this.MobileEntryButton.TabIndex = 0;
            this.MobileEntryButton.Text = "Save Mobile Handset Information";
            this.MobileEntryButton.UseVisualStyleBackColor = true;
            this.MobileEntryButton.Click += new System.EventHandler(this.MobileEntryButton_Click);
            // 
            // HomeUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 145);
            this.Controls.Add(this.groupBox1);
            this.Name = "HomeUi";
            this.Text = "Home";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button MobileIMEButton;
        private System.Windows.Forms.Button MobilePriceButton;
        private System.Windows.Forms.Button MobileEntryButton;
    }
}


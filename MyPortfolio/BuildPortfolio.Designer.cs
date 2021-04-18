namespace MyPortfolio
{
    partial class BuildPortfolio
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddPortfolio = new System.Windows.Forms.Button();
            this.PortfolioNameTextBox = new System.Windows.Forms.TextBox();
            this.PortfoliosPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome User !!";
            // 
            // AddPortfolio
            // 
            this.AddPortfolio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddPortfolio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddPortfolio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddPortfolio.Location = new System.Drawing.Point(710, 47);
            this.AddPortfolio.Name = "AddPortfolio";
            this.AddPortfolio.Size = new System.Drawing.Size(251, 43);
            this.AddPortfolio.TabIndex = 1;
            this.AddPortfolio.Text = "Add New Portfolio";
            this.AddPortfolio.UseVisualStyleBackColor = false;
            this.AddPortfolio.Click += new System.EventHandler(this.AddPortfolio_Click);
            // 
            // PortfolioNameTextBox
            // 
            this.PortfolioNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PortfolioNameTextBox.Location = new System.Drawing.Point(445, 47);
            this.PortfolioNameTextBox.Multiline = true;
            this.PortfolioNameTextBox.Name = "PortfolioNameTextBox";
            this.PortfolioNameTextBox.PlaceholderText = "Enter Portfolio name here";
            this.PortfolioNameTextBox.Size = new System.Drawing.Size(243, 43);
            this.PortfolioNameTextBox.TabIndex = 2;
            // 
            // PortfoliosPanel
            // 
            this.PortfoliosPanel.AutoScroll = true;
            this.PortfoliosPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PortfoliosPanel.Location = new System.Drawing.Point(60, 167);
            this.PortfoliosPanel.Name = "PortfoliosPanel";
            this.PortfoliosPanel.Padding = new System.Windows.Forms.Padding(5);
            this.PortfoliosPanel.Size = new System.Drawing.Size(901, 401);
            this.PortfoliosPanel.TabIndex = 3;
            // 
            // BuildPortfolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 591);
            this.Controls.Add(this.PortfoliosPanel);
            this.Controls.Add(this.PortfolioNameTextBox);
            this.Controls.Add(this.AddPortfolio);
            this.Controls.Add(this.label1);
            this.Name = "BuildPortfolio";
            this.Text = "Build your portfolio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddPortfolio;
        private System.Windows.Forms.TextBox PortfolioNameTextBox;
        private System.Windows.Forms.Panel PortfoliosPanel;
    }
}
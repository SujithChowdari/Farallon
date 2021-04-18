namespace MyPortfolio
{
    partial class Portfolio
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TradeType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Ticker = new System.Windows.Forms.ComboBox();
            this.TradesGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.NumberOfInvestmentsPanel = new System.Windows.Forms.Panel();
            this.NumberOfInvestmentsLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ProfitPanel = new System.Windows.Forms.Panel();
            this.NetProfitValueLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalAmountInvestedPanel = new System.Windows.Forms.Panel();
            this.TotalInvestmentLabel = new System.Windows.Forms.Label();
            this.NetLossLabel = new System.Windows.Forms.Label();
            this.PortfolioPerformanceGridView = new System.Windows.Forms.DataGridView();
            this.TradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TradesGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.NumberOfInvestmentsPanel.SuspendLayout();
            this.ProfitPanel.SuspendLayout();
            this.TotalAmountInvestedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortfolioPerformanceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1245, 461);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.PortfolioTabControl_SelectedIndexchanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.TradesGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1237, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trades";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TradeType);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.Quantity);
            this.groupBox1.Controls.Add(this.Ticker);
            this.groupBox1.Location = new System.Drawing.Point(826, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 394);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buy/Sell";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buy/Sell:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Symbol:";
            // 
            // TradeType
            // 
            this.TradeType.FormattingEnabled = true;
            this.TradeType.Items.AddRange(new object[] {
            "Buy",
            "Sell"});
            this.TradeType.Location = new System.Drawing.Point(159, 104);
            this.TradeType.Name = "TradeType";
            this.TradeType.Size = new System.Drawing.Size(182, 33);
            this.TradeType.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Trade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddTrade_Click);
            // 
            // Price
            // 
            this.Price.Enabled = false;
            this.Price.Location = new System.Drawing.Point(157, 219);
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(186, 31);
            this.Price.TabIndex = 1;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(157, 163);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(186, 31);
            this.Quantity.TabIndex = 1;
            // 
            // Ticker
            // 
            this.Ticker.FormattingEnabled = true;
            this.Ticker.Items.AddRange(new object[] {
            "AAPL",
            "MSFT",
            "AMZN",
            "GOOG",
            "FB",
            "TSLA",
            "BABA",
            "PYPL"});
            this.Ticker.Location = new System.Drawing.Point(157, 45);
            this.Ticker.Name = "Ticker";
            this.Ticker.Size = new System.Drawing.Size(186, 33);
            this.Ticker.TabIndex = 0;
            this.Ticker.SelectedIndexChanged += new System.EventHandler(this.Ticker_SelectedIndexChanged);
            // 
            // TradesGridView
            // 
            this.TradesGridView.AllowUserToOrderColumns = true;
            this.TradesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TradesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TradesGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.TradesGridView.Location = new System.Drawing.Point(3, 3);
            this.TradesGridView.Name = "TradesGridView";
            this.TradesGridView.ReadOnly = true;
            this.TradesGridView.RowHeadersWidth = 62;
            this.TradesGridView.Size = new System.Drawing.Size(803, 417);
            this.TradesGridView.TabIndex = 1;
            this.TradesGridView.Text = "dataGridView2";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.NumberOfInvestmentsPanel);
            this.tabPage2.Controls.Add(this.ProfitPanel);
            this.tabPage2.Controls.Add(this.TotalAmountInvestedPanel);
            this.tabPage2.Controls.Add(this.PortfolioPerformanceGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1237, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Profit/Loss";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // NumberOfInvestmentsPanel
            // 
            this.NumberOfInvestmentsPanel.Controls.Add(this.NumberOfInvestmentsLabel);
            this.NumberOfInvestmentsPanel.Controls.Add(this.label10);
            this.NumberOfInvestmentsPanel.Location = new System.Drawing.Point(836, 0);
            this.NumberOfInvestmentsPanel.Name = "NumberOfInvestmentsPanel";
            this.NumberOfInvestmentsPanel.Size = new System.Drawing.Size(398, 92);
            this.NumberOfInvestmentsPanel.TabIndex = 1;
            // 
            // NumberOfInvestmentsLabel
            // 
            this.NumberOfInvestmentsLabel.AutoSize = true;
            this.NumberOfInvestmentsLabel.Location = new System.Drawing.Point(193, 56);
            this.NumberOfInvestmentsLabel.Name = "NumberOfInvestmentsLabel";
            this.NumberOfInvestmentsLabel.Size = new System.Drawing.Size(0, 25);
            this.NumberOfInvestmentsLabel.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(54, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(308, 38);
            this.label10.TabIndex = 2;
            this.label10.Text = "Number of Investments";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProfitPanel
            // 
            this.ProfitPanel.Controls.Add(this.NetProfitValueLabel);
            this.ProfitPanel.Controls.Add(this.label5);
            this.ProfitPanel.Location = new System.Drawing.Point(0, 0);
            this.ProfitPanel.Name = "ProfitPanel";
            this.ProfitPanel.Size = new System.Drawing.Size(394, 92);
            this.ProfitPanel.TabIndex = 1;
            // 
            // NetProfitValueLabel
            // 
            this.NetProfitValueLabel.AutoSize = true;
            this.NetProfitValueLabel.Location = new System.Drawing.Point(147, 51);
            this.NetProfitValueLabel.Name = "NetProfitValueLabel";
            this.NetProfitValueLabel.Size = new System.Drawing.Size(0, 25);
            this.NetProfitValueLabel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(131, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 38);
            this.label5.TabIndex = 2;
            this.label5.Text = "Net Profit";
            // 
            // TotalAmountInvestedPanel
            // 
            this.TotalAmountInvestedPanel.Controls.Add(this.TotalInvestmentLabel);
            this.TotalAmountInvestedPanel.Controls.Add(this.NetLossLabel);
            this.TotalAmountInvestedPanel.Location = new System.Drawing.Point(416, 0);
            this.TotalAmountInvestedPanel.Name = "TotalAmountInvestedPanel";
            this.TotalAmountInvestedPanel.Size = new System.Drawing.Size(398, 92);
            this.TotalAmountInvestedPanel.TabIndex = 1;
            // 
            // TotalInvestmentLabel
            // 
            this.TotalInvestmentLabel.AutoSize = true;
            this.TotalInvestmentLabel.Location = new System.Drawing.Point(177, 51);
            this.TotalInvestmentLabel.Name = "TotalInvestmentLabel";
            this.TotalInvestmentLabel.Size = new System.Drawing.Size(0, 25);
            this.TotalInvestmentLabel.TabIndex = 3;
            // 
            // NetLossLabel
            // 
            this.NetLossLabel.AutoSize = true;
            this.NetLossLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NetLossLabel.Location = new System.Drawing.Point(51, 9);
            this.NetLossLabel.Name = "NetLossLabel";
            this.NetLossLabel.Size = new System.Drawing.Size(293, 38);
            this.NetLossLabel.TabIndex = 2;
            this.NetLossLabel.Text = "Total Invested Amount";
            this.NetLossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PortfolioPerformanceGridView
            // 
            this.PortfolioPerformanceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PortfolioPerformanceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PortfolioPerformanceGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PortfolioPerformanceGridView.Location = new System.Drawing.Point(3, 111);
            this.PortfolioPerformanceGridView.Name = "PortfolioPerformanceGridView";
            this.PortfolioPerformanceGridView.RowHeadersWidth = 62;
            this.PortfolioPerformanceGridView.Size = new System.Drawing.Size(1231, 309);
            this.PortfolioPerformanceGridView.TabIndex = 0;
            this.PortfolioPerformanceGridView.Text = "dataGridView1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(51, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 38);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total Invested Amount";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            // 
            // Portfolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1259, 677);
            this.Controls.Add(this.tabControl1);
            this.Name = "Portfolio";
            this.Text = "Portfolio";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TradesGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.NumberOfInvestmentsPanel.ResumeLayout(false);
            this.NumberOfInvestmentsPanel.PerformLayout();
            this.ProfitPanel.ResumeLayout(false);
            this.ProfitPanel.PerformLayout();
            this.TotalAmountInvestedPanel.ResumeLayout(false);
            this.TotalAmountInvestedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortfolioPerformanceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView TradesGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox TradeType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.ComboBox Ticker;
        private System.Windows.Forms.BindingSource TradesBindingSource;
        private System.Windows.Forms.DataGridView PortfolioPerformanceGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel ProfitPanel;
        private System.Windows.Forms.Label NetProfitValueLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel TotalAmountInvestedPanel;
        private System.Windows.Forms.Label TotalInvestmentLabel;
        private System.Windows.Forms.Label NetLossLabel;
        private System.Windows.Forms.Panel NumberOfInvestmentsPanel;
        private System.Windows.Forms.Label NumberOfInvestmentsLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label um;
    }
}


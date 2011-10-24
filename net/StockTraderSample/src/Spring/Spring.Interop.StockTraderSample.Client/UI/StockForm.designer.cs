namespace Spring.Interop.StockTraderSample.Client.UI
{
    partial class StockForm
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
            this.tradeRequestButton = new System.Windows.Forms.Button();
            this.tradeRequestTickerSymbol = new System.Windows.Forms.TextBox();
            this.marketDataListBox = new System.Windows.Forms.ListBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoutingKey = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tradeQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.accountNameTextBox = new System.Windows.Forms.TextBox();
            this.currentPositionsButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.marketDataGroupBox = new System.Windows.Forms.GroupBox();
            this.tradeOperationsGroupBox = new System.Windows.Forms.GroupBox();
            this.buyRadioButton = new System.Windows.Forms.RadioButton();
            this.sellRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tradeQuantityNumericUpDown)).BeginInit();
            this.marketDataGroupBox.SuspendLayout();
            this.tradeOperationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tradeRequestButton
            // 
            this.tradeRequestButton.Location = new System.Drawing.Point(118, 55);
            this.tradeRequestButton.Name = "tradeRequestButton";
            this.tradeRequestButton.Size = new System.Drawing.Size(333, 23);
            this.tradeRequestButton.TabIndex = 0;
            this.tradeRequestButton.Text = "Send Trade Request";
            this.tradeRequestButton.UseVisualStyleBackColor = true;
            this.tradeRequestButton.Click += new System.EventHandler(this.OnSendTradeRequest);
            // 
            // tradeRequestTickerSymbol
            // 
            this.tradeRequestTickerSymbol.Location = new System.Drawing.Point(70, 22);
            this.tradeRequestTickerSymbol.Name = "tradeRequestTickerSymbol";
            this.tradeRequestTickerSymbol.Size = new System.Drawing.Size(262, 20);
            this.tradeRequestTickerSymbol.TabIndex = 1;
            // 
            // marketDataListBox
            // 
            this.marketDataListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.marketDataListBox.FormattingEnabled = true;
            this.marketDataListBox.ItemHeight = 14;
            this.marketDataListBox.Location = new System.Drawing.Point(28, 105);
            this.marketDataListBox.Name = "marketDataListBox";
            this.marketDataListBox.Size = new System.Drawing.Size(415, 200);
            this.marketDataListBox.TabIndex = 4;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(219, 76);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(143, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(28, 76);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(185, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.Location = new System.Drawing.Point(368, 76);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Routing Key :";
            // 
            // txtRoutingKey
            // 
            this.txtRoutingKey.Location = new System.Drawing.Point(91, 32);
            this.txtRoutingKey.Name = "txtRoutingKey";
            this.txtRoutingKey.Size = new System.Drawing.Size(271, 20);
            this.txtRoutingKey.TabIndex = 1;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(368, 32);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "i.e. app.stock.quotes.nasdaq.MSFT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Qty :";
            // 
            // tradeQuantityNumericUpDown
            // 
            this.tradeQuantityNumericUpDown.Location = new System.Drawing.Point(374, 19);
            this.tradeQuantityNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.tradeQuantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tradeQuantityNumericUpDown.Name = "tradeQuantityNumericUpDown";
            this.tradeQuantityNumericUpDown.Size = new System.Drawing.Size(77, 20);
            this.tradeQuantityNumericUpDown.TabIndex = 7;
            this.tradeQuantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Account :";
            // 
            // accountNameTextBox
            // 
            this.accountNameTextBox.Location = new System.Drawing.Point(72, 9);
            this.accountNameTextBox.Name = "accountNameTextBox";
            this.accountNameTextBox.Size = new System.Drawing.Size(403, 20);
            this.accountNameTextBox.TabIndex = 1;
            // 
            // currentPositionsButton
            // 
            this.currentPositionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentPositionsButton.Location = new System.Drawing.Point(15, 483);
            this.currentPositionsButton.Name = "currentPositionsButton";
            this.currentPositionsButton.Size = new System.Drawing.Size(460, 23);
            this.currentPositionsButton.TabIndex = 8;
            this.currentPositionsButton.Text = "Show Current Positions";
            this.currentPositionsButton.UseVisualStyleBackColor = true;
            this.currentPositionsButton.Click += new System.EventHandler(this.currentPositionsButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Symbol :";
            // 
            // marketDataGroupBox
            // 
            this.marketDataGroupBox.Controls.Add(this.txtRoutingKey);
            this.marketDataGroupBox.Controls.Add(this.marketDataListBox);
            this.marketDataGroupBox.Controls.Add(this.label3);
            this.marketDataGroupBox.Controls.Add(this.label2);
            this.marketDataGroupBox.Controls.Add(this.btnApply);
            this.marketDataGroupBox.Controls.Add(this.btnStop);
            this.marketDataGroupBox.Controls.Add(this.btnClear);
            this.marketDataGroupBox.Controls.Add(this.btnStart);
            this.marketDataGroupBox.Location = new System.Drawing.Point(12, 141);
            this.marketDataGroupBox.Name = "marketDataGroupBox";
            this.marketDataGroupBox.Size = new System.Drawing.Size(463, 331);
            this.marketDataGroupBox.TabIndex = 10;
            this.marketDataGroupBox.TabStop = false;
            this.marketDataGroupBox.Text = "Market Data";
            // 
            // tradeOperationsGroupBox
            // 
            this.tradeOperationsGroupBox.Controls.Add(this.sellRadioButton);
            this.tradeOperationsGroupBox.Controls.Add(this.buyRadioButton);
            this.tradeOperationsGroupBox.Controls.Add(this.label6);
            this.tradeOperationsGroupBox.Controls.Add(this.tradeRequestButton);
            this.tradeOperationsGroupBox.Controls.Add(this.tradeRequestTickerSymbol);
            this.tradeOperationsGroupBox.Controls.Add(this.label4);
            this.tradeOperationsGroupBox.Controls.Add(this.tradeQuantityNumericUpDown);
            this.tradeOperationsGroupBox.Location = new System.Drawing.Point(12, 35);
            this.tradeOperationsGroupBox.Name = "tradeOperationsGroupBox";
            this.tradeOperationsGroupBox.Size = new System.Drawing.Size(463, 100);
            this.tradeOperationsGroupBox.TabIndex = 11;
            this.tradeOperationsGroupBox.TabStop = false;
            this.tradeOperationsGroupBox.Text = "Trade Operations";
            // 
            // buyRadioButton
            // 
            this.buyRadioButton.AutoSize = true;
            this.buyRadioButton.Checked = true;
            this.buyRadioButton.Location = new System.Drawing.Point(19, 58);
            this.buyRadioButton.Name = "buyRadioButton";
            this.buyRadioButton.Size = new System.Drawing.Size(43, 17);
            this.buyRadioButton.TabIndex = 10;
            this.buyRadioButton.TabStop = true;
            this.buyRadioButton.Text = "Buy";
            this.buyRadioButton.UseVisualStyleBackColor = true;
            // 
            // sellRadioButton
            // 
            this.sellRadioButton.AutoSize = true;
            this.sellRadioButton.Location = new System.Drawing.Point(70, 58);
            this.sellRadioButton.Name = "sellRadioButton";
            this.sellRadioButton.Size = new System.Drawing.Size(42, 17);
            this.sellRadioButton.TabIndex = 10;
            this.sellRadioButton.Text = "Sell";
            this.sellRadioButton.UseVisualStyleBackColor = true;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 518);
            this.Controls.Add(this.tradeOperationsGroupBox);
            this.Controls.Add(this.marketDataGroupBox);
            this.Controls.Add(this.currentPositionsButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.accountNameTextBox);
            this.Name = "StockForm";
            this.Text = "TradeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StockForm_FormClosing);
            this.Load += new System.EventHandler(this.StockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tradeQuantityNumericUpDown)).EndInit();
            this.marketDataGroupBox.ResumeLayout(false);
            this.marketDataGroupBox.PerformLayout();
            this.tradeOperationsGroupBox.ResumeLayout(false);
            this.tradeOperationsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tradeRequestButton;
        private System.Windows.Forms.TextBox tradeRequestTickerSymbol;
        private System.Windows.Forms.ListBox marketDataListBox;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRoutingKey;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown tradeQuantityNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox accountNameTextBox;
        private System.Windows.Forms.Button currentPositionsButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox marketDataGroupBox;
        private System.Windows.Forms.GroupBox tradeOperationsGroupBox;
        private System.Windows.Forms.RadioButton sellRadioButton;
        private System.Windows.Forms.RadioButton buyRadioButton;
    }
}
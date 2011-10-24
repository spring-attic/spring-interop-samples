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
            this.tradeRequestStatusTextBox = new System.Windows.Forms.TextBox();
            this.marketDataListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.tradeQuantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tradeRequestButton
            // 
            this.tradeRequestButton.Location = new System.Drawing.Point(155, 62);
            this.tradeRequestButton.Name = "tradeRequestButton";
            this.tradeRequestButton.Size = new System.Drawing.Size(135, 23);
            this.tradeRequestButton.TabIndex = 0;
            this.tradeRequestButton.Text = "Send Trade Request";
            this.tradeRequestButton.UseVisualStyleBackColor = true;
            this.tradeRequestButton.Click += new System.EventHandler(this.OnSendTradeRequest);
            // 
            // tradeRequestStatusTextBox
            // 
            this.tradeRequestStatusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tradeRequestStatusTextBox.Location = new System.Drawing.Point(72, 39);
            this.tradeRequestStatusTextBox.Name = "tradeRequestStatusTextBox";
            this.tradeRequestStatusTextBox.Size = new System.Drawing.Size(413, 20);
            this.tradeRequestStatusTextBox.TabIndex = 1;
            // 
            // marketDataListBox
            // 
            this.marketDataListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marketDataListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.marketDataListBox.FormattingEnabled = true;
            this.marketDataListBox.ItemHeight = 14;
            this.marketDataListBox.Location = new System.Drawing.Point(90, 160);
            this.marketDataListBox.Name = "marketDataListBox";
            this.marketDataListBox.Size = new System.Drawing.Size(390, 228);
            this.marketDataListBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Market Data :";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(90, 135);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(171, 135);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(403, 135);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Routing Key :";
            // 
            // txtRoutingKey
            // 
            this.txtRoutingKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRoutingKey.Location = new System.Drawing.Point(90, 91);
            this.txtRoutingKey.Name = "txtRoutingKey";
            this.txtRoutingKey.Size = new System.Drawing.Size(276, 20);
            this.txtRoutingKey.TabIndex = 1;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(372, 91);
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
            this.label3.Location = new System.Drawing.Point(93, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "i.e. app.stock.quotes.nasdaq.MSFT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Qty :";
            // 
            // tradeQuantityNumericUpDown
            // 
            this.tradeQuantityNumericUpDown.Location = new System.Drawing.Point(72, 65);
            this.tradeQuantityNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.tradeQuantityNumericUpDown.Name = "tradeQuantityNumericUpDown";
            this.tradeQuantityNumericUpDown.Size = new System.Drawing.Size(77, 20);
            this.tradeQuantityNumericUpDown.TabIndex = 7;
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
            this.accountNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountNameTextBox.Location = new System.Drawing.Point(72, 9);
            this.accountNameTextBox.Name = "accountNameTextBox";
            this.accountNameTextBox.Size = new System.Drawing.Size(212, 20);
            this.accountNameTextBox.TabIndex = 1;
            // 
            // currentPositionsButton
            // 
            this.currentPositionsButton.Location = new System.Drawing.Point(90, 394);
            this.currentPositionsButton.Name = "currentPositionsButton";
            this.currentPositionsButton.Size = new System.Drawing.Size(340, 23);
            this.currentPositionsButton.TabIndex = 8;
            this.currentPositionsButton.Text = "Show Current Positions";
            this.currentPositionsButton.UseVisualStyleBackColor = true;
            this.currentPositionsButton.Click += new System.EventHandler(this.currentPositionsButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Symbol :";
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 422);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.currentPositionsButton);
            this.Controls.Add(this.tradeQuantityNumericUpDown);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.marketDataListBox);
            this.Controls.Add(this.txtRoutingKey);
            this.Controls.Add(this.accountNameTextBox);
            this.Controls.Add(this.tradeRequestStatusTextBox);
            this.Controls.Add(this.tradeRequestButton);
            this.Name = "StockForm";
            this.Text = "TradeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StockForm_FormClosing);
            this.Load += new System.EventHandler(this.StockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tradeQuantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tradeRequestButton;
        private System.Windows.Forms.TextBox tradeRequestStatusTextBox;
        private System.Windows.Forms.ListBox marketDataListBox;
        private System.Windows.Forms.Label label1;
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
    }
}
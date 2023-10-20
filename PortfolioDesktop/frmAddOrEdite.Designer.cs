namespace PortfolioDesktop
{
    partial class frmAddOrEdite
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
            groupBox1 = new GroupBox();
            btnHandelCoin = new Button();
            txtNotes = new TextBox();
            label7 = new Label();
            txtCoinValue = new NumericUpDown();
            txtDollarValue = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            txtEntryPrice = new NumericUpDown();
            label4 = new Label();
            txtCurrency = new ComboBox();
            label3 = new Label();
            txtTypePosition = new ComboBox();
            label2 = new Label();
            txtEntryDate = new DateTimePicker();
            label1 = new Label();
            btnSabmit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCoinValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDollarValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEntryPrice).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHandelCoin);
            groupBox1.Controls.Add(txtNotes);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtCoinValue);
            groupBox1.Controls.Add(txtDollarValue);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEntryPrice);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCurrency);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTypePosition);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEntryDate);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 17);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(487, 481);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "add trade";
            // 
            // btnHandelCoin
            // 
            btnHandelCoin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnHandelCoin.Location = new Point(365, 271);
            btnHandelCoin.Name = "btnHandelCoin";
            btnHandelCoin.Size = new Size(106, 34);
            btnHandelCoin.TabIndex = 15;
            btnHandelCoin.Text = "محاسبه کوین";
            btnHandelCoin.UseVisualStyleBackColor = true;
            btnHandelCoin.Click += btnHandelCoin_Click;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(137, 323);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(334, 151);
            txtNotes.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 323);
            label7.Name = "label7";
            label7.Size = new Size(68, 28);
            label7.TabIndex = 13;
            label7.Text = "Notes:";
            // 
            // txtCoinValue
            // 
            txtCoinValue.DecimalPlaces = 6;
            txtCoinValue.Location = new Point(137, 271);
            txtCoinValue.Margin = new Padding(4);
            txtCoinValue.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            txtCoinValue.Name = "txtCoinValue";
            txtCoinValue.Size = new Size(221, 34);
            txtCoinValue.TabIndex = 12;
            // 
            // txtDollarValue
            // 
            txtDollarValue.DecimalPlaces = 2;
            txtDollarValue.Location = new Point(137, 214);
            txtDollarValue.Margin = new Padding(4);
            txtDollarValue.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            txtDollarValue.Name = "txtDollarValue";
            txtDollarValue.Size = new Size(334, 34);
            txtDollarValue.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 271);
            label6.Name = "label6";
            label6.Size = new Size(103, 28);
            label6.TabIndex = 10;
            label6.Text = "CoinValue:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 214);
            label5.Name = "label5";
            label5.Size = new Size(116, 28);
            label5.TabIndex = 9;
            label5.Text = "DollarValue:\t";
            // 
            // txtEntryPrice
            // 
            txtEntryPrice.DecimalPlaces = 6;
            txtEntryPrice.Location = new Point(137, 159);
            txtEntryPrice.Margin = new Padding(4);
            txtEntryPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            txtEntryPrice.Name = "txtEntryPrice";
            txtEntryPrice.Size = new Size(334, 34);
            txtEntryPrice.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 161);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 28);
            label4.TabIndex = 6;
            label4.Text = "EntryPrice:";
            // 
            // txtCurrency
            // 
            txtCurrency.FormattingEnabled = true;
            txtCurrency.Items.AddRange(new object[] { "BTC", "ETH" });
            txtCurrency.Location = new Point(366, 102);
            txtCurrency.Margin = new Padding(4);
            txtCurrency.Name = "txtCurrency";
            txtCurrency.Size = new Size(105, 36);
            txtCurrency.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(265, 105);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 4;
            label3.Text = "Currency:";
            // 
            // txtTypePosition
            // 
            txtTypePosition.FormattingEnabled = true;
            txtTypePosition.Items.AddRange(new object[] { "Long", "Short" });
            txtTypePosition.Location = new Point(137, 102);
            txtTypePosition.Margin = new Padding(4);
            txtTypePosition.Name = "txtTypePosition";
            txtTypePosition.Size = new Size(120, 36);
            txtTypePosition.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 105);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 2;
            label2.Text = "TypePosition:";
            // 
            // txtEntryDate
            // 
            txtEntryDate.Location = new Point(137, 47);
            txtEntryDate.Margin = new Padding(4);
            txtEntryDate.Name = "txtEntryDate";
            txtEntryDate.Size = new Size(334, 34);
            txtEntryDate.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 0;
            label1.Text = "EntryDate:";
            // 
            // btnSabmit
            // 
            btnSabmit.Location = new Point(153, 505);
            btnSabmit.Name = "btnSabmit";
            btnSabmit.Size = new Size(94, 36);
            btnSabmit.TabIndex = 1;
            btnSabmit.Text = "Submite";
            btnSabmit.UseVisualStyleBackColor = true;
            btnSabmit.Click += btnSabmit_Click;
            // 
            // frmAddOrEdite
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 567);
            Controls.Add(btnSabmit);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmAddOrEdite";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmAddOrEdite_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCoinValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDollarValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEntryPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNotes;
        private Label label7;
        private NumericUpDown txtCoinValue;
        private NumericUpDown txtDollarValue;
        private Label label6;
        private Label label5;
        private NumericUpDown txtEntryPrice;
        private Label label4;
        private ComboBox txtCurrency;
        private Label label3;
        private ComboBox txtTypePosition;
        private Label label2;
        private DateTimePicker txtEntryDate;
        private Label label1;
        private Button btnSabmit;
        private Button btnHandelCoin;
    }
}
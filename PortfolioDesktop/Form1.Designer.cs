namespace PortfolioDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            btnNewTrade = new ToolStripButton();
            btnRefresh = new ToolStripButton();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            btnEdit = new Button();
            dgPortfolio = new DataGridView();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            lDollarValue = new Label();
            lCoinValue = new Label();
            lLastPrice = new Label();
            lAssetValue = new Label();
            lBalanceSheet = new Label();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPortfolio).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNewTrade, btnRefresh });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1258, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNewTrade
            // 
            btnNewTrade.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnNewTrade.Image = (Image)resources.GetObject("btnNewTrade.Image");
            btnNewTrade.ImageTransparentColor = Color.Magenta;
            btnNewTrade.Name = "btnNewTrade";
            btnNewTrade.Size = new Size(41, 24);
            btnNewTrade.Text = "Add";
            btnNewTrade.Click += btnNewTrade_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageTransparentColor = Color.Magenta;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(62, 24);
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(dgPortfolio);
            groupBox1.Location = new Point(12, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1238, 452);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Portfolio Trade";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1038, 417);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1138, 417);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // dgPortfolio
            // 
            dgPortfolio.AllowUserToAddRows = false;
            dgPortfolio.AllowUserToDeleteRows = false;
            dgPortfolio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPortfolio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPortfolio.Location = new Point(0, 27);
            dgPortfolio.Name = "dgPortfolio";
            dgPortfolio.ReadOnly = true;
            dgPortfolio.RowHeadersWidth = 51;
            dgPortfolio.RowTemplate.Height = 29;
            dgPortfolio.Size = new Size(1238, 380);
            dgPortfolio.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lBalanceSheet);
            groupBox2.Controls.Add(lAssetValue);
            groupBox2.Controls.Add(lLastPrice);
            groupBox2.Controls.Add(lCoinValue);
            groupBox2.Controls.Add(lDollarValue);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(12, 495);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1238, 166);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "balanceSheet";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BTC", "ETH" });
            comboBox1.Location = new Point(6, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 29);
            comboBox1.TabIndex = 0;
            // 
            // lDollarValue
            // 
            lDollarValue.AutoSize = true;
            lDollarValue.Location = new Point(6, 82);
            lDollarValue.Name = "lDollarValue";
            lDollarValue.Size = new Size(16, 21);
            lDollarValue.TabIndex = 1;
            lDollarValue.Text = "-";
            // 
            // lCoinValue
            // 
            lCoinValue.AutoSize = true;
            lCoinValue.Location = new Point(189, 82);
            lCoinValue.Name = "lCoinValue";
            lCoinValue.Size = new Size(16, 21);
            lCoinValue.TabIndex = 2;
            lCoinValue.Text = "-";
            // 
            // lLastPrice
            // 
            lLastPrice.AutoSize = true;
            lLastPrice.Location = new Point(422, 82);
            lLastPrice.Name = "lLastPrice";
            lLastPrice.Size = new Size(16, 21);
            lLastPrice.TabIndex = 3;
            lLastPrice.Text = "-";
            // 
            // lAssetValue
            // 
            lAssetValue.AutoSize = true;
            lAssetValue.Location = new Point(675, 82);
            lAssetValue.Name = "lAssetValue";
            lAssetValue.Size = new Size(16, 21);
            lAssetValue.TabIndex = 4;
            lAssetValue.Text = "-";
            // 
            // lBalanceSheet
            // 
            lBalanceSheet.AutoSize = true;
            lBalanceSheet.Location = new Point(1038, 82);
            lBalanceSheet.Name = "lBalanceSheet";
            lBalanceSheet.Size = new Size(16, 21);
            lBalanceSheet.TabIndex = 5;
            lBalanceSheet.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 673);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Portfolio";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPortfolio).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private GroupBox groupBox1;
        private DataGridView dgPortfolio;
        private ToolStripButton btnNewTrade;
        private ToolStripButton btnRefresh;
        private Button btnDelete;
        private Button btnEdit;
        private GroupBox groupBox2;
        private Label lBalanceSheet;
        private Label lAssetValue;
        private Label lLastPrice;
        private Label lCoinValue;
        private Label lDollarValue;
        private ComboBox comboBox1;
    }
}
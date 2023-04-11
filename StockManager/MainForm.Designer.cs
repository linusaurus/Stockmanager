namespace StockManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            txtLastScannedResult = new TextBox();
            dvgStockList = new DataGridView();
            txtCodeType = new TextBox();
            statusStrip1 = new StatusStrip();
            tsMainToolBar = new ToolStrip();
            tsbNewStockList = new ToolStripButton();
            tsbCloseList = new ToolStripButton();
            tabControlApp = new TabControl();
            tbStockList = new TabPage();
            tbPartManager = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dvgStockList).BeginInit();
            tsMainToolBar.SuspendLayout();
            tabControlApp.SuspendLayout();
            tbStockList.SuspendLayout();
            SuspendLayout();
            // 
            // txtLastScannedResult
            // 
            txtLastScannedResult.Location = new Point(11, 83);
            txtLastScannedResult.Name = "txtLastScannedResult";
            txtLastScannedResult.Size = new Size(107, 23);
            txtLastScannedResult.TabIndex = 1;
            // 
            // dvgStockList
            // 
            dvgStockList.AllowUserToAddRows = false;
            dvgStockList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgStockList.Dock = DockStyle.Fill;
            dvgStockList.Location = new Point(6, 6);
            dvgStockList.Name = "dvgStockList";
            dvgStockList.RowTemplate.Height = 25;
            dvgStockList.Size = new Size(925, 380);
            dvgStockList.TabIndex = 2;
            // 
            // txtCodeType
            // 
            txtCodeType.Location = new Point(124, 83);
            txtCodeType.Name = "txtCodeType";
            txtCodeType.Size = new Size(170, 23);
            txtCodeType.TabIndex = 3;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(6, 533);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(945, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsMainToolBar
            // 
            tsMainToolBar.Items.AddRange(new ToolStripItem[] { tsbNewStockList, tsbCloseList });
            tsMainToolBar.Location = new Point(6, 6);
            tsMainToolBar.Name = "tsMainToolBar";
            tsMainToolBar.Size = new Size(945, 70);
            tsMainToolBar.TabIndex = 6;
            tsMainToolBar.Text = "toolStrip1";
            tsMainToolBar.ItemClicked += tsMainToolBar_ItemClicked;
            // 
            // tsbNewStockList
            // 
            tsbNewStockList.Image = (Image)resources.GetObject("tsbNewStockList.Image");
            tsbNewStockList.ImageScaling = ToolStripItemImageScaling.None;
            tsbNewStockList.ImageTransparentColor = Color.Magenta;
            tsbNewStockList.Name = "tsbNewStockList";
            tsbNewStockList.Size = new Size(88, 67);
            tsbNewStockList.Text = "New Stock List";
            tsbNewStockList.TextImageRelation = TextImageRelation.TextAboveImage;
            tsbNewStockList.ToolTipText = "Create a new List";
            // 
            // tsbCloseList
            // 
            tsbCloseList.Image = (Image)resources.GetObject("tsbCloseList.Image");
            tsbCloseList.ImageScaling = ToolStripItemImageScaling.None;
            tsbCloseList.ImageTransparentColor = Color.Magenta;
            tsbCloseList.Name = "tsbCloseList";
            tsbCloseList.Size = new Size(61, 67);
            tsbCloseList.Text = "Close List";
            tsbCloseList.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // tabControlApp
            // 
            tabControlApp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlApp.Controls.Add(tbStockList);
            tabControlApp.Controls.Add(tbPartManager);
            tabControlApp.Location = new Point(6, 113);
            tabControlApp.Name = "tabControlApp";
            tabControlApp.SelectedIndex = 0;
            tabControlApp.Size = new Size(945, 420);
            tabControlApp.TabIndex = 7;
            tabControlApp.SelectedIndexChanged += tabControlApp_SelectedIndexChanged;
            // 
            // tbStockList
            // 
            tbStockList.Controls.Add(dvgStockList);
            tbStockList.Location = new Point(4, 24);
            tbStockList.Name = "tbStockList";
            tbStockList.Padding = new Padding(6);
            tbStockList.Size = new Size(937, 392);
            tbStockList.TabIndex = 0;
            tbStockList.Text = "Stock Items";
            tbStockList.UseVisualStyleBackColor = true;
            // 
            // tbPartManager
            // 
            tbPartManager.Location = new Point(4, 24);
            tbPartManager.Name = "tbPartManager";
            tbPartManager.Padding = new Padding(4);
            tbPartManager.Size = new Size(937, 392);
            tbPartManager.TabIndex = 1;
            tbPartManager.Text = "Part Manager";
            tbPartManager.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 561);
            Controls.Add(tabControlApp);
            Controls.Add(tsMainToolBar);
            Controls.Add(statusStrip1);
            Controls.Add(txtCodeType);
            Controls.Add(txtLastScannedResult);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(973, 600);
            Name = "MainForm";
            Padding = new Padding(6);
            Text = "Stock Manager";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dvgStockList).EndInit();
            tsMainToolBar.ResumeLayout(false);
            tsMainToolBar.PerformLayout();
            tabControlApp.ResumeLayout(false);
            tbStockList.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtLastScannedResult;
        private DataGridView dvgStockList;
        private TextBox txtCodeType;
        private StatusStrip statusStrip1;
        private ToolStrip tsMainToolBar;
        private TabControl tabControlApp;
        private TabPage tbStockList;
        private TabPage tbPartManager;
        private ToolStripButton tsbNewStockList;
        private ToolStripButton tsbCloseList;
    }
}
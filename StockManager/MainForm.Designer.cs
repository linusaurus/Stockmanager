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
            tsbProccessList = new ToolStripButton();
            tscboJobs = new ToolStripComboBox();
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
            txtLastScannedResult.Location = new Point(11, 49);
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
            dvgStockList.Size = new Size(925, 415);
            dvgStockList.TabIndex = 2;
            dvgStockList.Visible = false;
            // 
            // txtCodeType
            // 
            txtCodeType.Location = new Point(124, 49);
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
            tsMainToolBar.Items.AddRange(new ToolStripItem[] { tsbNewStockList, tsbProccessList, tscboJobs });
            tsMainToolBar.Location = new Point(6, 6);
            tsMainToolBar.Name = "tsMainToolBar";
            tsMainToolBar.Size = new Size(945, 30);
            tsMainToolBar.TabIndex = 6;
            tsMainToolBar.Text = "toolStrip1";
            tsMainToolBar.ItemClicked += tsMainToolBar_ItemClicked;
            // 
            // tsbNewStockList
            // 
            tsbNewStockList.BackColor = SystemColors.ActiveCaptionText;
            tsbNewStockList.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbNewStockList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tsbNewStockList.ForeColor = SystemColors.ButtonHighlight;
            tsbNewStockList.Image = (Image)resources.GetObject("tsbNewStockList.Image");
            tsbNewStockList.ImageTransparentColor = Color.Magenta;
            tsbNewStockList.Name = "tsbNewStockList";
            tsbNewStockList.Padding = new Padding(4);
            tsbNewStockList.Size = new Size(102, 27);
            tsbNewStockList.Text = "New Stock List";
            tsbNewStockList.TextImageRelation = TextImageRelation.TextAboveImage;
            tsbNewStockList.ToolTipText = "Create a new List";
            // 
            // tsbProccessList
            // 
            tsbProccessList.AutoSize = false;
            tsbProccessList.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbProccessList.Image = (Image)resources.GetObject("tsbProccessList.Image");
            tsbProccessList.ImageScaling = ToolStripItemImageScaling.None;
            tsbProccessList.ImageTransparentColor = Color.Magenta;
            tsbProccessList.Margin = new Padding(4, 1, 0, 2);
            tsbProccessList.Name = "tsbProccessList";
            tsbProccessList.Size = new Size(88, 27);
            tsbProccessList.Text = "Process";
            tsbProccessList.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // tscboJobs
            // 
            tscboJobs.Alignment = ToolStripItemAlignment.Right;
            tscboJobs.Name = "tscboJobs";
            tscboJobs.Size = new Size(260, 30);
            tscboJobs.SelectedIndexChanged += tscboJobs_SelectedIndexChanged;
            // 
            // tabControlApp
            // 
            tabControlApp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlApp.Controls.Add(tbStockList);
            tabControlApp.Controls.Add(tbPartManager);
            tabControlApp.Location = new Point(6, 78);
            tabControlApp.Name = "tabControlApp";
            tabControlApp.SelectedIndex = 0;
            tabControlApp.Size = new Size(945, 455);
            tabControlApp.TabIndex = 7;
            tabControlApp.SelectedIndexChanged += tabControlApp_SelectedIndexChanged;
            // 
            // tbStockList
            // 
            tbStockList.Controls.Add(dvgStockList);
            tbStockList.Location = new Point(4, 24);
            tbStockList.Name = "tbStockList";
            tbStockList.Padding = new Padding(6);
            tbStockList.Size = new Size(937, 427);
            tbStockList.TabIndex = 0;
            tbStockList.Text = "Stock Items";
            tbStockList.UseVisualStyleBackColor = true;
            // 
            // tbPartManager
            // 
            tbPartManager.Location = new Point(4, 24);
            tbPartManager.Name = "tbPartManager";
            tbPartManager.Padding = new Padding(4);
            tbPartManager.Size = new Size(937, 427);
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
        private ToolStripButton tsbProccessList;
        private ToolStripComboBox tscboJobs;
    }
}
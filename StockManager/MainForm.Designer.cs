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
            txtJobnameSearch = new TextBox();
            txtLastScannedResult = new TextBox();
            dvgStockList = new DataGridView();
            txtCodeType = new TextBox();
            listBox1 = new ListBox();
            statusStrip1 = new StatusStrip();
            tsMainToolBar = new ToolStrip();
            tabControlApp = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dvgStockList).BeginInit();
            tabControlApp.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // txtJobnameSearch
            // 
            txtJobnameSearch.Location = new Point(479, 57);
            txtJobnameSearch.Name = "txtJobnameSearch";
            txtJobnameSearch.Size = new Size(269, 23);
            txtJobnameSearch.TabIndex = 0;
            // 
            // txtLastScannedResult
            // 
            txtLastScannedResult.Location = new Point(32, 57);
            txtLastScannedResult.Name = "txtLastScannedResult";
            txtLastScannedResult.Size = new Size(84, 23);
            txtLastScannedResult.TabIndex = 1;
            // 
            // dvgStockList
            // 
            dvgStockList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgStockList.Dock = DockStyle.Fill;
            dvgStockList.Location = new Point(6, 6);
            dvgStockList.Name = "dvgStockList";
            dvgStockList.RowTemplate.Height = 25;
            dvgStockList.Size = new Size(678, 328);
            dvgStockList.TabIndex = 2;
            // 
            // txtCodeType
            // 
            txtCodeType.Location = new Point(134, 57);
            txtCodeType.Name = "txtCodeType";
            txtCodeType.Size = new Size(234, 23);
            txtCodeType.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(32, 86);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(84, 49);
            listBox1.TabIndex = 4;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 548);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(875, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsMainToolBar
            // 
            tsMainToolBar.Location = new Point(0, 0);
            tsMainToolBar.Name = "tsMainToolBar";
            tsMainToolBar.Size = new Size(875, 25);
            tsMainToolBar.TabIndex = 6;
            tsMainToolBar.Text = "toolStrip1";
            tsMainToolBar.ItemClicked += tsMainToolBar_ItemClicked;
            // 
            // tabControlApp
            // 
            tabControlApp.Controls.Add(tabPage1);
            tabControlApp.Controls.Add(tabPage2);
            tabControlApp.Location = new Point(165, 177);
            tabControlApp.Name = "tabControlApp";
            tabControlApp.SelectedIndex = 0;
            tabControlApp.Size = new Size(698, 368);
            tabControlApp.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dvgStockList);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(6);
            tabPage1.Size = new Size(690, 340);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(690, 340);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 570);
            Controls.Add(tabControlApp);
            Controls.Add(tsMainToolBar);
            Controls.Add(statusStrip1);
            Controls.Add(listBox1);
            Controls.Add(txtCodeType);
            Controls.Add(txtLastScannedResult);
            Controls.Add(txtJobnameSearch);
            Name = "MainForm";
            Text = "Stock Manager";
            ((System.ComponentModel.ISupportInitialize)dvgStockList).EndInit();
            tabControlApp.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtJobnameSearch;
        private TextBox txtLastScannedResult;
        private DataGridView dvgStockList;
        private TextBox txtCodeType;
        private ListBox listBox1;
        private StatusStrip statusStrip1;
        private ToolStrip tsMainToolBar;
        private TabControl tabControlApp;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}
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
            dataGridView1 = new DataGridView();
            txtCodeType = new TextBox();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtJobnameSearch
            // 
            txtJobnameSearch.Location = new Point(546, 25);
            txtJobnameSearch.Name = "txtJobnameSearch";
            txtJobnameSearch.Size = new Size(269, 23);
            txtJobnameSearch.TabIndex = 0;
            // 
            // txtLastScannedResult
            // 
            txtLastScannedResult.Location = new Point(32, 25);
            txtLastScannedResult.Name = "txtLastScannedResult";
            txtLastScannedResult.Size = new Size(201, 23);
            txtLastScannedResult.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 357);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(793, 177);
            dataGridView1.TabIndex = 2;
            // 
            // txtCodeType
            // 
            txtCodeType.Location = new Point(239, 25);
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
            listBox1.Size = new Size(459, 244);
            listBox1.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 570);
            Controls.Add(listBox1);
            Controls.Add(txtCodeType);
            Controls.Add(dataGridView1);
            Controls.Add(txtLastScannedResult);
            Controls.Add(txtJobnameSearch);
            Name = "MainForm";
            Text = "Stock Manager";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtJobnameSearch;
        private TextBox txtLastScannedResult;
        private DataGridView dataGridView1;
        private TextBox txtCodeType;
        private ListBox listBox1;
    }
}
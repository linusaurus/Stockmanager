namespace StockManager.UXControls
{
    partial class PartManagerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            spcPartManager = new SplitContainer();
            btnPrintLabels = new Button();
            txtSearch3 = new TextBox();
            txtSearch2 = new TextBox();
            txtSearch1 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)spcPartManager).BeginInit();
            spcPartManager.Panel1.SuspendLayout();
            spcPartManager.Panel2.SuspendLayout();
            spcPartManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // spcPartManager
            // 
            spcPartManager.Dock = DockStyle.Fill;
            spcPartManager.Location = new Point(0, 0);
            spcPartManager.Name = "spcPartManager";
            spcPartManager.Orientation = Orientation.Horizontal;
            // 
            // spcPartManager.Panel1
            // 
            spcPartManager.Panel1.Controls.Add(btnPrintLabels);
            spcPartManager.Panel1.Controls.Add(txtSearch3);
            spcPartManager.Panel1.Controls.Add(txtSearch2);
            spcPartManager.Panel1.Controls.Add(txtSearch1);
            spcPartManager.Panel1.Padding = new Padding(6);
            // 
            // spcPartManager.Panel2
            // 
            spcPartManager.Panel2.Controls.Add(dataGridView1);
            spcPartManager.Panel2.Padding = new Padding(6);
            spcPartManager.Size = new Size(972, 565);
            spcPartManager.SplitterDistance = 120;
            spcPartManager.TabIndex = 0;
            // 
            // btnPrintLabels
            // 
            btnPrintLabels.Location = new Point(443, 20);
            btnPrintLabels.Name = "btnPrintLabels";
            btnPrintLabels.Size = new Size(136, 23);
            btnPrintLabels.TabIndex = 4;
            btnPrintLabels.Text = "Print Label(s)";
            btnPrintLabels.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrintLabels.UseVisualStyleBackColor = true;
            btnPrintLabels.Click += btnPrintLabels_Click;
            // 
            // txtSearch3
            // 
            txtSearch3.Location = new Point(233, 20);
            txtSearch3.Name = "txtSearch3";
            txtSearch3.Size = new Size(100, 23);
            txtSearch3.TabIndex = 3;
            // 
            // txtSearch2
            // 
            txtSearch2.Location = new Point(123, 20);
            txtSearch2.Name = "txtSearch2";
            txtSearch2.Size = new Size(100, 23);
            txtSearch2.TabIndex = 1;
            // 
            // txtSearch1
            // 
            txtSearch1.Location = new Point(13, 20);
            txtSearch1.Name = "txtSearch1";
            txtSearch1.Size = new Size(100, 23);
            txtSearch1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(960, 429);
            dataGridView1.TabIndex = 4;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged_1;
            // 
            // PartManagerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(spcPartManager);
            Name = "PartManagerControl";
            Size = new Size(972, 565);
            spcPartManager.Panel1.ResumeLayout(false);
            spcPartManager.Panel1.PerformLayout();
            spcPartManager.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcPartManager).EndInit();
            spcPartManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer spcPartManager;
        private DataGridView dataGridView1;
        private TextBox txtSearch3;
        private TextBox txtSearch2;
        private TextBox txtSearch1;
        private Button btnPrintLabels;
    }
}

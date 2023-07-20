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
            txtPartID = new TextBox();
            txtSelectedPart = new TextBox();
            bntAssociateSKU = new Button();
            btnPrintLabels = new Button();
            txtSearch3 = new TextBox();
            txtSearch2 = new TextBox();
            txtSearch1 = new TextBox();
            dgvPartsListing = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)spcPartManager).BeginInit();
            spcPartManager.Panel1.SuspendLayout();
            spcPartManager.Panel2.SuspendLayout();
            spcPartManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPartsListing).BeginInit();
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
            spcPartManager.Panel1.Controls.Add(txtPartID);
            spcPartManager.Panel1.Controls.Add(txtSelectedPart);
            spcPartManager.Panel1.Controls.Add(bntAssociateSKU);
            spcPartManager.Panel1.Controls.Add(btnPrintLabels);
            spcPartManager.Panel1.Controls.Add(txtSearch3);
            spcPartManager.Panel1.Controls.Add(txtSearch2);
            spcPartManager.Panel1.Controls.Add(txtSearch1);
            spcPartManager.Panel1.Padding = new Padding(6);
            // 
            // spcPartManager.Panel2
            // 
            spcPartManager.Panel2.Controls.Add(dgvPartsListing);
            spcPartManager.Panel2.Padding = new Padding(6);
            spcPartManager.Size = new Size(975, 565);
            spcPartManager.SplitterDistance = 116;
            spcPartManager.TabIndex = 0;
            // 
            // txtPartID
            // 
            txtPartID.BackColor = SystemColors.Info;
            txtPartID.Location = new Point(368, 20);
            txtPartID.Name = "txtPartID";
            txtPartID.Size = new Size(85, 23);
            txtPartID.TabIndex = 6;
            // 
            // txtSelectedPart
            // 
            txtSelectedPart.Location = new Point(13, 51);
            txtSelectedPart.Multiline = true;
            txtSelectedPart.Name = "txtSelectedPart";
            txtSelectedPart.Size = new Size(440, 56);
            txtSelectedPart.TabIndex = 5;
            // 
            // bntAssociateSKU
            // 
            bntAssociateSKU.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntAssociateSKU.Location = new Point(830, 20);
            bntAssociateSKU.Name = "bntAssociateSKU";
            bntAssociateSKU.Size = new Size(136, 30);
            bntAssociateSKU.TabIndex = 4;
            bntAssociateSKU.Text = "Associate SKU";
            bntAssociateSKU.TextImageRelation = TextImageRelation.ImageBeforeText;
            bntAssociateSKU.UseVisualStyleBackColor = true;
            bntAssociateSKU.Click += bntAssociateSKU_Click;
            // 
            // btnPrintLabels
            // 
            btnPrintLabels.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrintLabels.Location = new Point(679, 20);
            btnPrintLabels.Name = "btnPrintLabels";
            btnPrintLabels.Size = new Size(136, 30);
            btnPrintLabels.TabIndex = 4;
            btnPrintLabels.Text = "Print Label(s)";
            btnPrintLabels.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrintLabels.UseVisualStyleBackColor = true;
            btnPrintLabels.Click += btnPrintLabels_Click;
            // 
            // txtSearch3
            // 
            txtSearch3.Location = new Point(226, 20);
            txtSearch3.Name = "txtSearch3";
            txtSearch3.Size = new Size(100, 23);
            txtSearch3.TabIndex = 3;
            // 
            // txtSearch2
            // 
            txtSearch2.Location = new Point(120, 20);
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
            txtSearch1.TextChanged += txtSearch1_TextChanged;
            // 
            // dgvPartsListing
            // 
            dgvPartsListing.AllowUserToAddRows = false;
            dgvPartsListing.AllowUserToDeleteRows = false;
            dgvPartsListing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartsListing.Dock = DockStyle.Fill;
            dgvPartsListing.Location = new Point(6, 6);
            dgvPartsListing.Name = "dgvPartsListing";
            dgvPartsListing.ReadOnly = true;
            dgvPartsListing.RowTemplate.Height = 25;
            dgvPartsListing.Size = new Size(963, 433);
            dgvPartsListing.TabIndex = 4;
            dgvPartsListing.SelectionChanged += dataGridView1_SelectionChanged_1;
            // 
            // PartManagerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(spcPartManager);
            Name = "PartManagerControl";
            Size = new Size(975, 565);
            spcPartManager.Panel1.ResumeLayout(false);
            spcPartManager.Panel1.PerformLayout();
            spcPartManager.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcPartManager).EndInit();
            spcPartManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPartsListing).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer spcPartManager;
        private DataGridView dgvPartsListing;
        private TextBox txtSearch3;
        private TextBox txtSearch2;
        private TextBox txtSearch1;
        private Button btnPrintLabels;
        private TextBox txtSelectedPart;
        private Button bntAssociateSKU;
        private TextBox txtPartID;
    }
}

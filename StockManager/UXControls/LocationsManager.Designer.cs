namespace StockManager.UXControls
{
    partial class LocationsManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationsManager));
            toolStrip1 = new ToolStrip();
            tsPrintLabel = new ToolStripButton();
            tsSelectedLocation = new ToolStripLabel();
            dgvLocations = new DataGridView();
            splitContainer1 = new SplitContainer();
            dgvPartsByLocation = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPartsByLocation).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsPrintLabel, tsSelectedLocation });
            toolStrip1.Location = new Point(6, 6);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 1, 16);
            toolStrip1.Size = new Size(957, 46);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "tsLocationsMan";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // tsPrintLabel
            // 
            tsPrintLabel.AutoSize = false;
            tsPrintLabel.BackColor = SystemColors.MenuHighlight;
            tsPrintLabel.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsPrintLabel.ForeColor = SystemColors.ControlLightLight;
            tsPrintLabel.Image = (Image)resources.GetObject("tsPrintLabel.Image");
            tsPrintLabel.ImageTransparentColor = Color.Magenta;
            tsPrintLabel.Margin = new Padding(3);
            tsPrintLabel.Name = "tsPrintLabel";
            tsPrintLabel.Padding = new Padding(4);
            tsPrintLabel.Size = new Size(95, 24);
            tsPrintLabel.Text = "Print Rack Label";
            tsPrintLabel.ToolTipText = "Print the Label";
            // 
            // tsSelectedLocation
            // 
            tsSelectedLocation.Alignment = ToolStripItemAlignment.Right;
            tsSelectedLocation.BackColor = SystemColors.Highlight;
            tsSelectedLocation.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsSelectedLocation.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tsSelectedLocation.ForeColor = SystemColors.ActiveCaptionText;
            tsSelectedLocation.Name = "tsSelectedLocation";
            tsSelectedLocation.Padding = new Padding(0, 0, 24, 0);
            tsSelectedLocation.Size = new Size(126, 27);
            tsSelectedLocation.Text = "toolStripLabel1";
            // 
            // dgvLocations
            // 
            dgvLocations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocations.Dock = DockStyle.Fill;
            dgvLocations.Location = new Point(0, 0);
            dgvLocations.Name = "dgvLocations";
            dgvLocations.RowTemplate.Height = 25;
            dgvLocations.Size = new Size(319, 583);
            dgvLocations.TabIndex = 1;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(6, 52);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvLocations);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvPartsByLocation);
            splitContainer1.Size = new Size(957, 583);
            splitContainer1.SplitterDistance = 319;
            splitContainer1.TabIndex = 2;
            // 
            // dgvPartsByLocation
            // 
            dgvPartsByLocation.AllowUserToAddRows = false;
            dgvPartsByLocation.AllowUserToDeleteRows = false;
            dgvPartsByLocation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartsByLocation.Dock = DockStyle.Fill;
            dgvPartsByLocation.Location = new Point(0, 0);
            dgvPartsByLocation.Name = "dgvPartsByLocation";
            dgvPartsByLocation.ReadOnly = true;
            dgvPartsByLocation.RowTemplate.Height = 25;
            dgvPartsByLocation.Size = new Size(634, 583);
            dgvPartsByLocation.TabIndex = 0;
            // 
            // LocationsManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "LocationsManager";
            Padding = new Padding(6);
            Size = new Size(969, 641);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocations).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPartsByLocation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private DataGridView dgvLocations;
        private ToolStripButton tsPrintLabel;
        private SplitContainer splitContainer1;
        private DataGridView dgvPartsByLocation;
        private ToolStripLabel tsSelectedLocation;
    }
}

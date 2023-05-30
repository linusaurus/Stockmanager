namespace StockManager
{
    partial class PartEditForm
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
            btnSave = new Button();
            btnCancel = new Button();
            tabPartTabs = new TabControl();
            tabDetails = new TabPage();
            cbxUnitsOfMeasure = new ComboBox();
            txtWaste = new TextBox();
            txtManuPartName = new TextBox();
            textBox7 = new TextBox();
            txtWeight = new TextBox();
            txtMarkup = new TextBox();
            txtUnitCost = new TextBox();
            cbxObsolute = new CheckBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label11 = new Label();
            label12 = new Label();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label10 = new Label();
            txtPartName = new TextBox();
            txtPartID = new TextBox();
            txtItemDescription = new TextBox();
            cboLocations = new ComboBox();
            tabTransactions = new TabPage();
            lbStockLevel = new Label();
            textBox1 = new TextBox();
            btnDelete = new Button();
            btnTransEdit = new Button();
            dgvPartTransactions = new DataGridView();
            tabPartTabs.SuspendLayout();
            tabDetails.SuspendLayout();
            tabTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPartTransactions).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(656, 394);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 27);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(575, 394);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 27);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // tabPartTabs
            // 
            tabPartTabs.Controls.Add(tabDetails);
            tabPartTabs.Controls.Add(tabTransactions);
            tabPartTabs.Location = new Point(12, 12);
            tabPartTabs.Name = "tabPartTabs";
            tabPartTabs.SelectedIndex = 0;
            tabPartTabs.Size = new Size(761, 380);
            tabPartTabs.TabIndex = 2;
            // 
            // tabDetails
            // 
            tabDetails.Controls.Add(cbxUnitsOfMeasure);
            tabDetails.Controls.Add(txtWaste);
            tabDetails.Controls.Add(txtManuPartName);
            tabDetails.Controls.Add(textBox7);
            tabDetails.Controls.Add(txtWeight);
            tabDetails.Controls.Add(txtMarkup);
            tabDetails.Controls.Add(txtUnitCost);
            tabDetails.Controls.Add(cbxObsolute);
            tabDetails.Controls.Add(label9);
            tabDetails.Controls.Add(label8);
            tabDetails.Controls.Add(label7);
            tabDetails.Controls.Add(label6);
            tabDetails.Controls.Add(label5);
            tabDetails.Controls.Add(label11);
            tabDetails.Controls.Add(label12);
            tabDetails.Controls.Add(label1);
            tabDetails.Controls.Add(label4);
            tabDetails.Controls.Add(label3);
            tabDetails.Controls.Add(label2);
            tabDetails.Controls.Add(label10);
            tabDetails.Controls.Add(txtPartName);
            tabDetails.Controls.Add(txtPartID);
            tabDetails.Controls.Add(txtItemDescription);
            tabDetails.Controls.Add(cboLocations);
            tabDetails.Location = new Point(4, 24);
            tabDetails.Name = "tabDetails";
            tabDetails.Padding = new Padding(3);
            tabDetails.Size = new Size(753, 352);
            tabDetails.TabIndex = 0;
            tabDetails.Text = "Part Details";
            tabDetails.UseVisualStyleBackColor = true;
            // 
            // cbxUnitsOfMeasure
            // 
            cbxUnitsOfMeasure.FormattingEnabled = true;
            cbxUnitsOfMeasure.Location = new Point(115, 152);
            cbxUnitsOfMeasure.Name = "cbxUnitsOfMeasure";
            cbxUnitsOfMeasure.Size = new Size(89, 23);
            cbxUnitsOfMeasure.TabIndex = 28;
            // 
            // txtWaste
            // 
            txtWaste.Location = new Point(435, 152);
            txtWaste.Name = "txtWaste";
            txtWaste.Size = new Size(89, 23);
            txtWaste.TabIndex = 27;
            txtWaste.TextAlign = HorizontalAlignment.Center;
            // 
            // txtManuPartName
            // 
            txtManuPartName.Location = new Point(522, 193);
            txtManuPartName.Name = "txtManuPartName";
            txtManuPartName.Size = new Size(126, 23);
            txtManuPartName.TabIndex = 26;
            txtManuPartName.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(115, 192);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(89, 23);
            textBox7.TabIndex = 25;
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(245, 152);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(89, 23);
            txtWeight.TabIndex = 24;
            txtWeight.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMarkup
            // 
            txtMarkup.Location = new Point(340, 152);
            txtMarkup.Name = "txtMarkup";
            txtMarkup.Size = new Size(89, 23);
            txtMarkup.TabIndex = 23;
            txtMarkup.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUnitCost
            // 
            txtUnitCost.Location = new Point(20, 152);
            txtUnitCost.Name = "txtUnitCost";
            txtUnitCost.Size = new Size(89, 23);
            txtUnitCost.TabIndex = 22;
            txtUnitCost.TextAlign = HorizontalAlignment.Center;
            // 
            // cbxObsolute
            // 
            cbxObsolute.AutoSize = true;
            cbxObsolute.Location = new Point(20, 90);
            cbxObsolute.Name = "cbxObsolute";
            cbxObsolute.Size = new Size(73, 19);
            cbxObsolute.TabIndex = 21;
            cbxObsolute.Text = "Obsolete";
            cbxObsolute.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Location = new Point(559, 126);
            label9.Name = "label9";
            label9.Size = new Size(89, 23);
            label9.TabIndex = 18;
            label9.Text = "Location";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Location = new Point(435, 126);
            label8.Name = "label8";
            label8.Size = new Size(89, 23);
            label8.TabIndex = 19;
            label8.Text = "Waste";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Location = new Point(340, 126);
            label7.Name = "label7";
            label7.Size = new Size(89, 23);
            label7.TabIndex = 17;
            label7.Text = "Markup";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Location = new Point(245, 126);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 16;
            label6.Text = "Weight";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Location = new Point(115, 126);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 15;
            label5.Text = "Unit ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Location = new Point(435, 193);
            label11.Name = "label11";
            label11.Size = new Size(81, 23);
            label11.TabIndex = 14;
            label11.Text = "Manu-Part#";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Location = new Point(245, 193);
            label12.Name = "label12";
            label12.Size = new Size(184, 23);
            label12.TabIndex = 13;
            label12.Text = "Manufacturer";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(20, 193);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 12;
            label1.Text = "Stock Level";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Location = new Point(20, 126);
            label4.Name = "label4";
            label4.Size = new Size(89, 23);
            label4.TabIndex = 11;
            label4.Text = "Unit Cost";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Location = new Point(20, 49);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 10;
            label3.Text = "Description";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(20, 20);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 9;
            label2.Text = "PartID";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(378, 21);
            label10.Name = "label10";
            label10.Size = new Size(94, 23);
            label10.TabIndex = 8;
            label10.Text = "Short Name";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPartName
            // 
            txtPartName.Location = new Point(478, 21);
            txtPartName.Name = "txtPartName";
            txtPartName.Size = new Size(177, 23);
            txtPartName.TabIndex = 7;
            // 
            // txtPartID
            // 
            txtPartID.Location = new Point(108, 21);
            txtPartID.Name = "txtPartID";
            txtPartID.Size = new Size(90, 23);
            txtPartID.TabIndex = 6;
            // 
            // txtItemDescription
            // 
            txtItemDescription.Location = new Point(108, 47);
            txtItemDescription.Multiline = true;
            txtItemDescription.Name = "txtItemDescription";
            txtItemDescription.Size = new Size(547, 62);
            txtItemDescription.TabIndex = 1;
            // 
            // cboLocations
            // 
            cboLocations.FormattingEnabled = true;
            cboLocations.Location = new Point(559, 152);
            cboLocations.Name = "cboLocations";
            cboLocations.Size = new Size(89, 23);
            cboLocations.TabIndex = 0;
            // 
            // tabTransactions
            // 
            tabTransactions.Controls.Add(lbStockLevel);
            tabTransactions.Controls.Add(textBox1);
            tabTransactions.Controls.Add(btnDelete);
            tabTransactions.Controls.Add(btnTransEdit);
            tabTransactions.Controls.Add(dgvPartTransactions);
            tabTransactions.Location = new Point(4, 24);
            tabTransactions.Name = "tabTransactions";
            tabTransactions.Padding = new Padding(3);
            tabTransactions.Size = new Size(753, 352);
            tabTransactions.TabIndex = 1;
            tabTransactions.Text = "Part Transactions";
            tabTransactions.UseVisualStyleBackColor = true;
            // 
            // lbStockLevel
            // 
            lbStockLevel.AutoSize = true;
            lbStockLevel.Location = new Point(562, 12);
            lbStockLevel.Name = "lbStockLevel";
            lbStockLevel.Size = new Size(66, 15);
            lbStockLevel.TabIndex = 3;
            lbStockLevel.Text = "Stock Level";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(639, 7);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(108, 23);
            textBox1.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(96, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 23);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnTransEdit
            // 
            btnTransEdit.Location = new Point(6, 6);
            btnTransEdit.Name = "btnTransEdit";
            btnTransEdit.Size = new Size(84, 23);
            btnTransEdit.TabIndex = 1;
            btnTransEdit.Text = "Edit";
            btnTransEdit.UseVisualStyleBackColor = true;
            // 
            // dgvPartTransactions
            // 
            dgvPartTransactions.AllowUserToAddRows = false;
            dgvPartTransactions.AllowUserToDeleteRows = false;
            dgvPartTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartTransactions.Location = new Point(6, 35);
            dgvPartTransactions.Name = "dgvPartTransactions";
            dgvPartTransactions.RowTemplate.Height = 25;
            dgvPartTransactions.Size = new Size(741, 311);
            dgvPartTransactions.TabIndex = 0;
            // 
            // PartEditForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(785, 433);
            Controls.Add(tabPartTabs);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "PartEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PartEditForm";
            tabPartTabs.ResumeLayout(false);
            tabDetails.ResumeLayout(false);
            tabDetails.PerformLayout();
            tabTransactions.ResumeLayout(false);
            tabTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPartTransactions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private TabControl tabPartTabs;
        private TabPage tabDetails;
        private TabPage tabTransactions;
        private Button btnTransEdit;
        private DataGridView dgvPartTransactions;
        private Label lbStockLevel;
        private TextBox textBox1;
        private Button btnDelete;
        private ComboBox cboLocations;
        private TextBox txtItemDescription;
        private ComboBox cbxUnitsOfMeasure;
        private TextBox txtWaste;
        private TextBox txtManuPartName;
        private TextBox textBox7;
        private TextBox txtWeight;
        private TextBox txtMarkup;
        private TextBox txtUnitCost;
        private CheckBox cbxObsolute;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label11;
        private Label label12;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label10;
        private TextBox txtPartName;
        private TextBox txtPartID;
    }
}
namespace StockManager
{
    partial class PartEditor
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
            tabPartEditor = new TabControl();
            tabPartDetail = new TabPage();
            comboBox3 = new ComboBox();
            cbxLocation = new ComboBox();
            cbxUnitsOfMeasure = new ComboBox();
            txtWaste = new TextBox();
            txtManuPartName = new TextBox();
            textBox7 = new TextBox();
            txtWeight = new TextBox();
            txtMarkup = new TextBox();
            txtUnitCost = new TextBox();
            cbxObsolute = new CheckBox();
            txtItemDescription = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label11 = new Label();
            label12 = new Label();
            lbStockLevel = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPartName = new TextBox();
            txtPartID = new TextBox();
            tabStockTransactions = new TabPage();
            dgvPartTransactions = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            tabPartEditor.SuspendLayout();
            tabPartDetail.SuspendLayout();
            tabStockTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPartTransactions).BeginInit();
            SuspendLayout();
            // 
            // tabPartEditor
            // 
            tabPartEditor.Controls.Add(tabPartDetail);
            tabPartEditor.Controls.Add(tabStockTransactions);
            tabPartEditor.Dock = DockStyle.Fill;
            tabPartEditor.Location = new Point(6, 6);
            tabPartEditor.Name = "tabPartEditor";
            tabPartEditor.SelectedIndex = 0;
            tabPartEditor.Size = new Size(624, 431);
            tabPartEditor.TabIndex = 0;
            // 
            // tabPartDetail
            // 
            tabPartDetail.Controls.Add(button2);
            tabPartDetail.Controls.Add(button1);
            tabPartDetail.Controls.Add(comboBox3);
            tabPartDetail.Controls.Add(cbxLocation);
            tabPartDetail.Controls.Add(cbxUnitsOfMeasure);
            tabPartDetail.Controls.Add(txtWaste);
            tabPartDetail.Controls.Add(txtManuPartName);
            tabPartDetail.Controls.Add(textBox7);
            tabPartDetail.Controls.Add(txtWeight);
            tabPartDetail.Controls.Add(txtMarkup);
            tabPartDetail.Controls.Add(txtUnitCost);
            tabPartDetail.Controls.Add(cbxObsolute);
            tabPartDetail.Controls.Add(txtItemDescription);
            tabPartDetail.Controls.Add(label9);
            tabPartDetail.Controls.Add(label8);
            tabPartDetail.Controls.Add(label7);
            tabPartDetail.Controls.Add(label6);
            tabPartDetail.Controls.Add(label5);
            tabPartDetail.Controls.Add(label11);
            tabPartDetail.Controls.Add(label12);
            tabPartDetail.Controls.Add(lbStockLevel);
            tabPartDetail.Controls.Add(label4);
            tabPartDetail.Controls.Add(label3);
            tabPartDetail.Controls.Add(label2);
            tabPartDetail.Controls.Add(label1);
            tabPartDetail.Controls.Add(txtPartName);
            tabPartDetail.Controls.Add(txtPartID);
            tabPartDetail.Location = new Point(4, 24);
            tabPartDetail.Name = "tabPartDetail";
            tabPartDetail.Padding = new Padding(3);
            tabPartDetail.Size = new Size(616, 403);
            tabPartDetail.TabIndex = 0;
            tabPartDetail.Text = "Part Details";
            tabPartDetail.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(20, 254);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(184, 23);
            comboBox3.TabIndex = 7;
            // 
            // cbxLocation
            // 
            cbxLocation.FormattingEnabled = true;
            cbxLocation.Location = new Point(495, 157);
            cbxLocation.Name = "cbxLocation";
            cbxLocation.Size = new Size(89, 23);
            cbxLocation.TabIndex = 6;
            // 
            // cbxUnitsOfMeasure
            // 
            cbxUnitsOfMeasure.FormattingEnabled = true;
            cbxUnitsOfMeasure.Location = new Point(115, 157);
            cbxUnitsOfMeasure.Name = "cbxUnitsOfMeasure";
            cbxUnitsOfMeasure.Size = new Size(89, 23);
            cbxUnitsOfMeasure.TabIndex = 5;
            // 
            // txtWaste
            // 
            txtWaste.Location = new Point(400, 157);
            txtWaste.Name = "txtWaste";
            txtWaste.Size = new Size(89, 23);
            txtWaste.TabIndex = 4;
            txtWaste.TextAlign = HorizontalAlignment.Center;
            // 
            // txtManuPartName
            // 
            txtManuPartName.Location = new Point(452, 198);
            txtManuPartName.Name = "txtManuPartName";
            txtManuPartName.Size = new Size(132, 23);
            txtManuPartName.TabIndex = 4;
            txtManuPartName.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(115, 197);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(89, 23);
            textBox7.TabIndex = 4;
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(210, 157);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(89, 23);
            txtWeight.TabIndex = 4;
            txtWeight.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMarkup
            // 
            txtMarkup.Location = new Point(305, 157);
            txtMarkup.Name = "txtMarkup";
            txtMarkup.Size = new Size(89, 23);
            txtMarkup.TabIndex = 4;
            txtMarkup.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUnitCost
            // 
            txtUnitCost.Location = new Point(20, 157);
            txtUnitCost.Name = "txtUnitCost";
            txtUnitCost.Size = new Size(89, 23);
            txtUnitCost.TabIndex = 4;
            txtUnitCost.TextAlign = HorizontalAlignment.Center;
            // 
            // cbxObsolute
            // 
            cbxObsolute.AutoSize = true;
            cbxObsolute.Location = new Point(20, 95);
            cbxObsolute.Name = "cbxObsolute";
            cbxObsolute.Size = new Size(73, 19);
            cbxObsolute.TabIndex = 3;
            cbxObsolute.Text = "Obsolete";
            cbxObsolute.UseVisualStyleBackColor = true;
            // 
            // txtItemDescription
            // 
            txtItemDescription.Location = new Point(108, 55);
            txtItemDescription.Multiline = true;
            txtItemDescription.Name = "txtItemDescription";
            txtItemDescription.Size = new Size(476, 59);
            txtItemDescription.TabIndex = 2;
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Location = new Point(495, 131);
            label9.Name = "label9";
            label9.Size = new Size(89, 23);
            label9.TabIndex = 1;
            label9.Text = "Location";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Location = new Point(400, 131);
            label8.Name = "label8";
            label8.Size = new Size(89, 23);
            label8.TabIndex = 1;
            label8.Text = "Waste";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Location = new Point(305, 131);
            label7.Name = "label7";
            label7.Size = new Size(89, 23);
            label7.TabIndex = 1;
            label7.Text = "Markup";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Location = new Point(210, 131);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 1;
            label6.Text = "Weight";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Location = new Point(115, 131);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 1;
            label5.Text = "Unit ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Location = new Point(357, 198);
            label11.Name = "label11";
            label11.Size = new Size(89, 23);
            label11.TabIndex = 1;
            label11.Text = "Manu-Part#";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Location = new Point(20, 226);
            label12.Name = "label12";
            label12.Size = new Size(184, 23);
            label12.TabIndex = 1;
            label12.Text = "Manufacturer";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbStockLevel
            // 
            lbStockLevel.BorderStyle = BorderStyle.FixedSingle;
            lbStockLevel.FlatStyle = FlatStyle.Flat;
            lbStockLevel.Location = new Point(20, 198);
            lbStockLevel.Name = "lbStockLevel";
            lbStockLevel.Size = new Size(89, 23);
            lbStockLevel.TabIndex = 1;
            lbStockLevel.Text = "Stock Level";
            lbStockLevel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Location = new Point(20, 131);
            label4.Name = "label4";
            label4.Size = new Size(89, 23);
            label4.TabIndex = 1;
            label4.Text = "Unit Cost";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Location = new Point(20, 54);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 1;
            label3.Text = "Description";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(20, 25);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 1;
            label2.Text = "PartID";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(307, 26);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 1;
            label1.Text = "Short Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPartName
            // 
            txtPartName.Location = new Point(407, 26);
            txtPartName.Name = "txtPartName";
            txtPartName.Size = new Size(177, 23);
            txtPartName.TabIndex = 0;
            // 
            // txtPartID
            // 
            txtPartID.Location = new Point(108, 26);
            txtPartID.Name = "txtPartID";
            txtPartID.Size = new Size(90, 23);
            txtPartID.TabIndex = 0;
            // 
            // tabStockTransactions
            // 
            tabStockTransactions.Controls.Add(dgvPartTransactions);
            tabStockTransactions.Location = new Point(4, 24);
            tabStockTransactions.Name = "tabStockTransactions";
            tabStockTransactions.Padding = new Padding(6);
            tabStockTransactions.Size = new Size(616, 403);
            tabStockTransactions.TabIndex = 1;
            tabStockTransactions.Text = "tabPage2";
            tabStockTransactions.UseVisualStyleBackColor = true;
            // 
            // dgvPartTransactions
            // 
            dgvPartTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartTransactions.Dock = DockStyle.Bottom;
            dgvPartTransactions.Location = new Point(6, 57);
            dgvPartTransactions.Name = "dgvPartTransactions";
            dgvPartTransactions.RowTemplate.Height = 25;
            dgvPartTransactions.Size = new Size(604, 340);
            dgvPartTransactions.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(495, 355);
            button1.Name = "button1";
            button1.Size = new Size(89, 29);
            button1.TabIndex = 8;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(414, 355);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 9;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // PartEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabPartEditor);
            Name = "PartEditor";
            Padding = new Padding(6);
            Size = new Size(636, 443);
            tabPartEditor.ResumeLayout(false);
            tabPartDetail.ResumeLayout(false);
            tabPartDetail.PerformLayout();
            tabStockTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPartTransactions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPartEditor;
        private TabPage tabPartDetail;
        private TabPage tabStockTransactions;
        private TextBox txtItemDescription;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPartName;
        private TextBox txtPartID;
        private ComboBox comboBox3;
        private ComboBox cbxLocation;
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
        private Label lbStockLevel;
        private Label label4;
        private DataGridView dgvPartTransactions;
        private Button button2;
        private Button button1;
    }
}

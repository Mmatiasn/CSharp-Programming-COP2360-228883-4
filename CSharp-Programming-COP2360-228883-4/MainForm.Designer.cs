namespace CSharp_Programming_COP2360_228883_4
{
    partial class MainForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Beaded - $45");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Decorative - $50");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Fringed - $25");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Leather - $80");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Pirate - $40");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BagSelection = new CSharp_Programming_COP2360_228883_4.MaterialDesign.Controls.MaterialListView();
            this.BagSelectionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantityBox = new System.Windows.Forms.ComboBox();
            this.QuantityDesiredLabel = new CSharp_Programming_COP2360_228883_4.MaterialDesign.Controls.MaterialLabel();
            this.OverNightRadioButton = new CSharp_Programming_COP2360_228883_4.MaterialDesign.Controls.MaterialRadioButton();
            this.StandardRadioButton = new CSharp_Programming_COP2360_228883_4.MaterialDesign.Controls.MaterialRadioButton();
            this.ThreeDayRadioButton = new CSharp_Programming_COP2360_228883_4.MaterialDesign.Controls.MaterialRadioButton();
            this.DeliveryRateBox = new System.Windows.Forms.GroupBox();
            this.materialDivider1 = new CSharp_Programming_COP2360_228883_4.MaterialDesign.Controls.MaterialDivider();
            this.ClearSelectionButton = new CSharp_Programming_COP2360_228883_4.MaterialDesign.Controls.MaterialFlatButton();
            this.ProcessOrderButton = new CSharp_Programming_COP2360_228883_4.MaterialDesign.Controls.MaterialRaisedButton();
            this.BagTypeErrorLabel = new CSharp_Programming_COP2360_228883_4.MaterialDesign.Controls.MaterialLabel();
            this.QuantityErrorLabel = new CSharp_Programming_COP2360_228883_4.MaterialDesign.Controls.MaterialLabel();
            this.DeliveryErrorLabel = new CSharp_Programming_COP2360_228883_4.MaterialDesign.Controls.MaterialLabel();
            this.RequiredInfoLabel = new CSharp_Programming_COP2360_228883_4.MaterialDesign.Controls.MaterialLabel();
            this.materialDivider2 = new CSharp_Programming_COP2360_228883_4.MaterialDesign.Controls.MaterialDivider();
            this.DeliveryRateBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BagSelection
            // 
            this.BagSelection.BackColor = System.Drawing.SystemColors.Window;
            this.BagSelection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BagSelection.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BagSelectionColumn});
            this.BagSelection.Depth = 0;
            this.BagSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.BagSelection.FullRowSelect = true;
            this.BagSelection.GridLines = true;
            this.BagSelection.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem1.Tag = "45";
            listViewItem2.Tag = "50";
            listViewItem3.Tag = "25";
            listViewItem4.Tag = "80";
            listViewItem5.Tag = "40";
            this.BagSelection.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.BagSelection.Location = new System.Drawing.Point(79, 79);
            this.BagSelection.Margin = new System.Windows.Forms.Padding(70, 70, 0, 0);
            this.BagSelection.MouseLocation = new System.Drawing.Point(-1, -1);
            this.BagSelection.MouseState = CSharp_Programming_COP2360_228883_4.MaterialDesign.MouseState.OUT;
            this.BagSelection.MultiSelect = false;
            this.BagSelection.Name = "BagSelection";
            this.BagSelection.OwnerDraw = true;
            this.BagSelection.Size = new System.Drawing.Size(400, 200);
            this.BagSelection.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.BagSelection.TabIndex = 0;
            this.BagSelection.UseCompatibleStateImageBehavior = false;
            this.BagSelection.View = System.Windows.Forms.View.Details;
            this.BagSelection.VirtualListSize = 1;
            this.BagSelection.SelectedIndexChanged += new System.EventHandler(this.BagSelection_SelectedIndexChanged);
            // 
            // BagSelectionColumn
            // 
            this.BagSelectionColumn.Text = "Bag Selection:";
            this.BagSelectionColumn.Width = 383;
            // 
            // QuantityBox
            // 
            this.QuantityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuantityBox.FormattingEnabled = true;
            this.QuantityBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.QuantityBox.Location = new System.Drawing.Point(570, 123);
            this.QuantityBox.Margin = new System.Windows.Forms.Padding(0, 25, 100, 0);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(121, 21);
            this.QuantityBox.TabIndex = 1;
            this.QuantityBox.SelectedValueChanged += new System.EventHandler(this.QuantityBox_SelectedValueChanged);
            // 
            // QuantityDesiredLabel
            // 
            this.QuantityDesiredLabel.AutoSize = true;
            this.QuantityDesiredLabel.Depth = 0;
            this.QuantityDesiredLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.QuantityDesiredLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.QuantityDesiredLabel.Location = new System.Drawing.Point(572, 79);
            this.QuantityDesiredLabel.Margin = new System.Windows.Forms.Padding(0, 70, 100, 0);
            this.QuantityDesiredLabel.MouseState = CSharp_Programming_COP2360_228883_4.MaterialDesign.MouseState.HOVER;
            this.QuantityDesiredLabel.Name = "QuantityDesiredLabel";
            this.QuantityDesiredLabel.Size = new System.Drawing.Size(119, 19);
            this.QuantityDesiredLabel.TabIndex = 2;
            this.QuantityDesiredLabel.Text = "Quantity Desired";
            // 
            // OverNightRadioButton
            // 
            this.OverNightRadioButton.AutoSize = true;
            this.OverNightRadioButton.Depth = 0;
            this.OverNightRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.OverNightRadioButton.Location = new System.Drawing.Point(15, 118);
            this.OverNightRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.OverNightRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.OverNightRadioButton.MouseState = CSharp_Programming_COP2360_228883_4.MaterialDesign.MouseState.HOVER;
            this.OverNightRadioButton.Name = "OverNightRadioButton";
            this.OverNightRadioButton.Ripple = true;
            this.OverNightRadioButton.Size = new System.Drawing.Size(127, 30);
            this.OverNightRadioButton.TabIndex = 0;
            this.OverNightRadioButton.TabStop = true;
            this.OverNightRadioButton.Tag = "10";
            this.OverNightRadioButton.Text = "Overnight (10%)";
            this.OverNightRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OverNightRadioButton.UseVisualStyleBackColor = true;
            // 
            // StandardRadioButton
            // 
            this.StandardRadioButton.AutoSize = true;
            this.StandardRadioButton.Depth = 0;
            this.StandardRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.StandardRadioButton.Location = new System.Drawing.Point(15, 28);
            this.StandardRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.StandardRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.StandardRadioButton.MouseState = CSharp_Programming_COP2360_228883_4.MaterialDesign.MouseState.HOVER;
            this.StandardRadioButton.Name = "StandardRadioButton";
            this.StandardRadioButton.Ripple = true;
            this.StandardRadioButton.Size = new System.Drawing.Size(116, 30);
            this.StandardRadioButton.TabIndex = 2;
            this.StandardRadioButton.TabStop = true;
            this.StandardRadioButton.Tag = "5";
            this.StandardRadioButton.Text = "Standard (5%)";
            this.StandardRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StandardRadioButton.UseVisualStyleBackColor = true;
            // 
            // ThreeDayRadioButton
            // 
            this.ThreeDayRadioButton.AutoSize = true;
            this.ThreeDayRadioButton.Depth = 0;
            this.ThreeDayRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.ThreeDayRadioButton.Location = new System.Drawing.Point(15, 73);
            this.ThreeDayRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.ThreeDayRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ThreeDayRadioButton.MouseState = CSharp_Programming_COP2360_228883_4.MaterialDesign.MouseState.HOVER;
            this.ThreeDayRadioButton.Name = "ThreeDayRadioButton";
            this.ThreeDayRadioButton.Ripple = true;
            this.ThreeDayRadioButton.Size = new System.Drawing.Size(95, 30);
            this.ThreeDayRadioButton.TabIndex = 1;
            this.ThreeDayRadioButton.TabStop = true;
            this.ThreeDayRadioButton.Tag = "7";
            this.ThreeDayRadioButton.Text = "3-Day (7%)";
            this.ThreeDayRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ThreeDayRadioButton.UseVisualStyleBackColor = true;
            // 
            // DeliveryRateBox
            // 
            this.DeliveryRateBox.Controls.Add(this.StandardRadioButton);
            this.DeliveryRateBox.Controls.Add(this.OverNightRadioButton);
            this.DeliveryRateBox.Controls.Add(this.ThreeDayRadioButton);
            this.DeliveryRateBox.Location = new System.Drawing.Point(79, 300);
            this.DeliveryRateBox.Margin = new System.Windows.Forms.Padding(70, 0, 0, 25);
            this.DeliveryRateBox.Name = "DeliveryRateBox";
            this.DeliveryRateBox.Padding = new System.Windows.Forms.Padding(0);
            this.DeliveryRateBox.Size = new System.Drawing.Size(400, 166);
            this.DeliveryRateBox.TabIndex = 3;
            this.DeliveryRateBox.TabStop = false;
            this.DeliveryRateBox.Text = "Delivery Type";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(19, 289);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(10);
            this.materialDivider1.MouseState = CSharp_Programming_COP2360_228883_4.MaterialDesign.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(762, 1);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // ClearSelectionButton
            // 
            this.ClearSelectionButton.AutoSize = true;
            this.ClearSelectionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClearSelectionButton.Depth = 0;
            this.ClearSelectionButton.Icon = null;
            this.ClearSelectionButton.Location = new System.Drawing.Point(649, 430);
            this.ClearSelectionButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClearSelectionButton.MouseState = CSharp_Programming_COP2360_228883_4.MaterialDesign.MouseState.HOVER;
            this.ClearSelectionButton.Name = "ClearSelectionButton";
            this.ClearSelectionButton.Primary = false;
            this.ClearSelectionButton.Size = new System.Drawing.Size(138, 36);
            this.ClearSelectionButton.TabIndex = 5;
            this.ClearSelectionButton.Text = "Clear Selection";
            this.ClearSelectionButton.UseVisualStyleBackColor = true;
            this.ClearSelectionButton.Click += new System.EventHandler(this.ClearSelectionButton_Click);
            // 
            // ProcessOrderButton
            // 
            this.ProcessOrderButton.AutoSize = true;
            this.ProcessOrderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProcessOrderButton.Depth = 0;
            this.ProcessOrderButton.Enabled = false;
            this.ProcessOrderButton.Icon = null;
            this.ProcessOrderButton.Location = new System.Drawing.Point(514, 430);
            this.ProcessOrderButton.MouseState = CSharp_Programming_COP2360_228883_4.MaterialDesign.MouseState.HOVER;
            this.ProcessOrderButton.Name = "ProcessOrderButton";
            this.ProcessOrderButton.Primary = true;
            this.ProcessOrderButton.Size = new System.Drawing.Size(128, 36);
            this.ProcessOrderButton.TabIndex = 6;
            this.ProcessOrderButton.Text = "Process Order";
            this.ProcessOrderButton.UseVisualStyleBackColor = true;
            this.ProcessOrderButton.Visible = false;
            this.ProcessOrderButton.Click += new System.EventHandler(this.ProcessOrderButton_Click);
            // 
            // BagTypeErrorLabel
            // 
            this.BagTypeErrorLabel.AutoSize = true;
            this.BagTypeErrorLabel.Depth = 0;
            this.BagTypeErrorLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.BagTypeErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BagTypeErrorLabel.Location = new System.Drawing.Point(566, 260);
            this.BagTypeErrorLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.BagTypeErrorLabel.MouseState = CSharp_Programming_COP2360_228883_4.MaterialDesign.MouseState.HOVER;
            this.BagTypeErrorLabel.Name = "BagTypeErrorLabel";
            this.BagTypeErrorLabel.Size = new System.Drawing.Size(184, 19);
            this.BagTypeErrorLabel.TabIndex = 7;
            this.BagTypeErrorLabel.Text = "• Bag selection is required";
            // 
            // QuantityErrorLabel
            // 
            this.QuantityErrorLabel.AutoSize = true;
            this.QuantityErrorLabel.Depth = 0;
            this.QuantityErrorLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.QuantityErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.QuantityErrorLabel.Location = new System.Drawing.Point(566, 231);
            this.QuantityErrorLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.QuantityErrorLabel.MouseState = CSharp_Programming_COP2360_228883_4.MaterialDesign.MouseState.HOVER;
            this.QuantityErrorLabel.Name = "QuantityErrorLabel";
            this.QuantityErrorLabel.Size = new System.Drawing.Size(201, 19);
            this.QuantityErrorLabel.TabIndex = 8;
            this.QuantityErrorLabel.Text = "• Quantity desired is required";
            // 
            // DeliveryErrorLabel
            // 
            this.DeliveryErrorLabel.AutoSize = true;
            this.DeliveryErrorLabel.Depth = 0;
            this.DeliveryErrorLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.DeliveryErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeliveryErrorLabel.Location = new System.Drawing.Point(566, 202);
            this.DeliveryErrorLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.DeliveryErrorLabel.MouseState = CSharp_Programming_COP2360_228883_4.MaterialDesign.MouseState.HOVER;
            this.DeliveryErrorLabel.Name = "DeliveryErrorLabel";
            this.DeliveryErrorLabel.Size = new System.Drawing.Size(178, 19);
            this.DeliveryErrorLabel.TabIndex = 9;
            this.DeliveryErrorLabel.Text = "• Delivery type is required";
            // 
            // RequiredInfoLabel
            // 
            this.RequiredInfoLabel.AutoSize = true;
            this.RequiredInfoLabel.Depth = 0;
            this.RequiredInfoLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.RequiredInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RequiredInfoLabel.Location = new System.Drawing.Point(566, 173);
            this.RequiredInfoLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.RequiredInfoLabel.MouseState = CSharp_Programming_COP2360_228883_4.MaterialDesign.MouseState.HOVER;
            this.RequiredInfoLabel.Name = "RequiredInfoLabel";
            this.RequiredInfoLabel.Size = new System.Drawing.Size(202, 19);
            this.RequiredInfoLabel.TabIndex = 10;
            this.RequiredInfoLabel.Text = "Please provide the following:";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(514, 79);
            this.materialDivider2.Margin = new System.Windows.Forms.Padding(10);
            this.materialDivider2.MouseState = CSharp_Programming_COP2360_228883_4.MaterialDesign.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(1, 200);
            this.materialDivider2.TabIndex = 11;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.RequiredInfoLabel);
            this.Controls.Add(this.DeliveryErrorLabel);
            this.Controls.Add(this.QuantityErrorLabel);
            this.Controls.Add(this.BagTypeErrorLabel);
            this.Controls.Add(this.ProcessOrderButton);
            this.Controls.Add(this.ClearSelectionButton);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.DeliveryRateBox);
            this.Controls.Add(this.QuantityDesiredLabel);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.BagSelection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Bag Order Application";
            this.DeliveryRateBox.ResumeLayout(false);
            this.DeliveryRateBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialDesign.Controls.MaterialListView BagSelection;
        private System.Windows.Forms.ColumnHeader BagSelectionColumn;
        private System.Windows.Forms.ComboBox QuantityBox;
        private MaterialDesign.Controls.MaterialLabel QuantityDesiredLabel;
        private MaterialDesign.Controls.MaterialRadioButton OverNightRadioButton;
        private MaterialDesign.Controls.MaterialRadioButton ThreeDayRadioButton;
        private MaterialDesign.Controls.MaterialRadioButton StandardRadioButton;
        private System.Windows.Forms.GroupBox DeliveryRateBox;
        private MaterialDesign.Controls.MaterialDivider materialDivider1;
        private MaterialDesign.Controls.MaterialFlatButton ClearSelectionButton;
        private MaterialDesign.Controls.MaterialRaisedButton ProcessOrderButton;
        private MaterialDesign.Controls.MaterialLabel BagTypeErrorLabel;
        private MaterialDesign.Controls.MaterialLabel QuantityErrorLabel;
        private MaterialDesign.Controls.MaterialLabel DeliveryErrorLabel;
        private MaterialDesign.Controls.MaterialLabel RequiredInfoLabel;
        private MaterialDesign.Controls.MaterialDivider materialDivider2;
    }
}


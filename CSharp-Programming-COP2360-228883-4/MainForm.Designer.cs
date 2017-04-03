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
            this.materialLabel1 = new CSharp_Programming_COP2360_228883_4.MaterialDesign.Controls.MaterialLabel();
            this.OverNightRadioButton = new CSharp_Programming_COP2360_228883_4.MaterialDesign.Controls.MaterialRadioButton();
            this.materialRadioButton1 = new CSharp_Programming_COP2360_228883_4.MaterialDesign.Controls.MaterialRadioButton();
            this.ThreeDayRadioButton = new CSharp_Programming_COP2360_228883_4.MaterialDesign.Controls.MaterialRadioButton();
            this.DeliveryRateBox = new System.Windows.Forms.GroupBox();
            this.materialDivider1 = new CSharp_Programming_COP2360_228883_4.MaterialDesign.Controls.MaterialDivider();
            this.ClearSelectionButton = new CSharp_Programming_COP2360_228883_4.MaterialDesign.Controls.MaterialFlatButton();
            this.ProcessOrderButton = new CSharp_Programming_COP2360_228883_4.MaterialDesign.Controls.MaterialRaisedButton();
            this.DeliveryRateBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BagSelection
            // 
            this.BagSelection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BagSelection.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BagSelectionColumn});
            this.BagSelection.Depth = 0;
            this.BagSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.BagSelection.FullRowSelect = true;
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
            "10",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.QuantityBox.Location = new System.Drawing.Point(570, 123);
            this.QuantityBox.Margin = new System.Windows.Forms.Padding(0, 25, 100, 0);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(121, 21);
            this.QuantityBox.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(572, 79);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(0, 70, 100, 0);
            this.materialLabel1.MouseState = CSharp_Programming_COP2360_228883_4.MaterialDesign.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(119, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Quantity Desired";
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
            this.OverNightRadioButton.Text = "Overnight (10%)";
            this.OverNightRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OverNightRadioButton.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton1.Location = new System.Drawing.Point(15, 28);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = CSharp_Programming_COP2360_228883_4.MaterialDesign.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(116, 30);
            this.materialRadioButton1.TabIndex = 2;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Tag = "5";
            this.materialRadioButton1.Text = "Standard (5%)";
            this.materialRadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialRadioButton1.UseVisualStyleBackColor = true;
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
            this.DeliveryRateBox.Controls.Add(this.materialRadioButton1);
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
            // 
            // ProcessOrderButton
            // 
            this.ProcessOrderButton.AutoSize = true;
            this.ProcessOrderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProcessOrderButton.Depth = 0;
            this.ProcessOrderButton.Icon = null;
            this.ProcessOrderButton.Location = new System.Drawing.Point(514, 430);
            this.ProcessOrderButton.MouseState = CSharp_Programming_COP2360_228883_4.MaterialDesign.MouseState.HOVER;
            this.ProcessOrderButton.Name = "ProcessOrderButton";
            this.ProcessOrderButton.Primary = true;
            this.ProcessOrderButton.Size = new System.Drawing.Size(128, 36);
            this.ProcessOrderButton.TabIndex = 6;
            this.ProcessOrderButton.Text = "Process Order";
            this.ProcessOrderButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.ProcessOrderButton);
            this.Controls.Add(this.ClearSelectionButton);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.DeliveryRateBox);
            this.Controls.Add(this.materialLabel1);
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
        private MaterialDesign.Controls.MaterialLabel materialLabel1;
        private MaterialDesign.Controls.MaterialRadioButton OverNightRadioButton;
        private MaterialDesign.Controls.MaterialRadioButton ThreeDayRadioButton;
        private MaterialDesign.Controls.MaterialRadioButton materialRadioButton1;
        private System.Windows.Forms.GroupBox DeliveryRateBox;
        private MaterialDesign.Controls.MaterialDivider materialDivider1;
        private MaterialDesign.Controls.MaterialFlatButton ClearSelectionButton;
        private MaterialDesign.Controls.MaterialRaisedButton ProcessOrderButton;
    }
}


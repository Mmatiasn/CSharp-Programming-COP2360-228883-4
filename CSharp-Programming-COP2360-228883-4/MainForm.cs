using CSharp_Programming_COP2360_228883_4.MaterialDesign;
using CSharp_Programming_COP2360_228883_4.MaterialDesign.Controls;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace CSharp_Programming_COP2360_228883_4
{
    public partial class MainForm : MaterialForm
    {
        #region Private Tracking Properties
        private decimal _bagPrice = 0;
        private decimal _shipPercent = 0;
        private decimal _quantity = 0;
        #endregion

        #region MainForm
        public MainForm()
        {
            #region Standard Initialization Of Component
            InitializeComponent();
            #endregion

            #region Material Design Related Code
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            #endregion

            #region Event handler for radio button selection
            StandardRadioButton.CheckedChanged += new EventHandler(RadioButtons_CheckedChanged);
            ThreeDayRadioButton.CheckedChanged += new EventHandler(RadioButtons_CheckedChanged);
            OverNightRadioButton.CheckedChanged += new EventHandler(RadioButtons_CheckedChanged);
            #endregion
        }
        #endregion

        #region ListView Selection Changed Event
        private void BagSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaterialListView listView = sender as MaterialListView;
            _bagPrice = int.Parse(listView.SelectedItems[0].Tag.ToString()); BagTypeErrorLabel.Visible = false;
            ProcessOrderButton_Status();
        }
        #endregion

        #region Radio Button Changed
        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            _shipPercent = int.Parse(radioButton.Tag.ToString()); DeliveryErrorLabel.Visible = false;
            ProcessOrderButton_Status();
        }
        #endregion

        #region Dropdown Changed Event
        private void QuantityBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            _quantity = int.Parse(comboBox.Text); QuantityErrorLabel.Visible = false;
            ProcessOrderButton_Status();
        }
        #endregion

        #region Label Errors Tracking
        private void ProcessOrderButton_Status()
        {
            if (_bagPrice != 0 && _quantity != 0 && _shipPercent != 0)
            {
                ProcessOrderButton.Enabled = ProcessOrderButton.Visible = true;
                RequiredInfoLabel.Visible = false;
            }
            else
            {
                ProcessOrderButton.Enabled = ProcessOrderButton.Visible = false;
                RequiredInfoLabel.Visible = true;
            }
        }
        #endregion

        #region Clear Selection
        private void ClearSelectionButton_Click(object sender, EventArgs e)
        {
            #region Reset Tracking
            _bagPrice = _quantity = _shipPercent = 0;
            #endregion

            #region Reset All Error Labels
            QuantityErrorLabel.Visible = DeliveryErrorLabel.Visible = BagTypeErrorLabel.Visible = RequiredInfoLabel.Visible = true;
            #endregion

            #region Reset Quantity Dropdown
            QuantityBox.SelectedIndex = -1;
            #endregion

            #region Resets RadioButtons
            StandardRadioButton.Checked = ThreeDayRadioButton.Checked = OverNightRadioButton.Checked = false;
            #endregion

            #region Resets BagSelection
            foreach (ListViewItem listViewItem in BagSelection.SelectedItems)
            {
                listViewItem.Remove();
            }
            #endregion
        }
        #endregion

        #region Process Order
        private void ProcessOrderButton_Click(object sender, EventArgs e)
        {
            var header = "Items to Order\n";
            var line = "--------------\n";
            var bagType = "Bag Type: " + BagSelection.SelectedItems[0].Text + "\n";
            var quantity = "Quantity: " + _quantity.ToString() + "\n";
            var bagCost = _bagPrice * _quantity;
            var shipCost = bagCost * _shipPercent / 100;
            var shipping = "Shipping Charges: " + shipCost.ToString("C", CultureInfo.CurrentCulture) + "\n";
            var tottalCost = "Total Cost: " + (bagCost + shipCost).ToString("C", CultureInfo.CurrentCulture);

            var message = header + line + bagType + quantity + shipping + tottalCost;
            var caption = "Bag App";

            MessageBox.Show(message, caption,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.None);
        }
        #endregion
    }
}

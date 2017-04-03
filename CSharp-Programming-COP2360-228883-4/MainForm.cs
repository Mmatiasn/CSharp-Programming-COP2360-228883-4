using CSharp_Programming_COP2360_228883_4.MaterialDesign;
using CSharp_Programming_COP2360_228883_4.MaterialDesign.Controls;

namespace CSharp_Programming_COP2360_228883_4
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            InitializeBagSelection();
        }

        public void InitializeBagSelection()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_301041985.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PrintInfo()
        {
            ConditiontextBox.Text = Program.product.condition.ToString();
            PricetextBox.Text = Program.product.cost.ToString();
            PlatformtextBox.Text = Program.product.platform.ToString();
            OStextBox.Text = Program.product.OS.ToString();
            ManufacturerLabeltextBox.Text = Program.product.manufacturer.ToString();
            ModeltextBox.Text = Program.product.model.ToString();
            MemorytextBox.Text = Program.product.RAM_size.ToString();
            LCDsizetextBox.Text = Program.product.width.ToString();
            HDDtextBox.Text = Program.product.HDD_size.ToString();
            CPUtypetextBox.Text = Program.product.CPU_type.ToString();
            CPUnumbertextBox.Text = Program.product.CPU_number.ToString();
            WebCamTextbox.Text = Program.product.webcam.ToString();
            CPUBrandtextBox.Text = Program.product.CPU_brand.ToString();
            CPUspeedtextBox.Text = Program.product.CPU_speed.ToString();
            GPUTypetextBox.Text = Program.product.GPU_Type.ToString();
            TaxtextBox.Text = (double.Parse(PricetextBox.Text) * 0.13).ToString();
            TotaltextBox.Text = (double.Parse(PricetextBox.Text) + double.Parse(TaxtextBox.Text)).ToString();
            PricetextBox.Text += "$";
            TaxtextBox.Text += "$";
            TotaltextBox.Text += "$";
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            PrintInfo();
        }
    }
}

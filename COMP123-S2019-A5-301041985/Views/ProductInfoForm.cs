using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_301041985.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductLoaded()
        {
            ProductIDTextLabel.Text = Program.product.productID.ToString();
            ConditionTextLabel.Text = Program.product.condition;
            CostTextLabel.Text = Program.product.cost.ToString();
            PlatformTextLabel.Text = Program.product.platform;
            OSTextLabel.Text = Program.product.OS;
            ManufacturerTextLabel.Text = Program.product.manufacturer;
            ModelTextLabel.Text = Program.product.model;
            MemoryTextLabel.Text = Program.product.RAM_size;
            LCDSizeTextLabel.Text = Program.product.screensize;
            HDDTextLabel.Text = Program.product.HDD_size;
            CPUBrandTextLabel.Text = Program.product.CPU_brand;
            CPUNumberTextLabel.Text = Program.product.CPU_number;
            GPUTypeTextLabel.Text = Program.product.GPU_Type;
            CPUTypeTextLabel.Text = Program.product.CPU_type;
            CPUSpeedTextLabel.Text = Program.product.CPU_speed;
            WebcamTextLabel.Text = Program.product.webcam;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            ProductLoaded();
        }
    }
}

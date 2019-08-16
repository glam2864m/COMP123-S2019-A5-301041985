using COMP123_S2019_A5_301041985.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_301041985.Views
{
    public partial class SelectForm : Form
    {
        public string[] str;

        public SelectForm()
        {
            InitializeComponent();
        }

        public bool HasLoadedDataSource()
        {
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
                if (productBindingSource.DataSource != null)
                {
                    return true;
                }

                return false;
            }
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            if (!HasLoadedDataSource())
            {
                MessageBox.Show("DataSource Not Loaded", "ERROR", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            NextButton.Enabled = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            str = new string[ProductDataGridView.Rows.Count];
            for (int i = 0; i < ProductDataGridView.Rows.Count; i++)
            {
                if (ProductDataGridView.Rows[i].Selected == true)
                {
                    Program.product.productID = short.Parse(ProductDataGridView.Rows[i].Cells[0].Value.ToString());
                    Program.product.cost = decimal.Parse(ProductDataGridView.Rows[i].Cells[1].Value.ToString());
                    Program.product.manufacturer = ProductDataGridView.Rows[i].Cells[2].Value.ToString();
                    Program.product.model = ProductDataGridView.Rows[i].Cells[3].Value.ToString();
                    Program.product.RAM_type = ProductDataGridView.Rows[i].Cells[4].Value.ToString();
                    Program.product.RAM_size = ProductDataGridView.Rows[i].Cells[5].Value.ToString();
                    Program.product.displaytype = ProductDataGridView.Rows[i].Cells[6].Value.ToString();
                    Program.product.screensize = ProductDataGridView.Rows[i].Cells[7].Value.ToString();
                    Program.product.resolution = ProductDataGridView.Rows[i].Cells[8].Value.ToString();
                    Program.product.CPU_Class = ProductDataGridView.Rows[i].Cells[9].Value.ToString();
                    Program.product.CPU_brand = ProductDataGridView.Rows[i].Cells[10].Value.ToString();
                    Program.product.CPU_type = ProductDataGridView.Rows[i].Cells[11].Value.ToString();
                    Program.product.CPU_number = ProductDataGridView.Rows[i].Cells[12].Value.ToString();
                    Program.product.CPU_speed = ProductDataGridView.Rows[i].Cells[13].Value.ToString();
                    Program.product.condition = ProductDataGridView.Rows[i].Cells[14].Value.ToString();
                    Program.product.OS = ProductDataGridView.Rows[i].Cells[15].Value.ToString();
                    Program.product.platform = ProductDataGridView.Rows[i].Cells[16].Value.ToString();
                    Program.product.HDD_size = ProductDataGridView.Rows[i].Cells[17].Value.ToString();
                    Program.product.HDD_speed = ProductDataGridView.Rows[i].Cells[18].Value.ToString();
                    Program.product.GPU_Type = ProductDataGridView.Rows[i].Cells[19].Value.ToString();
                    Program.product.optical_drive = ProductDataGridView.Rows[i].Cells[20].Value.ToString();
                    Program.product.Audio_type = ProductDataGridView.Rows[i].Cells[21].Value.ToString();
                    Program.product.LAN = ProductDataGridView.Rows[i].Cells[22].Value.ToString();
                    Program.product.WIFI = ProductDataGridView.Rows[i].Cells[23].Value.ToString();
                    Program.product.width = ProductDataGridView.Rows[i].Cells[24].Value.ToString();
                    Program.product.height = ProductDataGridView.Rows[i].Cells[25].Value.ToString();
                    Program.product.depth = ProductDataGridView.Rows[i].Cells[26].Value.ToString();
                    Program.product.weight = ProductDataGridView.Rows[i].Cells[27].Value.ToString();
                    Program.product.moust_type = ProductDataGridView.Rows[i].Cells[28].Value.ToString();
                    Program.product.power = ProductDataGridView.Rows[i].Cells[29].Value.ToString();
                    Program.product.webcam = ProductDataGridView.Rows[i].Cells[30].Value.ToString();
                    str[i] = ProductDataGridView.CurrentRow.Index.ToString();

                    string outputString = Program.product.manufacturer + " " + Program.product.model + " " + Program.product.cost.Value.ToString("C2");

                    SelectionTextBox.Text = outputString;

                    NextButton.Enabled = true;
                }
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWindProductsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal productDal = new ProductDal();
        CategoryDal categoryDal = new CategoryDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgwProduct.DataSource = productDal.GetAll();
            cbxCategory.DataSource = categoryDal.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryID";

        }

        private void cbxCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = productDal.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {


            }
        }

        private void tbxSearch_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxSearch.Text))
            {
                dgwProduct.DataSource = productDal.GetAll();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgwProduct.DataSource = productDal.GetProductsByName(tbxSearch.Text, Convert.ToInt32(cbxCategory.SelectedValue));
        }
    }
}
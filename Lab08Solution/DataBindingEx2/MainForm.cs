using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingEx2
{
    public partial class MainForm : Form
    {
        private ProductViewModel productVM;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            productVM = new ProductViewModel();
            setBindings();
            setupDataGridView();
        }

        private void setBindings()
        {
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.DataSource = productVM.Products;
        }

        private void setupDataGridView()
        {        
            // configure for readonly 
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.MultiSelect = false;
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewProducts.AllowUserToOrderColumns = false;
            dataGridViewProducts.AllowUserToResizeColumns = false;
            dataGridViewProducts.AllowUserToResizeRows = false;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            // add columns

            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.Name = "id";
            id.DataPropertyName = "ProductId";
            id.HeaderText = "Id";
            id.Width = 40;
            id.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            id.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewProducts.Columns.Add(id);

            DataGridViewTextBoxColumn quantity = new DataGridViewTextBoxColumn();
            quantity.Name = "quantity";
            quantity.DataPropertyName = "Quantity";
            quantity.HeaderText = "Quantity";
            quantity.Width = 60;
            quantity.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            quantity.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            quantity.DefaultCellStyle.Format = "N0";
            id.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewProducts.Columns.Add(quantity);

            DataGridViewTextBoxColumn sku = new DataGridViewTextBoxColumn();
            sku.Name = "sku";
            sku.DataPropertyName = "Sku";
            sku.HeaderText = "Sku";
            sku.Width = 80;
            sku.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewProducts.Columns.Add(sku);

            DataGridViewTextBoxColumn desc = new DataGridViewTextBoxColumn();
            desc.Name = "desc";
            desc.DataPropertyName = "Description";
            desc.HeaderText = "Description";
            desc.Width = 150;
            desc.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewProducts.Columns.Add(desc);

            DataGridViewTextBoxColumn cost = new DataGridViewTextBoxColumn();
            cost.Name = "cost";
            cost.DataPropertyName = "Cost";
            cost.HeaderText = "Cost";
            cost.Width = 70;
            cost.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            cost.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            cost.DefaultCellStyle.Format = "N2";
            cost.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewProducts.Columns.Add(cost);

            DataGridViewTextBoxColumn extension = new DataGridViewTextBoxColumn();
            extension.Name = "extension";
            extension.DataPropertyName = "Extension";
            extension.HeaderText = "Extension";
            extension.Width = 80;
            extension.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            extension.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            extension.DefaultCellStyle.Format = "N2";
            extension.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewProducts.Columns.Add(extension);

            DataGridViewCheckBoxColumn tax = new DataGridViewCheckBoxColumn();
            tax.Name = "taxable";
            tax.DataPropertyName = "IsTaxable";
            tax.HeaderText = "Taxable";
            tax.Width = 60;
            tax.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewProducts.Columns.Add(tax);
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            int index = dataGridViewProducts.CurrentRow.Index;

            Product product = productVM.Products[index];
            productVM.SetDisplayProduct(product);          
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //int index = dataGridViewProducts.CurrentRow.Index;

            //Product product = productVM.GetDisplayProduct();
            //productVM.Products[index] = product;
            //productVM.Products.ResetItem(index);

   
        }

        private void ButtonEditRecord_Click(object sender, EventArgs e)
        {
            DialogEdit dialog = new DialogEdit();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int index = dataGridViewProducts.CurrentRow.Index;
                Product product = productVM.GetDisplayProduct();

                product.Description = dialog.Description;
                product.Quantity = dialog.Quantity;



                productVM.Products[index] = product;
                productVM.Products.ResetItem(index);
            }

            dialog.Dispose();
        }
    }
}

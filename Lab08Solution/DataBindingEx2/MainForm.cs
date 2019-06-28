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
            textBoxQuantity.DataBindings.Add("Text", productVM, "Product.Quantity",
                                              true, DataSourceUpdateMode.OnValidation,
                                             "0", "#,##0;(#,##0);0");

            textBoxSku.DataBindings.Add("Text", productVM, "Product.Sku", false, DataSourceUpdateMode.OnValidation, "");

            textBoxDescription.DataBindings.Add("Text", productVM, "Product.Description");

            textBoxCost.DataBindings.Add("Text", productVM, "Product.Cost", 
                                          true, DataSourceUpdateMode.OnValidation,
                                         "0.00", "#,##0.00;(#,##0.00);0.00");

            checkBoxTaxable.DataBindings.Add("Checked", productVM, "Product.IsTaxable");

            textBoxExtension.DataBindings.Add("Text", productVM, "Product.Extension",
                                               true, DataSourceUpdateMode.OnValidation,
                                              "0.00", "#,##0.00;(#,##0.00);0.00");

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

            labelProductLegend.Text = string.Empty;
            labelProductData.Text = string.Empty;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int index = dataGridViewProducts.CurrentRow.Index;

            Product product = productVM.GetDisplayProduct();
            productVM.Products[index] = product;
            productVM.Products.ResetItem(index);

            string outputLegend = string.Format("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n{5}\r\n{6}\r\n"
                                              , "ProdID:"
                                              , "Quantity:"
                                              , "SKU:"
                                              , "Desc:"
                                              , "Cost:"
                                              , "Extension:"
                                              , "Taxable:");


            string outputData = string.Format("{0}\r\n{1:N0}\r\n{2}\r\n{3:N2}\r\n{4:N2}\r\n{5:N2}\r\n{6}\r\n"
                                              , product.ProductId
                                              , product.Quantity
                                              , product.Sku
                                              , product.Description
                                              , product.Cost
                                              , product.Extension
                                              , product.IsTaxable);

            labelProductLegend.Text = outputLegend;
            labelProductData.Text = outputData;
        }
    }
}

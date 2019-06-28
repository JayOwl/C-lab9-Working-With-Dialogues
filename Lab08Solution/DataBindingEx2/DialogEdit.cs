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
    public partial class DialogEdit : Form
    {
        private ProductViewModel productVM;
        public DialogEdit()
        {
            InitializeComponent();
        }

        private void DialogEdit_Load(object sender, EventArgs e)
        {
            setBindings2();
        }

        private void setBindings2()
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

            //dataGridViewProducts.AutoGenerateColumns = false;
            //dataGridViewProducts.DataSource = productVM.Products;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //int index = dataGridViewProducts.CurrentRow.Index;

            Product product = productVM.GetDisplayProduct();
            //productVM.Products[index] = product;
            //productVM.Products.ResetItem(index);

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
        }

  
    }
}

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
    public partial class EditDialog : Form
    {
        public Product Product { get; set; }

        public EditDialog()
        {
            InitializeComponent();
        }

        private void EditDialog_Load(object sender, EventArgs e)
        {
     
            textBoxDescription.DataBindings.Add("Text", Product, "Description");

            textBoxQuantity.DataBindings.Add("Text", Product, "Quantity",
                                    true, DataSourceUpdateMode.OnValidation,
                                   "0", "#,##0;(#,##0);0");

            textBoxSku.DataBindings.Add("Text", Product, "Sku", false, DataSourceUpdateMode.OnValidation, "");          

            textBoxCost.DataBindings.Add("Text", Product, "Cost",
                                          true, DataSourceUpdateMode.OnValidation,
                                         "0.00", "#,##0.00;(#,##0.00);0.00");

            checkBoxTaxable.DataBindings.Add("Checked", Product, "IsTaxable");

            textBoxExtension.DataBindings.Add("Text", Product, "Extension",
                                               true, DataSourceUpdateMode.OnValidation,
                                              "0.00", "#,##0.00;(#,##0.00);0.00");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBoxDescription.Text.Length > 2)
            {      
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Something Terrrible has Happened");
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

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
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string Sku { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public bool IsTaxable { get; set; }
        //public decimal Extension
        //{
        //    get { return Quantity * Cost; }
        //}

        // public ind

        public DialogEdit()
        {
            InitializeComponent();
        }

        private void DialogEdit_Load(object sender, EventArgs e)
        {
           // string StringQuantity = string(Quantity);
            
            textBoxQuantity.Text = Quantity.ToString();
            textBoxSku.Text = Description;
            textBoxDescription.Text = Description;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (textBoxDescription.Text.Length > 2)
            {
                Quantity = Int32.Parse(textBoxQuantity.Text);
                Sku = textBoxSku.Text;

                Description = textBoxDescription.Text;
             
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Something Terrrible has Happened");
            }
        }
    }
}

namespace DataBindingEx2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.labelCostPrompt = new System.Windows.Forms.Label();
            this.labelDescriptionPrompt = new System.Windows.Forms.Label();
            this.labelSkuPrompt = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxSku = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.checkBoxTaxable = new System.Windows.Forms.CheckBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.labelProductData = new System.Windows.Forms.Label();
            this.labelProductLegend = new System.Windows.Forms.Label();
            this.labelGrid = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.labelQuantityPrompt = new System.Windows.Forms.Label();
            this.labelExtensionPrompt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(36, 257);
            this.dataGridViewProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(777, 332);
            this.dataGridViewProducts.TabIndex = 1;
            this.dataGridViewProducts.SelectionChanged += new System.EventHandler(this.dataGridViewProducts_SelectionChanged);
            // 
            // labelCostPrompt
            // 
            this.labelCostPrompt.AutoSize = true;
            this.labelCostPrompt.Location = new System.Drawing.Point(32, 128);
            this.labelCostPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCostPrompt.Name = "labelCostPrompt";
            this.labelCostPrompt.Size = new System.Drawing.Size(40, 17);
            this.labelCostPrompt.TabIndex = 8;
            this.labelCostPrompt.Text = "&Cost:";
            // 
            // labelDescriptionPrompt
            // 
            this.labelDescriptionPrompt.AutoSize = true;
            this.labelDescriptionPrompt.Location = new System.Drawing.Point(32, 90);
            this.labelDescriptionPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescriptionPrompt.Name = "labelDescriptionPrompt";
            this.labelDescriptionPrompt.Size = new System.Drawing.Size(83, 17);
            this.labelDescriptionPrompt.TabIndex = 6;
            this.labelDescriptionPrompt.Text = "&Description:";
            // 
            // labelSkuPrompt
            // 
            this.labelSkuPrompt.AutoSize = true;
            this.labelSkuPrompt.Location = new System.Drawing.Point(32, 52);
            this.labelSkuPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSkuPrompt.Name = "labelSkuPrompt";
            this.labelSkuPrompt.Size = new System.Drawing.Size(40, 17);
            this.labelSkuPrompt.TabIndex = 4;
            this.labelSkuPrompt.Text = "&SKU:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(255, 207);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 28);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Sa&ve";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxSku
            // 
            this.textBoxSku.Location = new System.Drawing.Point(124, 48);
            this.textBoxSku.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSku.Name = "textBoxSku";
            this.textBoxSku.Size = new System.Drawing.Size(132, 22);
            this.textBoxSku.TabIndex = 5;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(124, 86);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(229, 22);
            this.textBoxDescription.TabIndex = 7;
            // 
            // checkBoxTaxable
            // 
            this.checkBoxTaxable.AutoSize = true;
            this.checkBoxTaxable.Location = new System.Drawing.Point(124, 212);
            this.checkBoxTaxable.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxTaxable.Name = "checkBoxTaxable";
            this.checkBoxTaxable.Size = new System.Drawing.Size(80, 21);
            this.checkBoxTaxable.TabIndex = 10;
            this.checkBoxTaxable.Text = "&Taxable";
            this.checkBoxTaxable.UseVisualStyleBackColor = true;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(124, 124);
            this.textBoxCost.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(132, 22);
            this.textBoxCost.TabIndex = 9;
            this.textBoxCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelProductData
            // 
            this.labelProductData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductData.Location = new System.Drawing.Point(600, 10);
            this.labelProductData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductData.Name = "labelProductData";
            this.labelProductData.Size = new System.Drawing.Size(213, 148);
            this.labelProductData.TabIndex = 13;
            this.labelProductData.Text = "One\r\nTwo\r\nThree\r\nFour\r\nFive\r\nSix\r\nSeven";
            // 
            // labelProductLegend
            // 
            this.labelProductLegend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductLegend.Location = new System.Drawing.Point(481, 10);
            this.labelProductLegend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductLegend.Name = "labelProductLegend";
            this.labelProductLegend.Size = new System.Drawing.Size(111, 148);
            this.labelProductLegend.TabIndex = 12;
            this.labelProductLegend.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7";
            // 
            // labelGrid
            // 
            this.labelGrid.AutoSize = true;
            this.labelGrid.Location = new System.Drawing.Point(439, 326);
            this.labelGrid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGrid.Name = "labelGrid";
            this.labelGrid.Size = new System.Drawing.Size(65, 17);
            this.labelGrid.TabIndex = 0;
            this.labelGrid.Text = "Data&Grid";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(124, 10);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 22);
            this.textBoxQuantity.TabIndex = 3;
            this.textBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxExtension.Location = new System.Drawing.Point(124, 162);
            this.textBoxExtension.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.ReadOnly = true;
            this.textBoxExtension.Size = new System.Drawing.Size(132, 22);
            this.textBoxExtension.TabIndex = 15;
            this.textBoxExtension.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelQuantityPrompt
            // 
            this.labelQuantityPrompt.AutoSize = true;
            this.labelQuantityPrompt.Location = new System.Drawing.Point(32, 14);
            this.labelQuantityPrompt.Name = "labelQuantityPrompt";
            this.labelQuantityPrompt.Size = new System.Drawing.Size(65, 17);
            this.labelQuantityPrompt.TabIndex = 2;
            this.labelQuantityPrompt.Text = "&Quantity:";
            // 
            // labelExtensionPrompt
            // 
            this.labelExtensionPrompt.AutoSize = true;
            this.labelExtensionPrompt.Location = new System.Drawing.Point(32, 166);
            this.labelExtensionPrompt.Name = "labelExtensionPrompt";
            this.labelExtensionPrompt.Size = new System.Drawing.Size(73, 17);
            this.labelExtensionPrompt.TabIndex = 14;
            this.labelExtensionPrompt.Text = "Extension:";
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 614);
            this.Controls.Add(this.labelExtensionPrompt);
            this.Controls.Add(this.labelQuantityPrompt);
            this.Controls.Add(this.textBoxExtension);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.labelProductData);
            this.Controls.Add(this.labelProductLegend);
            this.Controls.Add(this.labelCostPrompt);
            this.Controls.Add(this.labelDescriptionPrompt);
            this.Controls.Add(this.labelSkuPrompt);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSku);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.checkBoxTaxable);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.labelGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Binding Example 2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Label labelCostPrompt;
        private System.Windows.Forms.Label labelDescriptionPrompt;
        private System.Windows.Forms.Label labelSkuPrompt;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxSku;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.CheckBox checkBoxTaxable;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label labelProductData;
        private System.Windows.Forms.Label labelProductLegend;
        private System.Windows.Forms.Label labelGrid;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.Label labelQuantityPrompt;
        private System.Windows.Forms.Label labelExtensionPrompt;
    }
}


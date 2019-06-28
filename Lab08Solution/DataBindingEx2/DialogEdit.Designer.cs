namespace DataBindingEx2
{
    partial class DialogEdit
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
            this.labelExtensionPrompt = new System.Windows.Forms.Label();
            this.labelQuantityPrompt = new System.Windows.Forms.Label();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelCostPrompt = new System.Windows.Forms.Label();
            this.labelDescriptionPrompt = new System.Windows.Forms.Label();
            this.labelSkuPrompt = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxSku = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.checkBoxTaxable = new System.Windows.Forms.CheckBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelExtensionPrompt
            // 
            this.labelExtensionPrompt.AutoSize = true;
            this.labelExtensionPrompt.Location = new System.Drawing.Point(107, 261);
            this.labelExtensionPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExtensionPrompt.Name = "labelExtensionPrompt";
            this.labelExtensionPrompt.Size = new System.Drawing.Size(56, 13);
            this.labelExtensionPrompt.TabIndex = 28;
            this.labelExtensionPrompt.Text = "Extension:";
            // 
            // labelQuantityPrompt
            // 
            this.labelQuantityPrompt.AutoSize = true;
            this.labelQuantityPrompt.Location = new System.Drawing.Point(107, 137);
            this.labelQuantityPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuantityPrompt.Name = "labelQuantityPrompt";
            this.labelQuantityPrompt.Size = new System.Drawing.Size(49, 13);
            this.labelQuantityPrompt.TabIndex = 16;
            this.labelQuantityPrompt.Text = "&Quantity:";
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxExtension.Location = new System.Drawing.Point(176, 258);
            this.textBoxExtension.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.ReadOnly = true;
            this.textBoxExtension.Size = new System.Drawing.Size(100, 20);
            this.textBoxExtension.TabIndex = 29;
            this.textBoxExtension.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(176, 134);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(76, 20);
            this.textBoxQuantity.TabIndex = 17;
            this.textBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCostPrompt
            // 
            this.labelCostPrompt.AutoSize = true;
            this.labelCostPrompt.Location = new System.Drawing.Point(107, 230);
            this.labelCostPrompt.Name = "labelCostPrompt";
            this.labelCostPrompt.Size = new System.Drawing.Size(31, 13);
            this.labelCostPrompt.TabIndex = 22;
            this.labelCostPrompt.Text = "&Cost:";
            // 
            // labelDescriptionPrompt
            // 
            this.labelDescriptionPrompt.AutoSize = true;
            this.labelDescriptionPrompt.Location = new System.Drawing.Point(107, 199);
            this.labelDescriptionPrompt.Name = "labelDescriptionPrompt";
            this.labelDescriptionPrompt.Size = new System.Drawing.Size(63, 13);
            this.labelDescriptionPrompt.TabIndex = 20;
            this.labelDescriptionPrompt.Text = "&Description:";
            // 
            // labelSkuPrompt
            // 
            this.labelSkuPrompt.AutoSize = true;
            this.labelSkuPrompt.Location = new System.Drawing.Point(107, 168);
            this.labelSkuPrompt.Name = "labelSkuPrompt";
            this.labelSkuPrompt.Size = new System.Drawing.Size(32, 13);
            this.labelSkuPrompt.TabIndex = 18;
            this.labelSkuPrompt.Text = "&SKU:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(274, 294);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 25;
            this.buttonSave.Text = "Sa&ve";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBoxSku
            // 
            this.textBoxSku.Location = new System.Drawing.Point(176, 165);
            this.textBoxSku.Name = "textBoxSku";
            this.textBoxSku.Size = new System.Drawing.Size(100, 20);
            this.textBoxSku.TabIndex = 19;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(176, 196);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(173, 20);
            this.textBoxDescription.TabIndex = 21;
            // 
            // checkBoxTaxable
            // 
            this.checkBoxTaxable.AutoSize = true;
            this.checkBoxTaxable.Location = new System.Drawing.Point(176, 298);
            this.checkBoxTaxable.Name = "checkBoxTaxable";
            this.checkBoxTaxable.Size = new System.Drawing.Size(64, 17);
            this.checkBoxTaxable.TabIndex = 24;
            this.checkBoxTaxable.Text = "&Taxable";
            this.checkBoxTaxable.UseVisualStyleBackColor = true;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(176, 227);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost.TabIndex = 23;
            this.textBoxCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DialogEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelExtensionPrompt);
            this.Controls.Add(this.labelQuantityPrompt);
            this.Controls.Add(this.textBoxExtension);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelCostPrompt);
            this.Controls.Add(this.labelDescriptionPrompt);
            this.Controls.Add(this.labelSkuPrompt);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSku);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.checkBoxTaxable);
            this.Controls.Add(this.textBoxCost);
            this.Name = "DialogEdit";
            this.Text = "Product Edit Dialog";
            this.Load += new System.EventHandler(this.DialogEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExtensionPrompt;
        private System.Windows.Forms.Label labelQuantityPrompt;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelCostPrompt;
        private System.Windows.Forms.Label labelDescriptionPrompt;
        private System.Windows.Forms.Label labelSkuPrompt;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxSku;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.CheckBox checkBoxTaxable;
        private System.Windows.Forms.TextBox textBoxCost;
    }
}
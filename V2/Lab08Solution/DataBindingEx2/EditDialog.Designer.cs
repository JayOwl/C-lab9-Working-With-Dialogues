namespace DataBindingEx2
{
    partial class EditDialog
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelExtensionPrompt = new System.Windows.Forms.Label();
            this.labelQuantityPrompt = new System.Windows.Forms.Label();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelCostPrompt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSkuPrompt = new System.Windows.Forms.Label();
            this.textBoxSku = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.checkBoxTaxable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(101, 216);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 11;
            this.buttonOk.Text = "&Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(182, 216);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // labelExtensionPrompt
            // 
            this.labelExtensionPrompt.AutoSize = true;
            this.labelExtensionPrompt.Location = new System.Drawing.Point(15, 153);
            this.labelExtensionPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExtensionPrompt.Name = "labelExtensionPrompt";
            this.labelExtensionPrompt.Size = new System.Drawing.Size(56, 13);
            this.labelExtensionPrompt.TabIndex = 8;
            this.labelExtensionPrompt.Text = "&Extension:";
            // 
            // labelQuantityPrompt
            // 
            this.labelQuantityPrompt.AutoSize = true;
            this.labelQuantityPrompt.Location = new System.Drawing.Point(15, 29);
            this.labelQuantityPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuantityPrompt.Name = "labelQuantityPrompt";
            this.labelQuantityPrompt.Size = new System.Drawing.Size(49, 13);
            this.labelQuantityPrompt.TabIndex = 0;
            this.labelQuantityPrompt.Text = "&Quantity:";
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxExtension.Location = new System.Drawing.Point(84, 150);
            this.textBoxExtension.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.ReadOnly = true;
            this.textBoxExtension.Size = new System.Drawing.Size(100, 20);
            this.textBoxExtension.TabIndex = 9;
            this.textBoxExtension.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(84, 26);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(76, 20);
            this.textBoxQuantity.TabIndex = 1;
            this.textBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCostPrompt
            // 
            this.labelCostPrompt.AutoSize = true;
            this.labelCostPrompt.Location = new System.Drawing.Point(15, 122);
            this.labelCostPrompt.Name = "labelCostPrompt";
            this.labelCostPrompt.Size = new System.Drawing.Size(31, 13);
            this.labelCostPrompt.TabIndex = 6;
            this.labelCostPrompt.Text = "&Cost:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "&Description:";
            // 
            // labelSkuPrompt
            // 
            this.labelSkuPrompt.AutoSize = true;
            this.labelSkuPrompt.Location = new System.Drawing.Point(15, 60);
            this.labelSkuPrompt.Name = "labelSkuPrompt";
            this.labelSkuPrompt.Size = new System.Drawing.Size(32, 13);
            this.labelSkuPrompt.TabIndex = 2;
            this.labelSkuPrompt.Text = "&SKU:";
            // 
            // textBoxSku
            // 
            this.textBoxSku.Location = new System.Drawing.Point(84, 57);
            this.textBoxSku.Name = "textBoxSku";
            this.textBoxSku.Size = new System.Drawing.Size(100, 20);
            this.textBoxSku.TabIndex = 3;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(84, 88);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(173, 20);
            this.textBoxDescription.TabIndex = 5;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(84, 119);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost.TabIndex = 7;
            this.textBoxCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBoxTaxable
            // 
            this.checkBoxTaxable.AutoSize = true;
            this.checkBoxTaxable.Location = new System.Drawing.Point(84, 187);
            this.checkBoxTaxable.Name = "checkBoxTaxable";
            this.checkBoxTaxable.Size = new System.Drawing.Size(64, 17);
            this.checkBoxTaxable.TabIndex = 10;
            this.checkBoxTaxable.Text = "&Taxable";
            this.checkBoxTaxable.UseVisualStyleBackColor = true;
            // 
            // EditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 254);
            this.Controls.Add(this.checkBoxTaxable);
            this.Controls.Add(this.labelExtensionPrompt);
            this.Controls.Add(this.labelQuantityPrompt);
            this.Controls.Add(this.textBoxExtension);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelCostPrompt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSkuPrompt);
            this.Controls.Add(this.textBoxSku);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Edit Dialog";
            this.Load += new System.EventHandler(this.EditDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelExtensionPrompt;
        private System.Windows.Forms.Label labelQuantityPrompt;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelCostPrompt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSkuPrompt;
        private System.Windows.Forms.TextBox textBoxSku;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.CheckBox checkBoxTaxable;
    }
}
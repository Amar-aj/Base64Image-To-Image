namespace WinFormsAppImageDbToFolder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnBrand = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnCompany = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnProductPictureMapping = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(55, 234);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(94, 29);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnBrand
            // 
            this.btnBrand.Location = new System.Drawing.Point(55, 29);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Size = new System.Drawing.Size(94, 29);
            this.btnBrand.TabIndex = 0;
            this.btnBrand.Text = "Brand";
            this.btnBrand.UseVisualStyleBackColor = true;
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(55, 81);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(94, 29);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnCompany
            // 
            this.btnCompany.Location = new System.Drawing.Point(55, 134);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(94, 29);
            this.btnCompany.TabIndex = 0;
            this.btnCompany.Text = "Company";
            this.btnCompany.UseVisualStyleBackColor = true;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(55, 187);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(94, 29);
            this.btnPayment.TabIndex = 0;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnProductPictureMapping
            // 
            this.btnProductPictureMapping.Location = new System.Drawing.Point(55, 287);
            this.btnProductPictureMapping.Name = "btnProductPictureMapping";
            this.btnProductPictureMapping.Size = new System.Drawing.Size(94, 29);
            this.btnProductPictureMapping.TabIndex = 0;
            this.btnProductPictureMapping.Text = "ProductPictureMapping";
            this.btnProductPictureMapping.UseVisualStyleBackColor = true;
            this.btnProductPictureMapping.Click += new System.EventHandler(this.btnProductPictureMapping_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 455);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnCompany);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnBrand);
            this.Controls.Add(this.btnProductPictureMapping);
            this.Controls.Add(this.btnProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnProduct;
        private Button btnBrand;
        private Button btnCategory;
        private Button btnCompany;
        private Button btnPayment;
        private Button btnProductPictureMapping;
    }
}
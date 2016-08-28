namespace ConsignmentCalculatorDemo
{
    partial class ConsignmentUI
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
            this.textHeader = new System.Windows.Forms.Label();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.shoppingItemsLabel = new System.Windows.Forms.Label();
            this.shoppingCartLabel = new System.Windows.Forms.Label();
            this.shoppingCartListBox = new System.Windows.Forms.ListBox();
            this.addToCart = new System.Windows.Forms.Button();
            this.purchase = new System.Windows.Forms.Button();
            this.vendors = new System.Windows.Forms.Label();
            this.vendorsListbox = new System.Windows.Forms.ListBox();
            this.storePay = new System.Windows.Forms.Label();
            this.storePayText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textHeader
            // 
            this.textHeader.AutoSize = true;
            this.textHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHeader.Location = new System.Drawing.Point(0, 0);
            this.textHeader.Name = "textHeader";
            this.textHeader.Size = new System.Drawing.Size(341, 32);
            this.textHeader.TabIndex = 0;
            this.textHeader.Text = "Consignment Calculator";
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.ItemHeight = 29;
            this.itemListBox.Location = new System.Drawing.Point(12, 108);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(266, 178);
            this.itemListBox.TabIndex = 1;
            // 
            // shoppingItemsLabel
            // 
            this.shoppingItemsLabel.AutoSize = true;
            this.shoppingItemsLabel.Location = new System.Drawing.Point(12, 66);
            this.shoppingItemsLabel.Name = "shoppingItemsLabel";
            this.shoppingItemsLabel.Size = new System.Drawing.Size(181, 29);
            this.shoppingItemsLabel.TabIndex = 2;
            this.shoppingItemsLabel.Text = "Shopping Items";
            // 
            // shoppingCartLabel
            // 
            this.shoppingCartLabel.AutoSize = true;
            this.shoppingCartLabel.Location = new System.Drawing.Point(614, 66);
            this.shoppingCartLabel.Name = "shoppingCartLabel";
            this.shoppingCartLabel.Size = new System.Drawing.Size(167, 29);
            this.shoppingCartLabel.TabIndex = 4;
            this.shoppingCartLabel.Text = "Shopping Cart";
            // 
            // shoppingCartListBox
            // 
            this.shoppingCartListBox.FormattingEnabled = true;
            this.shoppingCartListBox.ItemHeight = 29;
            this.shoppingCartListBox.Location = new System.Drawing.Point(603, 108);
            this.shoppingCartListBox.Name = "shoppingCartListBox";
            this.shoppingCartListBox.Size = new System.Drawing.Size(266, 178);
            this.shoppingCartListBox.TabIndex = 3;
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(340, 173);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(182, 56);
            this.addToCart.TabIndex = 5;
            this.addToCart.Text = "Add to Cart";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // purchase
            // 
            this.purchase.Location = new System.Drawing.Point(619, 308);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(148, 50);
            this.purchase.TabIndex = 6;
            this.purchase.Text = "Purchase";
            this.purchase.UseVisualStyleBackColor = true;
            this.purchase.Click += new System.EventHandler(this.purchase_Click);
            // 
            // vendors
            // 
            this.vendors.AutoSize = true;
            this.vendors.Location = new System.Drawing.Point(12, 329);
            this.vendors.Name = "vendors";
            this.vendors.Size = new System.Drawing.Size(103, 29);
            this.vendors.TabIndex = 8;
            this.vendors.Text = "Vendors";
            // 
            // vendorsListbox
            // 
            this.vendorsListbox.FormattingEnabled = true;
            this.vendorsListbox.ItemHeight = 29;
            this.vendorsListbox.Location = new System.Drawing.Point(12, 372);
            this.vendorsListbox.Name = "vendorsListbox";
            this.vendorsListbox.Size = new System.Drawing.Size(266, 178);
            this.vendorsListbox.TabIndex = 7;
            // 
            // storePay
            // 
            this.storePay.AutoSize = true;
            this.storePay.Location = new System.Drawing.Point(480, 410);
            this.storePay.Name = "storePay";
            this.storePay.Size = new System.Drawing.Size(139, 29);
            this.storePay.TabIndex = 9;
            this.storePay.Text = "Store Profit:";
            // 
            // storePayText
            // 
            this.storePayText.AutoSize = true;
            this.storePayText.Location = new System.Drawing.Point(625, 410);
            this.storePayText.Name = "storePayText";
            this.storePayText.Size = new System.Drawing.Size(71, 29);
            this.storePayText.TabIndex = 10;
            this.storePayText.Text = "$0.00";
            this.storePayText.Click += new System.EventHandler(this.storePayText_Click);
            // 
            // ConsignmentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 576);
            this.Controls.Add(this.storePayText);
            this.Controls.Add(this.storePay);
            this.Controls.Add(this.vendors);
            this.Controls.Add(this.vendorsListbox);
            this.Controls.Add(this.purchase);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.shoppingCartLabel);
            this.Controls.Add(this.shoppingCartListBox);
            this.Controls.Add(this.shoppingItemsLabel);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.textHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ConsignmentUI";
            this.Text = "Consignment Calculator Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textHeader;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.Label shoppingItemsLabel;
        private System.Windows.Forms.Label shoppingCartLabel;
        private System.Windows.Forms.ListBox shoppingCartListBox;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Button purchase;
        private System.Windows.Forms.Label vendors;
        private System.Windows.Forms.ListBox vendorsListbox;
        private System.Windows.Forms.Label storePay;
        private System.Windows.Forms.Label storePayText;
    }
}


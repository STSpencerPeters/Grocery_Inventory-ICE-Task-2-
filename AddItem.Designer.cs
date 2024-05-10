namespace Grocery_Inventory
{
    partial class AddItem
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
			lblAddItem = new Label();
			lblName = new Label();
			lblItemPrice = new Label();
			lblQuantity = new Label();
			lblCategory = new Label();
			txbName = new TextBox();
			txbPrice = new TextBox();
			txbQuantity = new TextBox();
			txbCategory = new TextBox();
			bttnAddItem = new Button();
			lblErrorName = new Label();
			lblErrorPrice = new Label();
			lblErrorQuantity = new Label();
			lblErrorCategory = new Label();
			bttnReturn = new Button();
			SuspendLayout();
			// 
			// lblAddItem
			// 
			lblAddItem.AutoSize = true;
			lblAddItem.Font = new Font("Segoe UI", 30F);
			lblAddItem.Location = new Point(282, 41);
			lblAddItem.Name = "lblAddItem";
			lblAddItem.Size = new Size(188, 54);
			lblAddItem.TabIndex = 0;
			lblAddItem.Text = "Add Item";
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Font = new Font("Segoe UI", 15F);
			lblName.Location = new Point(79, 138);
			lblName.Name = "lblName";
			lblName.Size = new Size(112, 28);
			lblName.TabIndex = 1;
			lblName.Text = "Item Name:";
			// 
			// lblItemPrice
			// 
			lblItemPrice.AutoSize = true;
			lblItemPrice.Font = new Font("Segoe UI", 15F);
			lblItemPrice.Location = new Point(79, 217);
			lblItemPrice.Name = "lblItemPrice";
			lblItemPrice.Size = new Size(102, 28);
			lblItemPrice.TabIndex = 2;
			lblItemPrice.Text = "Item Price:";
			// 
			// lblQuantity
			// 
			lblQuantity.AutoSize = true;
			lblQuantity.Font = new Font("Segoe UI", 15F);
			lblQuantity.Location = new Point(79, 284);
			lblQuantity.Name = "lblQuantity";
			lblQuantity.Size = new Size(136, 28);
			lblQuantity.TabIndex = 3;
			lblQuantity.Text = "Item Quantity:";
			// 
			// lblCategory
			// 
			lblCategory.AutoSize = true;
			lblCategory.Font = new Font("Segoe UI", 15F);
			lblCategory.Location = new Point(79, 359);
			lblCategory.Name = "lblCategory";
			lblCategory.Size = new Size(140, 28);
			lblCategory.TabIndex = 4;
			lblCategory.Text = "Item Category:";
			// 
			// txbName
			// 
			txbName.Location = new Point(322, 145);
			txbName.Margin = new Padding(3, 2, 3, 2);
			txbName.Name = "txbName";
			txbName.Size = new Size(110, 23);
			txbName.TabIndex = 5;
			// 
			// txbPrice
			// 
			txbPrice.Location = new Point(322, 223);
			txbPrice.Margin = new Padding(3, 2, 3, 2);
			txbPrice.Name = "txbPrice";
			txbPrice.Size = new Size(110, 23);
			txbPrice.TabIndex = 6;
			// 
			// txbQuantity
			// 
			txbQuantity.Location = new Point(322, 291);
			txbQuantity.Margin = new Padding(3, 2, 3, 2);
			txbQuantity.Name = "txbQuantity";
			txbQuantity.Size = new Size(110, 23);
			txbQuantity.TabIndex = 7;
			// 
			// txbCategory
			// 
			txbCategory.Location = new Point(322, 366);
			txbCategory.Margin = new Padding(3, 2, 3, 2);
			txbCategory.Name = "txbCategory";
			txbCategory.Size = new Size(110, 23);
			txbCategory.TabIndex = 8;
			// 
			// bttnAddItem
			// 
			bttnAddItem.Font = new Font("Segoe UI", 20F);
			bttnAddItem.Location = new Point(238, 420);
			bttnAddItem.Margin = new Padding(3, 2, 3, 2);
			bttnAddItem.Name = "bttnAddItem";
			bttnAddItem.Size = new Size(193, 54);
			bttnAddItem.TabIndex = 9;
			bttnAddItem.Text = "Add Item";
			bttnAddItem.UseVisualStyleBackColor = true;
			bttnAddItem.Click += bttnAddItem_Click;
			// 
			// lblErrorName
			// 
			lblErrorName.AutoSize = true;
			lblErrorName.Location = new Point(563, 147);
			lblErrorName.Name = "lblErrorName";
			lblErrorName.Size = new Size(0, 15);
			lblErrorName.TabIndex = 10;
			// 
			// lblErrorPrice
			// 
			lblErrorPrice.AutoSize = true;
			lblErrorPrice.Location = new Point(563, 225);
			lblErrorPrice.Name = "lblErrorPrice";
			lblErrorPrice.Size = new Size(0, 15);
			lblErrorPrice.TabIndex = 11;
			// 
			// lblErrorQuantity
			// 
			lblErrorQuantity.AutoSize = true;
			lblErrorQuantity.Location = new Point(563, 296);
			lblErrorQuantity.Name = "lblErrorQuantity";
			lblErrorQuantity.Size = new Size(0, 15);
			lblErrorQuantity.TabIndex = 12;
			// 
			// lblErrorCategory
			// 
			lblErrorCategory.AutoSize = true;
			lblErrorCategory.Location = new Point(563, 366);
			lblErrorCategory.Name = "lblErrorCategory";
			lblErrorCategory.Size = new Size(0, 15);
			lblErrorCategory.TabIndex = 13;
			// 
			// bttnReturn
			// 
			bttnReturn.Font = new Font("Segoe UI", 20F);
			bttnReturn.Location = new Point(485, 420);
			bttnReturn.Margin = new Padding(3, 2, 3, 2);
			bttnReturn.Name = "bttnReturn";
			bttnReturn.Size = new Size(266, 54);
			bttnReturn.TabIndex = 14;
			bttnReturn.Text = "Return To Previous";
			bttnReturn.UseVisualStyleBackColor = true;
			bttnReturn.Click += bttnReturn_Click;
			// 
			// AddItem
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(884, 514);
			Controls.Add(bttnReturn);
			Controls.Add(lblErrorCategory);
			Controls.Add(lblErrorQuantity);
			Controls.Add(lblErrorPrice);
			Controls.Add(lblErrorName);
			Controls.Add(bttnAddItem);
			Controls.Add(txbCategory);
			Controls.Add(txbQuantity);
			Controls.Add(txbPrice);
			Controls.Add(txbName);
			Controls.Add(lblCategory);
			Controls.Add(lblQuantity);
			Controls.Add(lblItemPrice);
			Controls.Add(lblName);
			Controls.Add(lblAddItem);
			Margin = new Padding(3, 2, 3, 2);
			Name = "AddItem";
			Text = "AddItem";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblAddItem;
        private Label lblName;
        private Label lblItemPrice;
        private Label lblQuantity;
        private Label lblCategory;
        private TextBox txbName;
        private TextBox txbPrice;
        private TextBox txbQuantity;
        private TextBox txbCategory;
        private Button bttnAddItem;
        private Label lblErrorName;
        private Label lblErrorPrice;
        private Label lblErrorQuantity;
        private Label lblErrorCategory;
		private Button bttnReturn;
	}
}
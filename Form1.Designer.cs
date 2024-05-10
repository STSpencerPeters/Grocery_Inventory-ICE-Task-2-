namespace Grocery_Inventory
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
			lblHeading = new Label();
			bttnAddItem = new Button();
			bttnRemoveItem = new Button();
			bttnDisplayInformation = new Button();
			bttnClose = new Button();
			SuspendLayout();
			// 
			// lblHeading
			// 
			lblHeading.AutoSize = true;
			lblHeading.Font = new Font("Segoe UI", 30F);
			lblHeading.Location = new Point(172, 22);
			lblHeading.Name = "lblHeading";
			lblHeading.Size = new Size(337, 54);
			lblHeading.TabIndex = 0;
			lblHeading.Text = "Grocery Inventory";
			lblHeading.Click += label1_Click;
			// 
			// bttnAddItem
			// 
			bttnAddItem.Font = new Font("Segoe UI", 20F);
			bttnAddItem.Location = new Point(256, 107);
			bttnAddItem.Margin = new Padding(3, 2, 3, 2);
			bttnAddItem.Name = "bttnAddItem";
			bttnAddItem.Size = new Size(197, 55);
			bttnAddItem.TabIndex = 1;
			bttnAddItem.Text = "Add Item";
			bttnAddItem.UseVisualStyleBackColor = true;
			bttnAddItem.Click += bttnAddItem_Click;
			// 
			// bttnRemoveItem
			// 
			bttnRemoveItem.Font = new Font("Segoe UI", 20F);
			bttnRemoveItem.Location = new Point(256, 190);
			bttnRemoveItem.Margin = new Padding(3, 2, 3, 2);
			bttnRemoveItem.Name = "bttnRemoveItem";
			bttnRemoveItem.Size = new Size(197, 55);
			bttnRemoveItem.TabIndex = 2;
			bttnRemoveItem.Text = "Remove Item";
			bttnRemoveItem.UseVisualStyleBackColor = true;
			bttnRemoveItem.Click += bttnRemoveItem_Click;
			// 
			// bttnDisplayInformation
			// 
			bttnDisplayInformation.Font = new Font("Segoe UI", 20F);
			bttnDisplayInformation.Location = new Point(256, 277);
			bttnDisplayInformation.Name = "bttnDisplayInformation";
			bttnDisplayInformation.Size = new Size(197, 55);
			bttnDisplayInformation.TabIndex = 3;
			bttnDisplayInformation.Text = "Display";
			bttnDisplayInformation.UseVisualStyleBackColor = true;
			bttnDisplayInformation.Click += bttnDisplayInformation_Click;
			// 
			// bttnClose
			// 
			bttnClose.Font = new Font("Segoe UI", 15F);
			bttnClose.Location = new Point(292, 373);
			bttnClose.Name = "bttnClose";
			bttnClose.Size = new Size(122, 46);
			bttnClose.TabIndex = 4;
			bttnClose.Text = "Close";
			bttnClose.UseVisualStyleBackColor = true;
			bttnClose.Click += bttnClose_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(769, 532);
			Controls.Add(bttnClose);
			Controls.Add(bttnDisplayInformation);
			Controls.Add(bttnRemoveItem);
			Controls.Add(bttnAddItem);
			Controls.Add(lblHeading);
			Margin = new Padding(3, 2, 3, 2);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblHeading;
        private Button bttnAddItem;
		private Button bttnRemoveItem;
		private Button bttnDisplay;
		private Button bttnDisplayInformation;
		private Button bttnClose;
	}
}

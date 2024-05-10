namespace Grocery_Inventory
{
	partial class RemoveItem
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
			lblHeading = new Label();
			lblItemName = new Label();
			txbItemName = new TextBox();
			bttnRemoveItem = new Button();
			lblErrorMessage = new Label();
			bttnReturn = new Button();
			lblRemoval = new Label();
			SuspendLayout();
			// 
			// lblHeading
			// 
			lblHeading.AutoSize = true;
			lblHeading.Font = new Font("Segoe UI", 30F);
			lblHeading.Location = new Point(233, 34);
			lblHeading.Name = "lblHeading";
			lblHeading.Size = new Size(232, 54);
			lblHeading.TabIndex = 0;
			lblHeading.Text = "Remve Item";
			// 
			// lblItemName
			// 
			lblItemName.AutoSize = true;
			lblItemName.Font = new Font("Segoe UI", 15F);
			lblItemName.Location = new Point(26, 184);
			lblItemName.Name = "lblItemName";
			lblItemName.Size = new Size(318, 28);
			lblItemName.TabIndex = 1;
			lblItemName.Text = "Enter the item you want to remove:";
			// 
			// txbItemName
			// 
			txbItemName.Location = new Point(488, 190);
			txbItemName.Margin = new Padding(3, 2, 3, 2);
			txbItemName.Name = "txbItemName";
			txbItemName.Size = new Size(110, 23);
			txbItemName.TabIndex = 2;
			// 
			// bttnRemoveItem
			// 
			bttnRemoveItem.Font = new Font("Segoe UI", 20F);
			bttnRemoveItem.Location = new Point(262, 288);
			bttnRemoveItem.Margin = new Padding(3, 2, 3, 2);
			bttnRemoveItem.Name = "bttnRemoveItem";
			bttnRemoveItem.Size = new Size(225, 61);
			bttnRemoveItem.TabIndex = 3;
			bttnRemoveItem.Text = "Remove Item";
			bttnRemoveItem.UseVisualStyleBackColor = true;
			bttnRemoveItem.Click += bttnRemoveItem_Click;
			// 
			// lblErrorMessage
			// 
			lblErrorMessage.AutoSize = true;
			lblErrorMessage.Font = new Font("Segoe UI", 15F);
			lblErrorMessage.Location = new Point(663, 193);
			lblErrorMessage.Name = "lblErrorMessage";
			lblErrorMessage.Size = new Size(0, 28);
			lblErrorMessage.TabIndex = 4;
			// 
			// bttnReturn
			// 
			bttnReturn.Font = new Font("Segoe UI", 20F);
			bttnReturn.Location = new Point(559, 288);
			bttnReturn.Margin = new Padding(3, 2, 3, 2);
			bttnReturn.Name = "bttnReturn";
			bttnReturn.Size = new Size(267, 61);
			bttnReturn.TabIndex = 5;
			bttnReturn.Text = "Return To Previous";
			bttnReturn.UseVisualStyleBackColor = true;
			bttnReturn.Click += button1_Click;
			// 
			// lblRemoval
			// 
			lblRemoval.AutoSize = true;
			lblRemoval.Location = new Point(503, 233);
			lblRemoval.Name = "lblRemoval";
			lblRemoval.Size = new Size(0, 15);
			lblRemoval.TabIndex = 6;
			// 
			// RemoveItem
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(886, 568);
			Controls.Add(lblRemoval);
			Controls.Add(bttnReturn);
			Controls.Add(lblErrorMessage);
			Controls.Add(bttnRemoveItem);
			Controls.Add(txbItemName);
			Controls.Add(lblItemName);
			Controls.Add(lblHeading);
			Margin = new Padding(3, 2, 3, 2);
			Name = "RemoveItem";
			Text = "RemoveItem";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblHeading;
		private Label lblItemName;
		private TextBox txbItemName;
		private Button bttnRemoveItem;
		private Label lblErrorMessage;
		private Button bttnReturn;
		private Label lblRemoval;
	}
}
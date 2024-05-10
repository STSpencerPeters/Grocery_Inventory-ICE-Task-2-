namespace Grocery_Inventory
{
	partial class Display
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
			lblDisplay = new Label();
			lbDisplay = new ListBox();
			lblSuccess = new Label();
			bttnReturn = new Button();
			lblErrorMessage = new Label();
			SuspendLayout();
			// 
			// lblDisplay
			// 
			lblDisplay.AutoSize = true;
			lblDisplay.Font = new Font("Segoe UI", 30F);
			lblDisplay.Location = new Point(191, 34);
			lblDisplay.Name = "lblDisplay";
			lblDisplay.Size = new Size(370, 54);
			lblDisplay.TabIndex = 0;
			lblDisplay.Text = "Display Information";
			// 
			// lbDisplay
			// 
			lbDisplay.FormattingEnabled = true;
			lbDisplay.ItemHeight = 15;
			lbDisplay.Location = new Point(256, 191);
			lbDisplay.Name = "lbDisplay";
			lbDisplay.Size = new Size(246, 169);
			lbDisplay.TabIndex = 3;
			lbDisplay.SelectedIndexChanged += lbDisplay_SelectedIndexChanged;
			// 
			// lblSuccess
			// 
			lblSuccess.AutoSize = true;
			lblSuccess.Font = new Font("Segoe UI", 15F);
			lblSuccess.Location = new Point(336, 374);
			lblSuccess.Name = "lblSuccess";
			lblSuccess.Size = new Size(0, 28);
			lblSuccess.TabIndex = 5;
			// 
			// bttnReturn
			// 
			bttnReturn.Font = new Font("Segoe UI", 15F);
			bttnReturn.Location = new Point(274, 425);
			bttnReturn.Name = "bttnReturn";
			bttnReturn.Size = new Size(211, 52);
			bttnReturn.TabIndex = 6;
			bttnReturn.Text = "Return To Previous";
			bttnReturn.UseVisualStyleBackColor = true;
			bttnReturn.Click += bttnReturn_Click;
			// 
			// lblErrorMessage
			// 
			lblErrorMessage.AutoSize = true;
			lblErrorMessage.Location = new Point(654, 149);
			lblErrorMessage.Name = "lblErrorMessage";
			lblErrorMessage.Size = new Size(0, 15);
			lblErrorMessage.TabIndex = 7;
			// 
			// Display
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(845, 555);
			Controls.Add(lblErrorMessage);
			Controls.Add(bttnReturn);
			Controls.Add(lblSuccess);
			Controls.Add(lbDisplay);
			Controls.Add(lblDisplay);
			Name = "Display";
			Text = "Display";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblDisplay;
		private Label lblItemName;
		private TextBox txbItemName;
		private ListBox lbDisplay;
		private Label lblSuccess;
		private Button bttnReturn;
		private Label lblErrorMessage;
	}
}
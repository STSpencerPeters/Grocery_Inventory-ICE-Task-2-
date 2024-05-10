using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Inventory
{
	public partial class RemoveItem : Form
	{
		public RemoveItem()
		{
			InitializeComponent();
		}

		private void bttnRemoveItem_Click(object sender, EventArgs e)
		{
			string itemName = txbItemName.Text; 

			if (string.IsNullOrEmpty(itemName))
			{
				lblErrorMessage.ForeColor = Color.Red;
				lblErrorMessage.Text = "Please enter the name of the item to remove.";
				return; 
			}

			GroceryStore store = new GroceryStore();
			Inventory inventory = store.Inventory;

			bool remove = inventory.RemoveItem(itemName);

            if (remove)
            {
				lblRemoval.ForeColor = Color.Green;
				lblRemoval.Text = $"Item '{itemName}' removed successfully.";
			}
			else
			{
				lblRemoval.ForeColor = Color.Red;
				lblRemoval.Text = $"Item '{itemName}' not found in inventory.";
			}
			txbItemName.Text = "";

			Form1 main = new Form1();
			main.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 main = new Form1();
			main.Show();
			this.Hide();
		}
	}
}

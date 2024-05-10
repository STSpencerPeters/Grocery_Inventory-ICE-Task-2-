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
	public partial class AddItem : Form
	{
		public AddItem()
		{
			InitializeComponent();
		}

		private void bttnAddItem_Click(object sender, EventArgs e)
		{
			InventoryItem item = new InventoryItem();
			if (string.IsNullOrEmpty(txbName.Text) || string.IsNullOrEmpty(txbPrice.Text) || string.IsNullOrEmpty(txbQuantity.Text) || string.IsNullOrEmpty(txbCategory.Text))
			{
				lblErrorName.ForeColor = Color.Red;
				lblErrorPrice.ForeColor = Color.Red;
				lblErrorQuantity.ForeColor = Color.Red;
				lblErrorCategory.ForeColor = Color.Red;

				lblErrorName.Text = "This cannot be empty, please enter a value";
				lblErrorPrice.Text = "This cannot be empty, please enter a value";
				lblErrorQuantity.Text = "This cannot be empty, please enter a value";
				lblErrorCategory.Text = "This cannot be empty, please enter a value";
			}
			else
			{
				item.ItemName = txbName.Text;
				item.ItemPrice = int.Parse(txbPrice.Text);
				item.ItemQuanity = int.Parse(txbQuantity.Text);
				item.ItemCategory = txbCategory.Text;

				GroceryStore store = new GroceryStore();
				Inventory inventory = store.Inventory;

				inventory.AddItem(item);

				Form1 main = new Form1();
				main.Show();
				this.Hide();
			}
		}

		private void bttnReturn_Click(object sender, EventArgs e)
		{
			Form1 main = new Form1();
			main.Show();
			this.Hide();
		}
	}
}

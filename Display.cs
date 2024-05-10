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
	public partial class Display : Form
	{
		public Display()
		{
			InitializeComponent();
			DisplayItems();
		}

		private void DisplayItems()
		{
			GroceryStore store = new GroceryStore();
			Inventory inventory = store.Inventory;

			Dictionary<string, List<InventoryItem>> inventoryData = inventory.DisplayInventory();

			lbDisplay.Items.Clear();

			foreach (var category in inventoryData)
			{
				foreach (var item in category.Value)
				{
					lbDisplay.Items.Add($"Category: {category.Key}");
					lbDisplay.Items.Add($"- {item.ItemName}: Price {item.ItemPrice}, Quantity {item.ItemQuanity}");
					lbDisplay.Items.Add("");
				}
			}

			lbDisplay.Refresh();
		}


		private void bttnReturn_Click(object sender, EventArgs e)
		{
			Form1 main = new Form1();
			main.Show();
			this.Hide();
		}

		private void lbDisplay_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}

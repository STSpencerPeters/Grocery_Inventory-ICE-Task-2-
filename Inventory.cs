using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Inventory
{
	class Inventory
	{
		private Dictionary<string, List<InventoryItem>> itemsByCategory = new Dictionary<string, List<InventoryItem>>();

		public void AddItem(InventoryItem item)
		{
			if (!itemsByCategory.ContainsKey(item.ItemCategory))
			{
				itemsByCategory[item.ItemCategory] = new List<InventoryItem>();
			}
			itemsByCategory[item.ItemCategory].Add(item);
		}

		public bool RemoveItem(string itemName)
		{
			
			if (itemsByCategory.ContainsKey(itemName))
			{
				
				itemsByCategory.Remove(itemName);
				return true; 
			}
			else
			{
				return false; 
			}
		}

		public Dictionary<string, List<InventoryItem>> DisplayInventory()
		{
			return itemsByCategory;
		}
	}

}

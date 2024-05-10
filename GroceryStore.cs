using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Inventory
{
	class GroceryStore
	{
		public Inventory Inventory { get; private set; }

		public GroceryStore()
		{
			Inventory = new Inventory();
		}
	}
}

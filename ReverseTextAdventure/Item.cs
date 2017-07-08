using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTextAdventure
{
	class Item
	{
		public string Name;
		public List<Item> containedItems = new List<Item>();

		// attributes
		public bool IsPrimarilyAContainer = false;
		public bool IsCarryable = false;

		public Item(string Name)
		{
			this.Name = Name;
		}
	}
}

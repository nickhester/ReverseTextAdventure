using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTextAdventure
{
	class Hero
	{
		public List<Item> Holders = new List<Item>();

		public Hero()
		{
			Holders.Add(new Item("hands"));
			Holders.Add(new Item("pocket"));
		}

		public void AddItem(Item item)
		{
			Holders[0].containedItems.Add(item);		// currently hard-coded to hands
		}
	}
}

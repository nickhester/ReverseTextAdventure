using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTextAdventure
{
	class Area
	{
		public string name;
		public List<Area> connections = new List<Area>();
		public List<ItemAndLocation> items = new List<ItemAndLocation>();

		public Area()
		{
		}

		public Area(string name)
		{
			this.name = name;
		}

		public void AddItem(string location, Item item)
		{
			items.Add(new ItemAndLocation(location, item));
		}
	}


	struct ItemAndLocation
	{
		string location;
		Item item;

		public ItemAndLocation(string location, Item item)
		{
			this.location = location;
			this.item = item;
		}
	}
}
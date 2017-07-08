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

		public enum ItemUse
		{
			TOOL,
			LIGHT,
			WEAPON,
			DIRECTIONS,
			INFORMATION,
			FOOD
		}

		public Item(string Name)
		{
			this.Name = Name;
		}
	}
}

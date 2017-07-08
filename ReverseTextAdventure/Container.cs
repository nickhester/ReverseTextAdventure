using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTextAdventure
{
	class Container
	{
		public List<Item> Contents = new List<Item>();
		public string Name;

		public Container(string Name)
		{
			this.Name = Name;
		}
	}
}

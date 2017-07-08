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
		public List<Item> items = new List<Item>();
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTextAdventure
{
	class Hero
	{
		public List<Container> Holders = new List<Container>();

		public Hero()
		{
			Holders.Add(new ReverseTextAdventure.Container("pocket"));
			Holders.Add(new ReverseTextAdventure.Container("hands"));
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTextAdventure
{
	class World
	{
		Hero hero = new Hero();
		List<Area> areas = new List<Area>();
		Area currentArea;

		public World()
		{
			currentArea = new Area();
			areas.Add(currentArea);
		}

		public void UpdateThisArea(string name)
		{
			currentArea.name = name;
		}
	}
}

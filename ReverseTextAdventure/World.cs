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

		public void NameThisArea(string name)
		{
			currentArea.name = name;
		}

		public void AddItem(string locationName, Item item)
		{
			if (locationName.ToLower() == "hero")
			{
				hero.AddItem(item);
			}
			else
			{
				currentArea.AddItem(locationName, item);
			}
		}

		public bool HasCurrentLocationInfo()
		{
			if (currentArea.name == null)
			{
				return false;
			}
			return true;
		}

		public void AddAreaConnection(Area areaConnection)
		{
			if (!areas.Contains(areaConnection))
			{
				areas.Add(areaConnection);
			}

			currentArea.connections.Add(areaConnection);
		}
	}
}

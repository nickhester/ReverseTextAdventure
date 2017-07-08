using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTextAdventure
{
	class ResponseProcessor
	{
		World world;

		public ResponseProcessor(World world)
		{
			this.world = world;
		}

		public void ProcessResponse(Statement statement, PlayerResponse response)
		{
			//Console.WriteLine("process logic: " + statement.text + " / " + response.text);

			// 1st: update environment/items/hero
			
			Question question = statement as Question;
			if (question != null)
			{
				if (question.infoRequested == typeof(Area))		// update area info
				{
					if (question.location == "Here")
					{
						world.NameThisArea(response.text);
					}
					else if (question.location == "Connection")
					{
						world.AddAreaConnection(new Area(response.text));
					}
				}
				else if (question.infoRequested == typeof(Item))
				{
					world.AddItem(question.location, new Item(response.text));
				}
			}

			// 2nd: determine next statement
		}
	}
}

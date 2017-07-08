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
			Console.WriteLine("process logic: " + statement.text + " / " + response.text);

			// 1st: update environment/items/hero
			// 2nd: determine next statement

			Question question = statement as Question;
			if (question != null)
			{
				if (question.infoRequested == typeof(Area))		// update area info
				{
					world.UpdateThisArea(response.text);
				}
			}
		}
	}
}

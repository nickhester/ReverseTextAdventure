using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTextAdventure
{
	class Program
	{
		static void Main(string[] args)
		{
			Resources resources = new Resources();
			World world = new World();
			ResponseProcessor responseProcessor = new ResponseProcessor(world);
			StatementChooser statementChooser = new StatementChooser(world, resources);

			string playerResponseText = "";
			PlayerResponse playerResponse;
			while (true)
			{
				Statement statement = statementChooser.ChooseStatement(typeof(Question));
				Console.WriteLine(statement.text);

				playerResponseText = Console.ReadLine();
				playerResponse = new PlayerResponse(playerResponseText);

				responseProcessor.ProcessResponse(statement, playerResponse);
			}
		}
	}
}

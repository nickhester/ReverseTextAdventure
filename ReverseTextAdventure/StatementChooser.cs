using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTextAdventure
{
	class StatementChooser
	{
		World world;
		Resources resources;
		Random random = new Random();

		public StatementChooser(World world, Resources resources)
		{
			this.world = world;
			this.resources = resources;
		}

		public Statement ChooseStatement(System.Type typeOfStatement)
		{
			Statement returnStatement = null;

			if (typeOfStatement == typeof(Question))
			{
				List<Question> questions = resources.GetQuestions();
				List<Question> chosenQuestionList;
				if (!world.HasCurrentLocationInfo())                                // find out about current location
				{
					var chosenQuestion = from question in questions
										 where question.infoRequested == typeof(Area)
										 where question.location == "Here"
										 select question;
					chosenQuestionList = new List<Question>(chosenQuestion);
				}
				else                                                                // find out about objects
				{
					var chosenQuestion = from question in questions
										 where question.location != "Here"
										 select question;
					chosenQuestionList = new List<Question>(chosenQuestion);
				}
				
				returnStatement = chosenQuestionList[random.Next(chosenQuestionList.Count())];
			}
			else
			{
				// action
			}

			return returnStatement;
		}
	}
}

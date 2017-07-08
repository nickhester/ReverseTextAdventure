using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReverseTextAdventure
{
	class Resources
	{
		string resource;

		List<Question> questions = new List<Question>();
		List<Action> actions = new List<Action>();

		Random random = new Random();

		public Resources()
		{
			// read all resources
			resource = File.ReadAllText(@"Resources\resource.txt", Encoding.UTF8);

			string currentSection = "";
			foreach (var line in resource.Split('\n'))
			{
				if (line.StartsWith("<Question>"))
				{
					currentSection = "Question";
				}
				else if (line.StartsWith("<Action>"))
				{
					currentSection = "Action";
				}
				else
				{
					if (currentSection == "Question")
					{
						string[] tokens = line.Split(';');
						Question q = new Question(tokens[0], tokens[1]);
						questions.Add(q);
					}
					else if (currentSection == "Action")
					{
						string[] tokens = line.Split(';');
						Action a = new Action(tokens[0]);
						actions.Add(a);
					}
				}
			} 
		}

		public Statement GetResource(System.Type type)
		{
			if (type == typeof(Question))
				return questions[random.Next(questions.Count())];
			else if (type == typeof(Action))
				return actions[random.Next(actions.Count())];
			else
				return null;
		}
	}
}

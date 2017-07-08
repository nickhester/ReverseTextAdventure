using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTextAdventure
{
	class Question : Statement
	{
		public System.Type infoRequested;
		public string location;

		public Question(string text, string infoRequestedString, string location) : base(text)
		{
			switch (infoRequestedString)
			{
				case "Item":
					infoRequested = typeof(Item);
					break;
				case "Area":
					infoRequested = typeof(Area);
					break;
				default:
					Console.Error.WriteLine("error forming question");
					break;
			}

			this.location = location;
		}
	}
}

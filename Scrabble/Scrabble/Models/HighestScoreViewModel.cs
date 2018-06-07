using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrabble.Models
{
	public class HighestScoreViewModel : GameViewModel
	{
		public int Score { get; set; }
		public string PlayedAgainstPlayerName { get; set; }
	}
}
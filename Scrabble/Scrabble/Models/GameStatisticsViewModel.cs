using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrabble.Models
{
	public class GameStatisticsViewModel
	{
		public int MemberId { get; set; }
		public int Wins { get; set; }
		public int Loses { get; set; }
		public double AverageScore { get; set; }
		public HighestScoreViewModel HighestScore { get; set; }
	}
}
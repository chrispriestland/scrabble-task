using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
	public class GameStatistics
	{
		public int MemberId { get; set; }
		public int Wins { get; set; }
		public int Loses { get; set; }
		public double AverageScore { get; set; }
		public HighestScore HighestScore { get; set; }
	}
}

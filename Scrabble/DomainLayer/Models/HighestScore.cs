using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
	public class HighestScore : Game
	{
		public int Score { get; set; }
		public string PlayedAgainstPlayerName { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
	public class Game
	{
		public int Id { get; set; }
		public string Location { get; set; }
		public DateTime GameDate { get; set; }
		public List<Player> Players { get; set; }
	}
}

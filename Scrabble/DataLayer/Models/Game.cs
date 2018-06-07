using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
	public class Game
	{
		public int Id { get; set; }
		public string Location { get; set; }
		public DateTime GameDate { get; set; }
		public ICollection<Player> Players { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrabble.Models
{
	public class GameViewModel
	{
		public int Id { get; set; }
		public string Location { get; set; }
		public DateTime GameDate { get; set; }
		public List<PlayerViewModel> Players { get; set; }
	}
}
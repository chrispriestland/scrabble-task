using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrabble.Models
{
	public class PlayerViewModel
	{
		public int Id { get; set; }
		public int GameId { get; set; }
		public int MemberId { get; set; }
		public int Score { get; set; }
	}
}
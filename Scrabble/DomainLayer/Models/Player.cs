using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
	public class Player
	{
		public int Id { get; set; }
		public int GameId { get; set; }
		public int MemberId { get; set; }
		public int Score { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
		public virtual ICollection<Player> Players { get; set; }
	}
}

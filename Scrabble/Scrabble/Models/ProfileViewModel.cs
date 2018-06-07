using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrabble.Models
{
	public class ProfileViewModel
	{
		public MemberViewModel Member { get; set; }
		public GameStatisticsViewModel GameStatistics { get; set; }
	}
}
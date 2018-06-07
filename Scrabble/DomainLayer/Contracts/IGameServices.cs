using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
	public interface IGameServices
	{
		List<Game> GetGames();
		Game GetGame(int gameId);
		GameStatistics GetGameStatisticsForMember(int memberId);
	}
}

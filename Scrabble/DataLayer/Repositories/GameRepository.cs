using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Contracts;
using DataLayer.Models;
using MoreLinq;

namespace DataLayer.Repositories
{
	public class GameRepository : BaseRepository, IGameRepository
	{
		public GameRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
		{
		}

		public Game Get(int id)
		{
			var dbSet = Context.Set<Game>();

			return dbSet.Single(x => x.Id == id);
		}

		public List<Game> GetAll()
		{
			var dbSet = Context.Set<Game>();
			return dbSet.ToList();
		}

		public IQueryable<Game> GetGamesForMember(int memberId)
		{
			var dbSet = Context.Set<Game>();
			return dbSet.Where(x => x.Players.Any(y => y.MemberId == memberId));
		}

		public Dictionary<Member, double> GetTop10AverageScoresFromLeast10Matches()
		{
			var dbSetGame = Context.Set<Game>();
			var dbSetMember = Context.Set<Member>();
			var dbSetPlayer = Context.Set<Player>();

			// Select Average Score and Games Player for each Player in Games Played as sub queries so they can be sorted on

			var top10AverageScoresFromLeast10PlayedMatches = (from g in dbSetGame
															 from p in g.Players
															 from member in dbSetMember

															 let averageScore = (from a in dbSetGame
																				 from b in a.Players
																				 where a.Id == b.GameId
																				 && b.MemberId == p.MemberId
																				 select b.Score).Average()

															 let gamesPlayed = (from c in dbSetPlayer
																				where c.MemberId == p.MemberId
																				select c).Count()
															 
															 where g.Id == p.GameId
															 && member.Id == p.MemberId
															 orderby gamesPlayed ascending
															 select new { averageScore, member }).DistinctBy(x => x.member).Take(10).OrderByDescending(l => l.averageScore).ToDictionary(l => l.member, l => l.averageScore);

			return top10AverageScoresFromLeast10PlayedMatches;

		}
	}
}

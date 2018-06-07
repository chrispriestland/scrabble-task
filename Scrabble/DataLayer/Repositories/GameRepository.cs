using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Contracts;
using DataLayer.Models;

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
	}
}

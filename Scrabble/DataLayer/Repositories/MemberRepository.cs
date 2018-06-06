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
	public class MemberRepository : BaseRepository, IMemberRepository
	{
		public MemberRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
		{
		}

		public int Create(Member item)
		{
			var dbSet = Context.Set<Member>();
			dbSet.Add(item);
			Context.SaveChanges();
			return item.Id;
		}

		public Member Get(int id)
		{
			var dbSet = Context.Set<Member>();

			return dbSet.Single(x => x.Id == id);
		}

		public void Update(Member member)
		{
			throw new NotImplementedException();
		}

		
	}
}

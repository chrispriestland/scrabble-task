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

		public List<Member> GetAll()
		{
			var dbSet = Context.Set<Member>();
			return dbSet.ToList();
		}

		public void Update(Member member)
		{
			var dbSet = Context.Set<Member>();
			var dataMember = dbSet.Single(x => x.Id == member.Id);
			dataMember.FirstName = member.FirstName;
			dataMember.LastName = member.LastName;
			dataMember.TelephoneNumber = member.TelephoneNumber;
			dataMember.EmailAddress = member.EmailAddress;
			dataMember.Address1 = member.Address1;
			dataMember.Address2 = member.Address2;
			dataMember.City = member.City;
			dataMember.Region = member.Region;
			dataMember.PostCode = member.PostCode;
			dataMember.DateJoined = member.DateJoined;
			Context.SaveChanges();
		}

		
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer.Contracts
{
	public interface IMemberRepository
	{
		int Create(Member member);
		Member Get(int id);
		List<Member> GetAll();
		void Update(Member member);
	}
}

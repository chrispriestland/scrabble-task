using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
	public interface IMemberServices
	{
		int Create(Member member);
		List<Member> GetMemberProfiles();
		Member GetMemberProfile(int memberId);
		void Update(Member member);
	}
}

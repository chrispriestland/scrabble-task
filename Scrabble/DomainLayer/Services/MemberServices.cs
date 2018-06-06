using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Contracts;
using DomainLayer.Models;

namespace DomainLayer.Services
{
	public class MemberServices : IMemberServices
	{
		private readonly IMemberRepository _memberRepository;

		public MemberServices(IMemberRepository memberRepository)
		{
			_memberRepository = memberRepository;
		}

		public int Create(Member member)
		{
			var dataMember = new DataLayer.Models.Member
			{
				FirstName = member.FirstName,
				LastName = member.LastName,
				TelephoneNumber = member.TelephoneNumber,
				EmailAddress = member.EmailAddress,
				Address1 = member.Address1,
				Address2 = member.Address2,
				City = member.City,
				Region = member.Region,
				PostCode = member.PostCode,
				DateJoined = member.DateJoined
			};
			return _memberRepository.Create(dataMember);
		}
	}
}

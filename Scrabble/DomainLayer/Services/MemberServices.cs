using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
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
			return _memberRepository.Create(Mapper.Map<Member, DataLayer.Models.Member>(member));
		}

		public List<Member> GetMemberProfiles()
		{
			var members = _memberRepository.GetAll();
			return Mapper.Map<List<DataLayer.Models.Member>, List<Member>>(members);
		}

		public Member GetMemberProfile(int memberId)
		{
			return Mapper.Map<DataLayer.Models.Member, Member>(_memberRepository.Get(memberId));
		}

		public void Update(Member member)
		{
			_memberRepository.Update(Mapper.Map<Member, DataLayer.Models.Member>(member));
		}
	}
}

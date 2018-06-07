using DomainLayer;
using DomainLayer.Models;
using Scrabble.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Hosting;
using System.Web;
using System.Web.Mvc;
using AutoMapper;

namespace Scrabble.Controllers
{
	public class InterfacesController : BaseController
	{
		public InterfacesController(IMemberServices memberServices) : base(memberServices)
		{ }

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult CreateMemberProfile()
		{
			return View();
		}

		public ActionResult EditMemberProfiles()
		{
			var members = _memberServices.GetMemberProfiles();
			var viewModel = Mapper.Map(members, new List<MemberViewModel>());
			return View(viewModel);
		}

		public ActionResult EditMember(int memberId)
		{
			var member = _memberServices.GetMemberProfile(memberId);
			var viewModel = Mapper.Map(member, new MemberViewModel());
			return View(viewModel);
		}

		public bool CreateMember(MemberViewModel memberViewModel)
		{
			var result = _memberServices.Create(Mapper.Map<MemberViewModel, Member>(memberViewModel));
			return result > 0;
		}

		public bool UpdateMember(MemberViewModel memberViewModel)
		{
			_memberServices.Update(Mapper.Map<MemberViewModel, Member>(memberViewModel));
			return true;
		}
	}
}
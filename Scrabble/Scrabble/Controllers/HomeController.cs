using DomainLayer;
using DomainLayer.Models;
using Scrabble.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;

namespace Scrabble.Controllers
{
	public class HomeController : BaseController
	{
		public HomeController(IMemberServices memberServices, IGameServices gameServices) : base(memberServices, gameServices)
		{ }

		public ActionResult Index()
		{
			var members = _memberServices.GetMemberProfiles();

			var viewModel = Mapper.Map<List<Member>, List<MemberViewModel>>(members);

			return View(viewModel);
		}

		public ActionResult ProfilePage(int memberId)
		{
			var member = _memberServices.GetMemberProfile(memberId);
			_gameServices.GetGames();
			var gameStatistics = _gameServices.GetGameStatisticsForMember(memberId);

			var memberViewModel = Mapper.Map<Member, MemberViewModel>(member);
			var gameStatisticsViewModel = Mapper.Map<GameStatistics, GameStatisticsViewModel>(gameStatistics);

			var viewModel = new ProfileViewModel
			{
				Member = memberViewModel,
				GameStatistics = gameStatisticsViewModel
			};
			return View(viewModel);
		}
	}
}
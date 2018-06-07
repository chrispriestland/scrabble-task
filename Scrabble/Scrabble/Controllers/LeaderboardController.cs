using DomainLayer;
using DomainLayer.Models;
using Scrabble.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scrabble.Controllers
{
	public class LeaderboardController : BaseController
	{
		public LeaderboardController(IMemberServices memberServices, IGameServices gameServices) : base(memberServices, gameServices)
		{ }

		public ActionResult Index()
		{
			return View();
		}
	}
}
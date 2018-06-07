using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scrabble.Controllers
{
	public abstract class BaseController : Controller
	{
		protected readonly IMemberServices _memberServices;
		protected readonly IGameServices _gameServices;

		protected BaseController(IMemberServices memberServices, 
			IGameServices gameServices) : base()
		{
			_memberServices = memberServices;
			_gameServices = gameServices;
		}
	}
}
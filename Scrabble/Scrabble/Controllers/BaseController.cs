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

		protected BaseController(IMemberServices memberServices) : base()
		{
			_memberServices = memberServices;
		}
	}
}
﻿using DomainLayer;
using DomainLayer.Models;
using Scrabble.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scrabble.Controllers
{
	public class HomeController : BaseController
	{
		public HomeController(IMemberServices memberServices) : base(memberServices)
		{ }

		public ActionResult Index()
		{
			return View();
		}
	}
}
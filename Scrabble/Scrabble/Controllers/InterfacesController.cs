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
	public class InterfacesController : BaseController
	{
		public InterfacesController(IMemberServices memberServices) : base(memberServices)
		{ }

		public ActionResult Index()
		{
			return View();
		}

		public bool CreateMember(MemberViewModel memberViewModel)
		{
			var domainMember = new Member
			{
				FirstName = memberViewModel.FirstName,
				LastName = memberViewModel.LastName,
				TelephoneNumber = memberViewModel.TelephoneNumber,
				EmailAddress = memberViewModel.EmailAddress,
				Address1 = memberViewModel.Address1,
				Address2 = memberViewModel.Address2,
				City = memberViewModel.City,
				Region = memberViewModel.Region,
				PostCode = memberViewModel.PostCode,
				DateJoined = memberViewModel.DateJoined
			};

			var result = _memberServices.Create(domainMember);
			return result > 0 ? true : false;
		}
	}
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
	public class Member
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string TelephoneNumber { get; set; }
		public string EmailAddress { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string City { get; set; }
		public string Region { get; set; }
		public string PostCode { get; set; }
		public DateTime DateJoined { get; set; }

	}
}

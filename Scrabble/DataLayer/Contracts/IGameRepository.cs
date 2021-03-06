﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer.Contracts
{
	public interface IGameRepository
	{
		Game Get(int id);
		List<Game> GetAll();
		IQueryable<Game> GetGamesForMember(int memberId);
		Dictionary<Member, double> GetTop10AverageScoresFromLeast10Matches();
	}
}

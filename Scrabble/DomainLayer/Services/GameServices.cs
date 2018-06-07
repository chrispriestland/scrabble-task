﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataLayer.Contracts;
using DomainLayer.Models;

namespace DomainLayer.Services
{
	public class GameServices : IGameServices
	{
		private readonly IGameRepository _gameRepository;
		private readonly IMemberRepository _memberRepository;

		public GameServices(IGameRepository gameRepository, IMemberRepository memberRepository)
		{
			_gameRepository = gameRepository;
			_memberRepository = memberRepository;
		}

		public List<Game> GetGames()
		{
			var games = _gameRepository.GetAll();
			return Mapper.Map<List<DataLayer.Models.Game>, List<Game>>(games);
		}

		public Game GetGame(int gameId)
		{
			var game = _gameRepository.Get(gameId);
			return Mapper.Map<DataLayer.Models.Game, Game>(game);
		}

		public GameStatistics GetGameStatisticsForMember(int memberId)
		{
			var games = _gameRepository.GetGamesForMember(memberId);

			if (games.Any())
			{
				var averageScore = (from x in games
									from y in x.Players
									where x.Id == y.GameId
									&& y.MemberId == memberId
									select y.Score).Average();

				int wins = 0, loses = 0, highestScore = 0;
				HighestScore highestScorePlayer = null;
				foreach (var game in games)
				{
					if (game.Players.OrderByDescending(x => x.Score).First().MemberId == memberId)
					{
						wins++;

						if (game.Players.Single(x => x.MemberId == memberId).Score > highestScore)
						{
							highestScore = game.Players.Single(x => x.MemberId == memberId).Score;
							var otherPlayer = _memberRepository.Get(game.Players.Single(x => x.MemberId != memberId).MemberId);

							highestScorePlayer = new HighestScore
							{
								GameDate = game.GameDate,
								Location = game.Location,
								Score = highestScore,
								PlayedAgainstPlayerName = $"{otherPlayer.FirstName} {otherPlayer.LastName}"
							};
						}
					}
					else
					{
						loses++;
					}
					
				}

				return new GameStatistics
				{
					Wins = wins,
					Loses = loses,
					AverageScore = averageScore,
					HighestScore = highestScorePlayer
				};

			}

			return null;

		}
	}
}

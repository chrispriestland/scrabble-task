using System;
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

		public GameServices(IGameRepository gameRepository)
		{
			_gameRepository = gameRepository;
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
	}
}

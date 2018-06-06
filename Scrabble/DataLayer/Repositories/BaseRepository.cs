using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Contracts;

namespace DataLayer.Repositories
{
	public abstract class BaseRepository : IBaseRepository
	{
		public IUnitOfWork UnitOfWork { get; set; }

		protected BaseRepository(IUnitOfWork unitOfWork)
		{
			UnitOfWork = unitOfWork;
		}

		protected DatabaseContext Context => (DatabaseContext)UnitOfWork;

	}
}

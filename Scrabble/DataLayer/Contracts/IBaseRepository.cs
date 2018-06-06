using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Contracts
{
	public interface IBaseRepository
	{
		IUnitOfWork UnitOfWork { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Contracts;
using DataLayer.Mappers;

namespace DataLayer
{
    public class DatabaseContext : DbContext, IUnitOfWork
    {
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new MemberMapper());
			modelBuilder.Configurations.Add(new GameMapper());
			modelBuilder.Configurations.Add(new PlayerMapper());
		}

		public int Commit()
		{
			var recordCount = SaveChanges();
			return recordCount;
		}
	}
}

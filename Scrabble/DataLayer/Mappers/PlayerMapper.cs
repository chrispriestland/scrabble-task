using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer.Mappers
{
	internal class PlayerMapper : EntityTypeConfiguration<Player>
	{
		internal PlayerMapper()
		{
			HasKey(m => m.Id);
			Property(x => x.GameId).HasColumnName("GameId").IsRequired();
			Property(x => x.MemberId).HasColumnName("MemberId").IsRequired();
			Property(x => x.Score).HasColumnName("Score").IsRequired();

			ToTable("Player");
		}
	}
}

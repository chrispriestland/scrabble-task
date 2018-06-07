using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer.Mappers
{
	internal class GameMapper : EntityTypeConfiguration<Game>
	{
		internal GameMapper()
		{
			HasKey(m => m.Id);
			Property(x => x.Location).HasColumnName("Location").IsRequired();
			Property(x => x.GameDate).HasColumnName("GameDate").IsRequired();

			HasMany(x => x.Players)
				.WithOptional()
				.HasForeignKey(s => s.GameId)
				.WillCascadeOnDelete(false);

			ToTable("Game");
		}
	}
}

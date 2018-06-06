using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer.Mappers
{
	internal class MemberMapper : EntityTypeConfiguration<Member>
	{
		internal MemberMapper()
		{
			HasKey(m => m.Id);

			Property(m => m.FirstName).HasColumnName("FirstName").IsRequired();
			Property(m => m.LastName).HasColumnName("LastName").IsRequired();
			Property(m => m.TelephoneNumber).HasColumnName("TelephoneNumber").IsRequired();
			Property(m => m.EmailAddress).HasColumnName("EmailAddress").IsRequired();
			Property(m => m.Address1).HasColumnName("Address1").IsRequired();
			Property(m => m.Address2).HasColumnName("Address2").IsRequired();
			Property(m => m.City).HasColumnName("City").IsRequired();
			Property(m => m.Region).HasColumnName("Region");
			Property(m => m.PostCode).HasColumnName("PostCode").IsRequired();
			Property(m => m.DateJoined).HasColumnName("DateJoined").IsRequired();

			ToTable("Member");
		}
	}
}

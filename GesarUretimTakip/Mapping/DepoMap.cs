using Cores.Entities.Depo;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFactory.Mapping
{
    public class DepoMap : EntityTypeConfiguration<Depo>
    {
        public DepoMap()
        {
            this.HasKey(q => q.ID);
            this.Property(q => q.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(q => q.DepoAdi).HasMaxLength(300);
            this.Property(q => q.DepoKodu).HasMaxLength(300);

            this.ToTable("Depolar");
            this.Property(q => q.ID).HasColumnName("ID");
            this.Property(q => q.DepoAdi).HasColumnName("DepoAdi");
            this.Property(q => q.DepoKodu).HasColumnName("DepoKodu");
        }
    }
}

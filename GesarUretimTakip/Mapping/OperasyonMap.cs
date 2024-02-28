using Cores.Entities.Uretim;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFactory.Mapping
{
    public class OperasyonMap : EntityTypeConfiguration<Operasyon>
    {
        public OperasyonMap()
        {
            this.HasKey(q => q.ID);
            this.Property(q => q.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(q => q.OperasyonAdi).HasMaxLength(300);

            this.ToTable("Operasyonlar");
            this.Property(q => q.ID).HasColumnName("ID");
            this.Property(q => q.OperasyonAdi).HasColumnName("OperasyonAdi");
            this.Property(q => q.OperasyonTanimID).HasColumnName("OperasyonTanimID");
        }
    }
}

using Cores.Entities.Uretim;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFactory.Mapping
{
    public class OperasyonTanimiMap : EntityTypeConfiguration<OperasyonTanimi>
    {
        public OperasyonTanimiMap()
        {
            this.HasKey(q => q.ID);
            this.Property(q => q.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(q => q.Aciklama).HasMaxLength(50);

            this.ToTable("OperasyonTanimlari");
            this.Property(q => q.ID).HasColumnName("ID");
            this.Property(q => q.Aciklama).HasColumnName("Aciklama");
        }
    }
}

using Cores.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFactory.Mapping
{
    public class TezgahGrubuMap : EntityTypeConfiguration<TezgahGrubu>
    {
        public TezgahGrubuMap()
        {
            this.HasKey(q => q.ID);
            this.Property(q => q.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(q => q.TezgahGrupKodu).HasMaxLength(30);
            this.Property(q => q.Aciklama).HasMaxLength(300);

            this.ToTable("TezgahGruplari");
            this.Property(q => q.ID).HasColumnName("ID");
            this.Property(q => q.TezgahGrupKodu).HasColumnName("TezgahGrupKodu");
            this.Property(q => q.Aciklama).HasColumnName("Aciklama");
        }
    }
}

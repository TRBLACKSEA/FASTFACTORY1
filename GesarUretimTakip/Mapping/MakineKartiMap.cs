using Core;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFactory.Mapping
{
    public class MakineKartiMap : EntityTypeConfiguration<MakineKarti>
    {
        public MakineKartiMap()
        {
            this.HasKey(q => q.ID);
            this.Property(q => q.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(q => q.Kodu).HasMaxLength(30);
            this.Property(q => q.MakineAdi).HasMaxLength(100);
            this.Property(q => q.Markasi).HasMaxLength(50);
            this.Property(q => q.Modeli).HasMaxLength(50);
            this.Property(q => q.KontrolUnitesi).HasMaxLength(50);
            this.Property(q => q.PortName).HasMaxLength(30);
            this.Property(q => q.Priority).HasPrecision(6,2);

            this.ToTable("MakineKartlari");
            this.Property(q => q.ID).HasColumnName("ID");
            this.Property(q => q.Kodu).HasColumnName("Kodu");
            this.Property(q => q.MakineAdi).HasColumnName("MakineAdi");
            this.Property(q => q.Markasi).HasColumnName("Markasi");
            this.Property(q => q.Modeli).HasColumnName("Modeli");
            this.Property(q => q.TezgahGrupID).HasColumnName("TezgahGrupID");
            this.Property(q => q.KontrolUnitesi).HasColumnName("KontrolUnitesi");
            this.Property(q => q.PortName).HasColumnName("PortName");
            this.Property(q => q.BaundRate).HasColumnName("BaundRate");
            this.Property(q => q.Priority).HasColumnName("Priority");
        }
    }
}

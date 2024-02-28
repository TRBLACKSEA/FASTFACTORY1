using Cores.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFactory.Mapping
{
    public class TakimMap : EntityTypeConfiguration<Takim>
    {
        public TakimMap()
        {
            this.HasKey(q => q.ID);
            this.Property(q => q.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(q => q.TakimNumarasi).HasMaxLength(30);
            this.Property(q => q.Adi).HasMaxLength(30);
            this.Property(q => q.Markasi).HasMaxLength(30);
            this.Property(q => q.Modeli).HasMaxLength(30);
            this.Property(q => q.UcOmru).HasPrecision(8, 2);

            this.ToTable("Takimlar");
            this.Property(q => q.ID).HasColumnName("ID");
            this.Property(q => q.TakimNumarasi).HasColumnName("TakimNumarasi");
            this.Property(q => q.Adi).HasColumnName("Adi");
            this.Property(q => q.Markasi).HasColumnName("Markasi");
            this.Property(q => q.Modeli).HasColumnName("Modeli");
            this.Property(q => q.UcSayisi).HasColumnName("UcSayisi");
            this.Property(q => q.UcOmru).HasColumnName("UcOmru");
            this.Property(q => q.Aciklama).HasColumnName("Aciklama");
            this.Property(q => q.AktifMi).HasColumnName("AktifMi");

        }
    }
}

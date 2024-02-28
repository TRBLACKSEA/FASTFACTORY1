using Cores.Entities.Depo;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFactory.Mapping
{
    public class DepoTransferFisiMap : EntityTypeConfiguration<DepoTransferFisi>
    {
        public DepoTransferFisiMap()
        {
            this.HasKey(q => q.ID);
            this.Property(q => q.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);


            this.ToTable("Depo Transfer Fisleri");
            this.Property(q => q.ID).HasColumnName("ID");
            this.Property(q => q.NeredenID).HasColumnName("NeredenID");
            this.Property(q => q.NereyeID).HasColumnName("NereyeID");
            this.Property(q => q.TransferEdenKullaniciID).HasColumnName("TransferEdenKullaniciID");
            this.Property(q => q.TransferTarihi).HasColumnName("TransferTarihi");
            this.Property(q => q.TransferSaati).HasColumnName("TransferSaati");
        }
    }
}

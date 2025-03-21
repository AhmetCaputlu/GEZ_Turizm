using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Companies.PartnerCompanies;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Companies.PartnerCompanies
{
    internal class PartnerCompanyTransactionConfiguration:BaseModelConfiguration<PartnerCompanyTransaction>
    {
        public override void Configure(EntityTypeBuilder<PartnerCompanyTransaction> builder)
        {
            base.Configure(builder);
            //Burası yapılandırılacak
        }
    }
}
//Pas biletlerinin transaction tarafında tpt yerine tph uygula tek tabloda işlemler gerçekleşsin gitsin
//Pas biletleri bir transaction ile ilişkilendirilecek.
//Örneğin X turu talep azlığından iptal edildi ve 28 bilet sattık diyelim.X şirketi ile anlaştık ve 28 bilet satacağız.Kayıtlar tek seferde girilecek.TransactioonID PCompanyId ve ıcollection<PassTicket olucak>
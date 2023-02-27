using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UMBIT.Core.Repositorio.EntityConfigurate;

namespace UMBIT.API.EXEMPLO.model.EF_config
{
    public class EF_Gato1 : CoreEntityConfigurate<Gato1>
    {


        public override void ConfigureEntidade(EntityTypeBuilder<Gato1> builder)
        {
            builder.HasKey(i => i.Id);
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UMBIT.Core.Repositorio.EntityConfigurate;

namespace UMBIT.API.EXEMPLO.model.EF_config
{
    public class EF_Gato : CoreEntityConfigurate<Gato>
    {


        public override void ConfigureEntidade(EntityTypeBuilder<Gato> builder)
        {
            builder.HasKey(i => i.Id);
        }
    }
}

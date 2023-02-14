using UMBIT.Core.Repositorio.EntityConfigurate;

namespace UMBIT.API.EXEMPLO.model.EF_config
{
    public class EF_Gato : CoreEntityConfigurate<Gato>
    {
        public override void ConfigureEntidade()
        {
            HasKey(i => i.Id);
        }
    }
}

using UMBIT.Core.Repositorio.BaseEntity;

namespace UMBIT.API.EXEMPLO.model
{
    public class Gato: CoreBaseEntity
    {
        public bool Miar { get; set; }
        public bool t { get; set; }

        public string Tipo { get; set; }
    }
}

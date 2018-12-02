using System.Collections.Generic;

namespace SGC.ApplicationCore.Entity
{
   public class Profissao
    {
        public Profissao()
        {

        }

        public int ProfissaoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string CBO { get; set; }

        //Relacionamento muitos para muitos
        public ICollection<ProfissaoCliente> ProfissoesClientes{ get; set; }
    }
}

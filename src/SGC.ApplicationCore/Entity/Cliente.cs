using System.Collections.Generic;

namespace SGC.ApplicationCore.Entity
{
    public class Cliente
    {
        public Cliente()
        {

        }
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        //Relacinamento um clinte pode ter muitos contatos
        public ICollection<Contato> Contatos { get; set; }

        public ICollection<ProfissaoCliente> ProfissoesClientes { get; set; }

        public Endereco Endereco { get; set; }

    }
}

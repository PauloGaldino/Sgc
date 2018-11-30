using System.Collections.Generic;

namespace SGC.ApplicationCore.Entity
{
    public class Contato
    {
        public Contato()
        {

        }

        public int ContatoId { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        //Chave estrangeira 
        public int ClienteId { get; set; }

        //Relacinamento contato pode ter soemte um cliente
        public Cliente Cliente { get; set; }

    }
}

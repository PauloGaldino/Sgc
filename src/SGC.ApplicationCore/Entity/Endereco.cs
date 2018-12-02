using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.ApplicationCore.Entity
{
   public class Endereco
    {
        public Endereco()
        {

        }

        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        //Chave estrangeira => Propriedades de na
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}

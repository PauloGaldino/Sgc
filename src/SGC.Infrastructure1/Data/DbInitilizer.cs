using Microsoft.EntityFrameworkCore.Internal;
using SGC.ApplicationCore.Entity;
using System.Linq;

namespace SGC.Infrastructure.Data
{
    public static class DbInitilizer
    {
        public static void Initilize(ClienteContext context)
        {
            if(context.Clientes.Any())
            {
                return; // DataBase has been seed
            }
            #region Cadastrando clientes
            var clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome = "fulano padrão da silva",
                    CPF ="03909745016",
                },
                 new Cliente
                {
                    Nome = "beltrano padrão da silva",
                    CPF ="66244202007",
                }
            };
            context.AddRange(clientes);
            #endregion
            #region Casdastrando contatos 
            var contatos = new Contato[]
            {
                new Contato
                {
                    Nome= "Contato 1",
                    Telefone= "480595231054",
                    Email="emaildefault@test.com",
                    Cliente =clientes[0]
                },

                 new Contato
                {
                    Nome= "Contato 2",
                    Telefone= "6884766391040",
                    Email="emaildefault2@test.com",
                    Cliente =clientes[2]
                },
            };
            context.AddRange(contatos);
            #endregion
            context.SaveChanges();
        }
    }
}

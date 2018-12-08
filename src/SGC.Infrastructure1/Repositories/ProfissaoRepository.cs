﻿using SGC.ApplicationCore.Entity;
using SGC.ApplicationCore.Interfaces.Repository;
using SGC.Infrastructure.Data;

namespace SGC.Infrastructure.Repositories
{
    public class ProfissaoRepository : EFRepository<Profissao>, IProfissaoRepository
    {

        public ProfissaoRepository(ClienteContext dbContext) : base(dbContext)
        {

        }

    }
}

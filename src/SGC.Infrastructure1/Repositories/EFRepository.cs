﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SGC.ApplicationCore.Interfaces.Repository;
using SGC.Infrastructure.Data;

namespace SGC.Infrastructure.Repositories
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity:class
    {
        protected readonly ClienteContext _dbContext;
        public EFRepository(ClienteContext dbContext)
        {
            _dbContext = dbContext;
        }
        public TEntity Adicionar(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void Atualizar(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicado)
        {
            return _dbContext.Set<TEntity>().Where(predicado).AsEnumerable();
        }

        public TEntity ObterPorId(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _dbContext.Set<TEntity>().AsEnumerable();
        }

        public void Remover(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}

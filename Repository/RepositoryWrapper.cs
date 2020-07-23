using Contracts;
using Entities.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repositoryContext;
        private IRandomDataRepository _randomDataRepository;

        public IRandomDataRepository RandomData
        {
            get
            {
                if (_randomDataRepository == null)
                {
                    _randomDataRepository = new RandomDataRepository(_repositoryContext);
                }
                return _randomDataRepository;
            }
        }

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public void Save()
        {
            _repositoryContext.SaveChanges();
        }
    }
}

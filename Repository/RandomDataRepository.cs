using Contracts;
using Entities.Context;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RandomDataRepository : RepositoryBase<RandomData>, IRandomDataRepository
    {
        public RandomDataRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        { }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IRandomDataRepository RandomData { get; }
        void Save();
    }
}

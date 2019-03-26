using CodeChallenge.Sample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.Sample.Domain.Abstract
{
    public interface IData
    {
        Task<Data> GetData();
    }
}

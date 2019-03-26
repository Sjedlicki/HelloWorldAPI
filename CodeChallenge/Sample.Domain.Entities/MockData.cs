using CodeChallenge.Sample.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.Sample.Domain.Entities
{
    public class MockData : IData
    {
        public async Task<Data> GetData()
        {
            await Task.Delay(100);
            return new Data { HelloWorld = "Hello World!" };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proto.DIscratch
{
    public class Repository
    {
        private readonly DataContext _dataContext;
        public Repository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public int RowCount => _dataContext.RowCount;
    }
}

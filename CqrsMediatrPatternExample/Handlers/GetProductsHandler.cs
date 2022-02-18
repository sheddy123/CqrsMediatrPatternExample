using CqrsMediatrPatternExample.DataStore;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static CqrsMediatrPatternExample.Queries.GetValuesQuery;

namespace CqrsMediatrPatternExample.Handlers
{
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {
        private readonly FakeDataStore _fakeDataStore;
        public GetProductsHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;
        public async Task<IEnumerable<Product>> Handle(GetProductsQuery request,
            CancellationToken cancellationToken) => await _fakeDataStore.GetAllProducts();
    }
}

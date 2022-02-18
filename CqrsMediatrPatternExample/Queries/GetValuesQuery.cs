using CqrsMediatrPatternExample.DataStore;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CqrsMediatrPatternExample.Queries
{
    public class GetValuesQuery
    {
        public record GetProductsQuery() : IRequest<IEnumerable<Product>>;
        
        
    }
}

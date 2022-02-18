using CqrsMediatrPatternExample.DataStore;
using MediatR;

namespace CqrsMediatrPatternExample.Queries
{
    public class GetValuesByIdQuery
    {
        public record GetProductByIdQuery(int Id) : IRequest<Product>;
    }
}

using CqrsMediatrPatternExample.DataStore;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CqrsMediatrPatternExample.Commands
{
    public class Add_ProductCommand
    {
        public record AddProductCommand(Product Product) : IRequest<Product>;
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Application.Exmaple.Queries.FindOne
{
    public class GetCustomerDetailQuery : IRequest<CustomerDetailModel>
    {
        public int Id { get; set; }
    }
}

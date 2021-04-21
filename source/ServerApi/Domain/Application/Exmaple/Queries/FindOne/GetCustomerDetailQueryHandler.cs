using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Application.Exmaple.Queries.FindOne
{
    public class GetCustomerDetailQueryHandler : IRequestHandler<GetCustomerDetailQuery, CustomerDetailModel>
    {
        public async Task<CustomerDetailModel> Handle(GetCustomerDetailQuery request, CancellationToken cancellationToken)
        {
            // Ở đây chỉ giả lập dữ liệu. Trên thực tế phải tương tác với DB thật
            //var model = FakeDbContext.Customers.Find(c => c.Id == request.Id);
            //if (model == null)
            //{
            //    throw new NotFoundException(nameof(Customer), request.Id);
            //}
            var vm = new CustomerDetailModel
            {
                Name = "kha con oc",
                Address = "vile071197@gmail.com"
            };
            return await Task.FromResult(vm);
        }
    }
}

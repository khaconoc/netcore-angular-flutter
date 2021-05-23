using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Dao.Entities;
using MediatR;

namespace Domain.Application.DanhMuc.Question.Commands.Create
{
    public class CreateQuestionCommandHandler : IRequestHandler<CreateQuestionCommandRequest, CreateQuestionCommandResponse>
    {
        private readonly QuestionAndAnswerDbContext _context;
        private readonly IMapper _mapper;
        
        public CreateQuestionCommandHandler(QuestionAndAnswerDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<CreateQuestionCommandResponse> Handle(CreateQuestionCommandRequest request, CancellationToken cancellationToken)
        {
            var question = _mapper.Map<Dao.Entities.Question>(request);
            await _context.Questions.AddAsync(question, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            var rs = new CreateQuestionCommandResponse();
            return rs;
        }
    }
}
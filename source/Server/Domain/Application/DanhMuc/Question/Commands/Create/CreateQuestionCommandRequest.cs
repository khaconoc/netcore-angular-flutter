using System;
using Domain._Base.Mappings;
using MediatR;

namespace Domain.Application.DanhMuc.Question.Commands.Create
{
    public class CreateQuestionCommandRequest : IRequest<CreateQuestionCommandResponse>, IMapTo<Dao.Entities.Question>
    {
        public string Content { get; set; }
        public long UserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
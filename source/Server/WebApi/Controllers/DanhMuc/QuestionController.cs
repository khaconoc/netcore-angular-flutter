using System.Threading.Tasks;
using Domain.Application.DanhMuc.Question.Commands.Create;
using Microsoft.AspNetCore.Mvc;
using WebApi._Base;

namespace WebApi.Controllers.DanhMuc
{
    public class QuestionController : ApiController
    {
        [HttpPost]
        public async Task<CreateQuestionCommandResponse> Create([FromBody] CreateQuestionCommandRequest command)
        {
            return await Mediator.Send(command);
        }
    }
}
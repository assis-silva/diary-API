using Diary.Application.CQRS.Commands.Create;
using Diary.Application.DTOs.Generics;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Diary.API
{
    [Route("api/[controller]")]
    public class DiaryPageController : Controller
    {
        private readonly IMediator mediator;
        public DiaryPageController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        [Route("create")]
        public async Task<Response> Create([FromBody] CreateDiaryPageCommand request)
        {
            return await mediator.Send(request);
        }

    }
}

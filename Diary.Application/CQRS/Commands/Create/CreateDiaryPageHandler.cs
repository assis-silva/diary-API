using AutoMapper;
using MediatR;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Diary.Application.DTOs.Generics;
using Diary.Application.Interfaces;
using Diary.Domain.Constants;
using Diary.Domain.Entities;
using Diary.Application.Exceptions;

namespace Diary.Application.CQRS.Commands.Create
{
    public class CreateDiaryPageHandler : IRequestHandler<CreateDiaryPageCommand, Response>
    {
        private readonly IEFContext eFContext;
        private readonly IMapper mapper;
        private readonly Response response;
        private readonly IConfiguration configuration;
        private readonly IMediator mediator;

        public CreateDiaryPageHandler(IEFContext eFContext, IMapper mapper, Response response, IConfiguration configuration, IMediator mediator)
        {
            this.eFContext = eFContext;
            this.mapper = mapper;
            this.response = response;
            this.configuration = configuration;
            this.mediator = mediator;

        }
        public async Task<Response> Handle(CreateDiaryPageCommand request, CancellationToken cancellationToken)
        {
            await SaveDiaryPage(request);
            return await response.GenerateResponse(hasError: false, statusCode: HttpStatusCode.OK, message: Messages.Saved);

        }

        private async Task SaveDiaryPage(CreateDiaryPageCommand request)
        {
            var diaryPage = mapper.Map<DiaryPage>(request);
            await eFContext.Pages.AddAsync(diaryPage);
            var result = await eFContext.SaveChangesAsync();

            if (result <= 0)
            {
                throw new PersistanceDbException<CreateDiaryPageCommand>(request, nameof(CreateDiaryPageHandler));
            }
        }
    }
}

using AutoMapper;
using Diary.Application.CQRS.Commands.Create;
using Diary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Application.Automapper
{
    public class DiaryPageMapper : Profile
    {
        public DiaryPageMapper()
        {
            CreateMap<CreateDiaryPageCommand, DiaryPage>()
            .ForMember(a => a.Title, opt => opt.MapFrom(s => s.Title))
            .ForMember(a => a.Body, opt => opt.MapFrom(a => a.Body));
        }
    }
}

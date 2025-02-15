using AutoMapper;
using FluentValidationApp.Web.Dtos;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.Mapping
{
	public class EventDateProfile:Profile
	{
		public EventDateProfile()
		{
			//Once Dto sonra entity
			CreateMap<EventDateDto, EventDate>().
			ForMember(x=>x.Date, options=>options.MapFrom
			(x=> new DateTime(x.Year,x.Month,x.Day)));
			CreateMap<EventDate, EventDateDto>().
			ForMember(x => x.Year, options => options.MapFrom(x => x.Date.Year))
			.ForMember(x => x.Month, options => options.MapFrom(x => x.Date.Month))
			.ForMember(x => x.Day, options => options.MapFrom(x => x.Date.Day));
		}
	}
}

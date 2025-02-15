using AutoMapper;
using FluentValidationApp.Web.Dtos;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.Mapping
{
	public class CustomerProfile : Profile
	{
		public CustomerProfile()
		{
			CreateMap<CreditCard,CustomerDto>();
			CreateMap<Customer, CustomerDto>().IncludeMembers(x => x.CreditCard).
			ForMember(dest => dest.Isim, options => options.MapFrom(x => x.Name))
			.ForMember(dest => dest.Eposta, options => options.MapFrom(x => x.Email))
			.ForMember(dest => dest.Yas, options => options.MapFrom(x => x.Age))
			.ForMember(dest => dest.FullName, options => options.MapFrom(x => x.FullName2()));


		}
	}
}

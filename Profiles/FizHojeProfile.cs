using AutoMapper;
using FizHoje.Dtos;
using FizHoje.Models;

namespace FizHoje.Profiles
{
    public class FizHojeProfile : Profile
    {
        public FizHojeProfile()
        {
            //Source -> Target
            CreateMap<FizHojeModel, FizHojeReadDto>();
            CreateMap<FizHojeCreateDto, FizHojeModel>();
        }
    }
}
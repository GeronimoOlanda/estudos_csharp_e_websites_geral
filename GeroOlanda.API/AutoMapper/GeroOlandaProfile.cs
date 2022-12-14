using AutoMapper;
using GeroOlanda.Domain.Entities;
using GeroOlanda.Domain.Entities.Dtos;
using GeroOlanda.Domain.Services;
using GeroOlanda.Domain.Services.Impl;

namespace GeroOlanda.API.AutoMapper
{
    public class GeroOlandaProfile : Profile
    {
        public GeroOlandaProfile() : base(nameof(GeroOlandaProfile))
        {
            CreateMap<Home, HomeDTO>();
        }
    }
}

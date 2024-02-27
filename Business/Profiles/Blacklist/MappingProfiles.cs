using AutoMapper;
using Business.Requests.Blacklist;
using Business.Responses.Blacklist;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Blacklist
{
    public class MappingProfiles : Profile
    {

        public MappingProfiles() 
        {
            CreateMap<Blacklist, CreateBlacklistRequest>().ReverseMap();
            CreateMap<Blacklist, DeleteBlacklistRequest>().ReverseMap();
            CreateMap<Blacklist, UpdateBlacklistRequest>().ReverseMap();

            CreateMap<Blacklist, CreateBlacklistResponse>().ReverseMap();
            CreateMap<Blacklist, UpdateBlacklistResponse>().ReverseMap();
            CreateMap<Blacklist, GetAllBlacklistResponse>().ReverseMap();
            CreateMap<Blacklist, GetByIdBlacklistResponse>().ReverseMap();





        }
    }
}

using AutoMapper;
using Business.Requests.Blacklist;
using Business.Requests.BootcampStates;
using Business.Responses.Blacklist;
using Business.Responses.BootcampStates;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.BootcampStateStates
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<BootcampState, CreateBootcampStateRequest>().ReverseMap();
            CreateMap<BootcampState, DeleteBootcampStateRequest>().ReverseMap();
            CreateMap<BootcampState, UpdateBootcampStateRequest>().ReverseMap();

            CreateMap<BootcampState, CreateBootcampStateResponse>().ReverseMap();
            CreateMap<BootcampState, UpdateBootcampStateResponse>().ReverseMap();
            CreateMap<BootcampState, GetAllBootcampStateResponse>().ReverseMap();
            CreateMap<BootcampState, GetByIdBootcampStateResponse>().ReverseMap();
        }
    }
}

using AutoMapper;
using Business.Abstracts;
using Business.Requests.Blacklist;
using Business.Responses.Blacklist;
using Core.Utilities.Result;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class BlacklistManager : IBlacklistService
    {
        private readonly IBlacklistRepository _blacklistRepository;
        private readonly IMapper _mapper;

        public BlacklistManager(IBlacklistRepository blacklistRepository, IMapper mapper)
        {
            _blacklistRepository = blacklistRepository;
            _mapper = mapper;
        }

        public async Task<IDataResult<CreateBlacklistResponse>> CreateAsync(CreateBlacklistRequest request)
        {
            Blacklist blacklist = _mapper.Map<Blacklist>(request);
            await _blacklistRepository.AddAsync(blacklist);
            CreateBlacklistResponse response = _mapper.Map<CreateBlacklistResponse>(blacklist);
            return new SuccessDataResult<CreateBlacklistResponse>(response, "Başarıyla eklendi.");
        }

        public async Task<IResult> DeleteAsync(DeleteBlacklistRequest request)
        {
            Blacklist blacklist = _mapper.Map<Blacklist>(request);
            await _blacklistRepository.DeleteAsync(blacklist);
            return new SuccessResult("Başarıyla silindi.");
        }

        public async Task<IDataResult<List<GetAllBlacklistResponse>>> GetAllAsync()
        {
            List<Blacklist> blacklists = await _blacklistRepository.GetAllAsync();
            List<GetAllBlacklistResponse> responses = _mapper.Map<List<GetAllBlacklistResponse>>(blacklists);
            return new SuccessDataResult<List<GetAllBlacklistResponse>>(responses, "Listeleme başarılı.");
        }

        public async Task<IDataResult<GetByIdBlacklistResponse>> GetByIdAsync(int id)
        {
            Blacklist blacklist = await _blacklistRepository.GetAsync(x => x.Id == id);
            GetByIdBlacklistResponse response = _mapper.Map<GetByIdBlacklistResponse>(blacklist);
            return new SuccessDataResult<GetByIdBlacklistResponse>(response);
        }

        public async Task<IDataResult<UpdateBlacklistResponse>> UpdateAsync(UpdateBlacklistRequest request)
        {
            Blacklist blacklist = await _blacklistRepository.GetAsync(x => x.Id == request.Id);
            _mapper.Map(request, blacklist);
            await _blacklistRepository.UpdateAsync(blacklist);
            UpdateBlacklistResponse response = _mapper.Map<UpdateBlacklistResponse>(blacklist);
            return new SuccessDataResult<UpdateBlacklistResponse>(response, "Başarıyla güncellendi.");
        }
    }
}

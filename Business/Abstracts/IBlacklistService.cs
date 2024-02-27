using Business.Requests.Blacklist;
using Business.Responses.Blacklist;
using Core.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IBlacklistService
    {
        Task<IDataResult<List<GetAllBlacklistResponse>>> GetAllAsync();
        Task<IDataResult<GetByIdBlacklistResponse>> GetByIdAsync(int id);
        Task<IDataResult<CreateBlacklistResponse>> CreateAsync(CreateBlacklistRequest request);
        Task<IResult> DeleteAsync(DeleteBlacklistRequest request);
        Task<IDataResult<UpdateBlacklistResponse>> UpdateAsync(UpdateBlacklistRequest request);
    }
}

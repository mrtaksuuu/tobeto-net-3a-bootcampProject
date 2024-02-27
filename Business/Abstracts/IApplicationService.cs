﻿using Business.Requests.Applications;
using Business.Responses.Applications;
using Core.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IApplicationService
    {
        Task<IDataResult<List<GetAllApplicationResponse>>> GetAllAsync();
        Task<IDataResult<GetByIdApplicationResponse>> GetByIdAsync(int id);
        Task<IDataResult<CreateApplicationResponse>> AddAsync(CreateApplicationRequest request);
        Task<IResult> DeleteAsync(DeleteApplicationRequest request);
        Task<IDataResult<UpdateApplicationResponse>> UpdateAsync(UpdateApplicationRequest request);
    }
}

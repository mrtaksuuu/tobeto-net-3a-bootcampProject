﻿using Business.Requests.Instructors;
using Business.Responses.Instructors;
using Core.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        public interface IInstructorService
        {
            Task<IDataResult<List<GetAllInstructorResponse>>> GetAllAsync();
            Task<IDataResult<GetByIdInstructorResponse>> GetByIdAsync(int id);
            Task<IDataResult<CreateInstructorResponse>> AddAsync(CreateInstructorRequest request);
            Task<IResult> DeleteAsync(DeleteInstructorRequest request);
            Task<IDataResult<UpdateInstructorResponse>> UpdateAsync(UpdateInstructorRequest request);
        }
    }
}

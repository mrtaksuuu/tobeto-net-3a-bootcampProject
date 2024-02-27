﻿using Business.Requests.Employees;
using Business.Responses.Employees;
using Core.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IEmployeeService
    {
        Task<IDataResult<List<GetAllEmployeeResponse>>> GetAllAsync();
        Task<IDataResult<GetByIdEmployeeResponse>> GetByIdAsync(int id);
        Task<IDataResult<CreateEmployeeResponse>> AddAsync(CreateEmployeeRequest request);
        Task<IResult> DeleteAsync(DeleteEmployeeRequest request);
        Task<IDataResult<UpdateEmployeeResponse>> UpdateAsync(UpdateEmployeeRequest request);
    }
}

using Business.Requests.Employees;
using Business.Responses.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IEmployeeService
    {
        Task<CreatedEmployeeResponse> AddAsync(CreateEmployeeRequest request);
        Task<UpdatedEmployeeResponse> UpdateAsync(UpdateEmployeeRequest request);
        Task<DeletedEmployeeResponse> DeleteAsync(DeleteEmployeeRequest request);
        Task<List<GetAllEmployeeResponse>> GetAllAsync();
        Task<GetByIdEmployeeResponse> GetByIdAsync(int id);
    }
}

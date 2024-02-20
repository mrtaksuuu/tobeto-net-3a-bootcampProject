using Business.Requests.Instructors;
using Business.Responses.Instructors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        Task<CreatedInstructorResponse> AddAsync(CreateInstructorRequest request);
        Task<UpdatedInstructorResponse> UpdateAsync(UpdateInstructorRequest request);
        Task<DeletedInstructorResponse> DeleteAsync(DeleteInstructorRequest request);
        Task<List<GetAllInstructorResponse>> GetAllAsync();
        Task<GetByIdInstructorResponse> GetByIdAsync(int id);
    }
}

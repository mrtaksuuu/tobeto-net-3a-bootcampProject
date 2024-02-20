using Business.Requests.Applicants;
using Business.Responses.Applicants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IApplicantService
    {
        Task<CreatedApplicantResponse> AddAsync(CreateApplicantRequest request);
        Task<UpdatedApplicantResponse> UpdateAsync(UpdateApplicantRequest request);
        Task<DeletedApplicantResponse> DeleteAsync(DeleteApplicantRequest request);
        Task<List<GetAllApplicantResponse>> GetAllAsync();
        Task<GetByIdApplicantResponse> GetByIdAsync(int id);

    }
}

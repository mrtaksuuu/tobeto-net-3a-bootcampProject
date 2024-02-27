using Business.Abstracts;
using Business.Requests.Blacklist;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlacklistsController : : BaseController
    {
        private readonly IBlacklistService _blacklistService;

    public BlacklistsController(IBlacklistService blacklistService)
    {
        _blacklistService = blacklistService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        return HandleDataResult(await _blacklistService.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        return HandleDataResult(await _blacklistService.GetByIdAsync(id));
    }

    [HttpPost]
    public async Task<IActionResult> AddAsync(CreateBlacklistRequest request)
    {
        return HandleDataResult(await _blacklistService.CreateAsync(request));
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(DeleteBlacklistRequest request)
    {
        return HandleResult(await _blacklistService.DeleteAsync(request));
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAsync(UpdateBlacklistRequest request)
    {
        return HandleDataResult(await _blacklistService.UpdateAsync(request));
    }
}
}

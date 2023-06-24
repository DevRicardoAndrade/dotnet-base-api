using dotnet.DTOs;
using dotnet.Mapper;
using dotnet.Models;
using dotnet.Repositories.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
    [Route("api/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IUnitOfWork? _unitOfWork;
        public HomeController(IUnitOfWork unitOfWork)
        {
                _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var homeBase = _unitOfWork.HomeRepository.Get(h => h.Id == 1).Result;
            var homeTo = new HomeDTO();
            Mapper.Mapper.Map(homeBase, homeTo);
            return Ok(homeTo);
        }
    }
}

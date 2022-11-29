using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestVision.Web.Models;
using TestVision.Web.Services.IServices;

namespace TestVision.Web.Controllers
{
    public class HomeController : Controller
    {
		private readonly ITestDetailsService _testDetailsService;

        public HomeController(ITestDetailsService testDetailsService)
        {
            _testDetailsService = testDetailsService;
        }


		public async Task<IActionResult> Index()
		{
			List<TestDetailsDto> list = new();
			var response = await _testDetailsService.GetAllTestDetailsAsync<ResponseDto>();
			if (response != null && response.IsSuccess)
			{
				list = JsonConvert.DeserializeObject<List<TestDetailsDto>>(Convert.ToString(response.Result));
			}
			return View(list);
		}
	}
}
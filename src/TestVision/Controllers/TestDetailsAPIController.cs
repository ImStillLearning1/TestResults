using Microsoft.AspNetCore.Mvc;
using TestVisionAPI.Handlers;
using TestVisionAPI.Repository;
using TestVisionAPI.Models;
using Azure;

namespace TestVisionAPI.Controllers
{
    [ApiController]
    [Route("test-results")]
    public class TestDetailsAPIController : ControllerBase
    {
		protected ResponseDto _response;
		private ITestDetailsRepository _testDetailsRepository;

        public TestDetailsAPIController(ITestDetailsRepository testDetailsRepository)
        {
            _testDetailsRepository = testDetailsRepository;
			this._response = new ResponseDto();
		}

        [HttpGet]
        public async Task<object> Get()
        {
			try
			{
				IEnumerable<TestDetailsDto> testResultsDtos = await _testDetailsRepository.GetTestsDetails();
				_response.Result = testResultsDtos;
			}
			catch (Exception ex)
            {
				_response.IsSuccess = false;
				_response.ErrorMessages
					 = new List<string>() { ex.ToString() };
			}
			return _response;
        }

        [HttpPost]
        [Route("/execute")]
        public async Task<object> Post()
        {
            List<TestDetailsDto> testDetailsDtos = await _testDetailsRepository.CreateTestsDetails();
            return testDetailsDtos;
        }
    }
}

using TestVision.Web.Models;
using TestVision.Web.Services.IServices;

namespace TestVision.Web.Services
{
    public class TestDetailsService : BaseService, ITestDetailsService
    {
        private readonly IHttpClientFactory _clientFactory;

        public TestDetailsService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> GetAllTestDetailsAsync<T>()
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.TestDetailsAPIBase + "/test-results",
            });
        }

        public Task<T> GetTestDetailsBySerialNumberAsync<T>(string serialNumber)
        {
            throw new NotImplementedException();
        }
    }
}

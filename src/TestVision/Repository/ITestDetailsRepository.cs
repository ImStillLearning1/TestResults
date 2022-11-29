using TestVisionAPI.Models;

namespace TestVisionAPI.Repository
{
    public interface ITestDetailsRepository
    {
        Task<IEnumerable<TestDetailsDto>> GetTestsDetails();
        Task<TestDetailsDto> GetTestsDetailsBySerialNumber();
        Task<List<TestDetailsDto>> CreateTestsDetails();
    }
}

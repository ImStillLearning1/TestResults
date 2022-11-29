namespace TestVision.Web.Services.IServices
{
    public interface ITestDetailsService
    {
        Task<T> GetAllTestDetailsAsync<T>();
        Task<T> GetTestDetailsBySerialNumberAsync<T>(string serialNumber);
    }
}

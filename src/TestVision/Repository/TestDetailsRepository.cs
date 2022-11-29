using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TestVisionAPI.DbContexts;
using TestVisionAPI.Handlers;
using TestVisionAPI.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TestVisionAPI.Repository
{
    public class TestDetailsRepository : ITestDetailsRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public TestDetailsRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<List<TestDetailsDto>> CreateTestsDetails()
        {
            ExtractData extractData = new ExtractData();
            List<TestDetails> testDetailsList = _mapper.Map<List<TestDetails>>(extractData.ExtractDataFromXml());

            foreach(var testDetails in testDetailsList)
            {
                var testDetailsDtoFromDb = _db.TestsDetails.Where(x => x.SerialNumber == testDetails.SerialNumber && x.CreatedDate == testDetails.CreatedDate).FirstOrDefault();

				if (testDetailsDtoFromDb == null)
                    _db.TestsDetails.Add(testDetails);
            }
            await _db.SaveChangesAsync();
            return _mapper.Map<List<TestDetailsDto>>(testDetailsList);
        }

        public async Task<IEnumerable<TestDetailsDto>> GetTestsDetails()
        {
            List<TestDetails> testDetailsList = await _db.TestsDetails.Where(x => x.CreatedDate == _db.TestsDetails.Where(u => u.SerialNumber == x.SerialNumber).Select(u => u.CreatedDate).Max()).ToListAsync();
            return _mapper.Map<IEnumerable<TestDetailsDto>>(testDetailsList);
        }

        public Task<TestDetailsDto> GetTestsDetailsBySerialNumber()
        {
            throw new NotImplementedException();
        }
    }
}

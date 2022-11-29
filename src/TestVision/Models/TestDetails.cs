using System.ComponentModel.DataAnnotations;

namespace TestVisionAPI.Models
{
    public class TestDetails
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public string SerialNumber { get; set; }
        [Required]
        public string TestResult { get; set; }
    }
}

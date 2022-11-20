using Core.Entities;

namespace Entities.DTOs
{
    public class CustomerDetailDto : IDto
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string UserMail { get; set; }
        public string UserPassword { get; set; }
        public string CompanyName { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace LightFeatherProj.Models
{
    public class Supervisor
    {
        public int ID { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public char Jurisdiction { get; set; }
        public string IdentificationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

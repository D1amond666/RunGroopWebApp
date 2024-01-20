using System.ComponentModel.DataAnnotations;

namespace RunGroopWebApp.Models
{
    // Всё в нашей базе данных, всё в нашем приложении наши беговые клубы, наши гоночные клубы, наши забеги будут иметь адреса, по тому, что это встреча  

    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}

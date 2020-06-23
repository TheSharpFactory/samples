using System.ComponentModel.DataAnnotations;

namespace TheSharpFactory.Common.DTO
{
    public class CustomerDTO
	{
        [Required]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, Phone]
        public string Phone { get; set; }
	}
}

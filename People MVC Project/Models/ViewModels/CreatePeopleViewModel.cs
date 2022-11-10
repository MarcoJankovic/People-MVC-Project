using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace People_MVC_Project.Models.ViewModels
{
    public class CreatePeopleViewModel
    {
        [Display(Name = "Name")]

        [Required]
        [StringLength(20)]
        public string? Name { get; set; }

        [Required]
        [Range(1, 110, ErrorMessage = "Please enter valid integer Number 1 - 110")]
        public int? Age { get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        public List<string> CityList
        {
            get
            {
                return new List<string> { "Stockholm", "London", "Oslo", "Copenhagen", "Moscow", "Paris", "Berlin", "Madrid", "Warsaw", "Helsinki", "Tokyo", "Beijing" };
            }
        }
    }
}

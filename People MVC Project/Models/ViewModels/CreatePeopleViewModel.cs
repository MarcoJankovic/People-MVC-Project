using System.ComponentModel.DataAnnotations;

namespace People_MVC_Project.Models.ViewModels
{
    public class CreatePeopleViewModel
    {
        [Display(Name = "Name")]
        [Required]
        public string? PersonName { get; set; }
        [Required]
        public string? Phone { get; set; }
        [StringLength(10, MinimumLength = 1)]
        [Required]

        public string? City { get; set; }
        [Required]

        public List<string> CityList
        {
            get
            {
                return new List<string> { "Stockholm", "Copenhagen", "Oslo", "Berlin", "Paris", " Madrid", "Moscow" };
            }
        }
    }
}

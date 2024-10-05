using System.ComponentModel.DataAnnotations;

namespace NZWalks.API.Models.DTO
{
    /*
        DTO containing the details of a request to update a region 
    */
    public class UpdateRegionDTO
    {
        [Required(ErrorMessage = "Code is required.")]
        [MinLength(3, ErrorMessage = "Minimum length of Code must be 3 characters.")]
        [MaxLength(3, ErrorMessage = "Maximum length of Code must be 3 characters.")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Code is required.")]
        [MaxLength(100, ErrorMessage = "Maximum length of Name must be 100 characters.")]
        public string Name { get; set; }

        public string? RegionImageUrl { get; set; }
    }
}

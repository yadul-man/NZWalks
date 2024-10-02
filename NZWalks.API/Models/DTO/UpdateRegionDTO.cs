namespace NZWalks.API.Models.DTO
{
    /*
        DTO containing the details of a request to update a region 
    */
    public class UpdateRegionDTO
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}

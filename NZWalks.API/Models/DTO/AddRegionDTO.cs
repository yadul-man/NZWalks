namespace NZWalks.API.Models.DTO
{
    /*
        DTO containing the details of a request to add a region 
    */
    public class AddRegionDTO
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}

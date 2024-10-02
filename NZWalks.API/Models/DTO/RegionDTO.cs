namespace NZWalks.API.Models.DTO
{
    /*
        DTO containing the details of a region 
    */
    public class RegionDTO
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}

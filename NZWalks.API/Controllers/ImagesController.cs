using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTO;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImageRepository imageRepository;

        public ImagesController(IImageRepository imageRepository)
        {
            this.imageRepository = imageRepository;
        }

        [HttpPost]
        [Route("Upload")]
        public async Task<IActionResult> Upload([FromForm] ImageUploadDTO imageUploadDTO)
        {
            ValidateFileUpload(imageUploadDTO);

            if (ModelState.IsValid)
            {
                // Convert DTO to domain model
                var imageDomainModel = new Image
                {
                    File = imageUploadDTO.File,
                    FileExtension = Path.GetExtension(imageUploadDTO.File.FileName),
                    FileSizeInBytes = imageUploadDTO.File.Length,
                    FileName = imageUploadDTO.FileName,
                    FileDescription = imageUploadDTO.FileDescription
                };

                // Use repository to upload image
                await imageRepository.Upload(imageDomainModel);

                return Ok(imageDomainModel);
            }

            return BadRequest(ModelState);
        }

        private void ValidateFileUpload(ImageUploadDTO imageUploadDTO)
        {
            var allowedExtensions = new string[] { ".jpg", ".jpeg", ".png" };

            if (!allowedExtensions.Contains(Path.GetExtension(imageUploadDTO.File.FileName))) 
            {
                ModelState.AddModelError("file", "Unsupported file extension.");
            }

            // File size > 10MB
            if (imageUploadDTO.File.Length > 10485760)
            {
                ModelState.AddModelError("file", "File size is greater than 10MB. Please upload a smaller file.");
            }
        }
    }
}

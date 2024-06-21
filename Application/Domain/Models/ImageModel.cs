using Microsoft.AspNetCore.Http;

namespace Application.Domain.Models
{
    public class ImageModel
    {
        public IFormFile? ImageFile { get; set; }
        public List<ImageEffect>? ImageEffects { get; set; }
    }
}

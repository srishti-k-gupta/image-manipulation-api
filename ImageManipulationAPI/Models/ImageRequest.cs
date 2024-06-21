using Microsoft.AspNetCore.Mvc;

namespace ImageManipulationAPI.Models
{
     public record ImageRequest(IFormFile ImageFile, List<ImageEffectRequest> ImageEffects);
}

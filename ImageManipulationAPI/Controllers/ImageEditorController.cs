using Application.Abstractions;
using Application.Domain.Models;
using ImageManipulationAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImageManipulationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageEditorController : ControllerBase
    {
        private readonly ILogger<ImageEditorController> _logger;
        private readonly IImageManipulation _imageManipulation;
        public ImageEditorController(ILogger<ImageEditorController> logger, IImageManipulation imageManipulation)
        {
            _logger = logger; 
            _imageManipulation = imageManipulation;
        }

        [HttpPost]
        [Route("ManipulateMulipleImages")]
        public async Task<IActionResult> ManipulateMulipleImages([FromForm] List<ImageModel> request)
        {
            _logger.LogInformation("Image Manipulation Begins..");
            // Map Controller request model to domain model here, can use Automapper
            //Send the domain model to service
            var result = await _imageManipulation.ManipulateImages(request);
            _logger.LogInformation("Image Manipulation Completed!");
            return new OkObjectResult(result);
        }
    }
}

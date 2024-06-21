using Application.Abstractions;
using Application.Adapters.ImageManipulators;

namespace Application.Domain.Shared
{
    public class ImageOperationsConfig
    {
        public static Dictionary<string, IImageOperation> EffectTypesInput { get; set; } = new Dictionary<string, IImageOperation>()
        {
            { "Resize", new ResizeImageManipulator().GetImageOperationObject() },
            { "BlurPixels" , new BlurImageManipulator().GetImageOperationObject() },
            { "ConvertToGrayScale" , new ConvertToGrayScaleManipulator().GetImageOperationObject()},
        };
    }
}

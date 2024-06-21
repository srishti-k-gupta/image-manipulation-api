using Application.Abstractions;
using Application.Adapters.ImageOperations;

namespace Application.Adapters.ImageManipulators
{
    public class ResizeImageManipulator : ImageManipulationFactory
    {
        public override IImageOperation GetImageOperationObject()
        {
            return new ResizeImageService();
        }
    }
}

using Application.Abstractions;
using Application.Adapters.ImageOperations;

namespace Application.Adapters.ImageManipulators
{
    public class BlurImageManipulator : ImageManipulationFactory
    {
        public override IImageOperation GetImageOperationObject()
        {
            return new BlurImagePixelsService();
        }
    }
}

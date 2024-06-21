using Application.Abstractions;
using Application.Adapters.ImageOperations;

namespace Application.Adapters.ImageManipulators
{
    public class ConvertToGrayScaleManipulator : ImageManipulationFactory
    {
        public override IImageOperation GetImageOperationObject()
        {
            return new ConvertToGrayScaleService();
        }
    }
}

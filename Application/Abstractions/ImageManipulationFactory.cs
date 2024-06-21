namespace Application.Abstractions
{
    public abstract class ImageManipulationFactory
    {
        public abstract IImageOperation GetImageOperationObject();
    }
}

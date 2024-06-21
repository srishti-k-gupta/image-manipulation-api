using Application.Abstractions;

namespace Application.Adapters.ImageOperations
{
    public class ConvertToGrayScaleService : IImageOperation
    {
        public async Task<Stream> EditImage(Stream imageStream, object? input)
        {
            // Manipulate the image stream as per the effect here
            // Return the manipulated image stream
            Console.WriteLine("Convert to Gray Scale Effect Applied!");
            return imageStream;
        }
    }
}

using Application.Abstractions;

namespace Application.Adapters.ImageOperations
{
    public class BlurImagePixelsService : IImageOperation
    {
        public async Task<Stream> EditImage(Stream imageStream, object? input)
        {
            // Manipulate the image stream as per the effect here
            // Return the manipulated image stream
            Console.WriteLine("Blur Image Pixels Effect Applied!");
            return imageStream;
        }
    }
}

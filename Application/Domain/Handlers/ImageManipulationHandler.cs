using Application.Abstractions;
using Application.Domain.Models;
using Application.Domain.Shared;

namespace Application.Domain.Handlers
{
    public class ImageManipulationHandler : IImageManipulation
    {
        public async Task<List<Stream>> ManipulateImages(List<ImageModel> imageModel)
        {
            List<Task<Stream>> imageManipulationTaskList = new();
            foreach (var file in imageModel)
            {
                var imageManipulationTask = Task.Run(() => ProcessImage(file));
                imageManipulationTaskList.Add(imageManipulationTask);
            }
            await Task.WhenAll(imageManipulationTaskList);

            List<Stream> manipulatedImageStreamList = new();
            foreach (var imageManipulationTask in imageManipulationTaskList)
            {
                manipulatedImageStreamList.Add(imageManipulationTask.GetAwaiter().GetResult());
            }
            Console.WriteLine("All Effects are Applied on the respective Images!");
            return manipulatedImageStreamList;
        }

        private async Task<Stream> ProcessImage(ImageModel image)
        {
            Console.WriteLine($"ProcessImage - Processing Image {image.ImageFile.FileName}");
            if (image.ImageFile.Length > 0)
            {
                var imageStream = image.ImageFile.OpenReadStream();
                foreach (var effect in image.ImageEffects)
                {
                    if (ImageOperationsConfig.EffectTypesInput.TryGetValue(effect.EffectType, out var imageOperationService))
                    {
                        imageStream = await imageOperationService.EditImage(imageStream, effect.EffectInput);
                    }
                }
                Console.WriteLine("ProcessImage Done : Effects Applied!");
                return imageStream;
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }
}

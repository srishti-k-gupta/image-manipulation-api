using Application.Domain.Models;

namespace Application.Abstractions
{
    public interface IImageManipulation
    {
        Task<List<Stream>> ManipulateImages(List<ImageModel> imageModel);
    }
}

namespace Application.Abstractions
{
    public interface IImageOperation
    {
        Task<Stream> EditImage(Stream imageStream, object? input);
    }
}

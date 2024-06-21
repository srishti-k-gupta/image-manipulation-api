namespace ImageManipulationAPI.Middlewares
{
    public class ExceptionHandlingMiddleware : IMiddleware
    {
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(ILogger<ExceptionHandlingMiddleware> logger)
        {
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            // Add code for handling exceptions here
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                // Log the error
                _logger.LogError(ex, "error during executing {Context}", context.Request.Path.Value);

                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await context.Response.WriteAsync("Something went wrong!");
            }
        }
    }
}

using Microsoft.AspNetCore.Diagnostics;
using Repository.ErrorModel;

namespace SchoolActivity.Extensions
{
    public static class ExceptionMiddlewareExtension
    {
        public static void ConfigureGlobalException(this WebApplication app)
        {
            app.UseExceptionHandler(builder =>
            {
                builder.Run(async context =>
                {
                    context.Response.ContentType = "application/json";

                    var contextFeatures = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeatures != null)
                    {
                        context.Response.StatusCode = contextFeatures.Error switch
                        {
                            NotFoundException => StatusCodes.Status404NotFound,
                            _ => StatusCodes.Status500InternalServerError
                        };

                        await context.Response.WriteAsync(new ErrorDetails
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = contextFeatures.Error.Message
                        }.ToString());
                    };
                });
            });
        }
    }
}

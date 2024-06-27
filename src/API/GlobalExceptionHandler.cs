using System.Net;
using Application.Commons;
using Microsoft.AspNetCore.Diagnostics;

namespace API
{
	public class GlobalExceptionHandler : IExceptionHandler
	{
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            var response = httpContext.Response;
            response.ContentType = "application/json";
            string result = exception.Message;

            response.StatusCode = exception switch
            {
                CustomValidationException => (int)HttpStatusCode.BadRequest,
                _ => response.StatusCode = (int)HttpStatusCode.InternalServerError
            };

            await response.WriteAsync(result);

            return true;
        }
    }
}


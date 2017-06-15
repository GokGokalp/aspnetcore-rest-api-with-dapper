using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace aspnetcore_rest_api_with_dapper.Middlewares
{
    public class GlobalExceptionMiddleware
    {
        private readonly ILogger _logger;
        private readonly RequestDelegate _next;

        public GlobalExceptionMiddleware(RequestDelegate next, ILoggerFactory logger)
        {
            _next = next;
            _logger = logger.CreateLogger("GlobalExceptionMiddleware");
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                 _logger.LogError(0, ex, ex.Message);
            }
        }
    }
}
using Banking.Api.Middleware.ApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Banking.Api.Middleware
{
    public class GlobalExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        public GlobalExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                /*if(ex is NotFoundResult)
                {

                }*/

                var responseWrapper = new ResponseWrapper
                {
                    Data = null,
                    Error = ex.Message,
                    Status = "500"
                };
                context.Response.StatusCode = 500;
                await context.Response.WriteAsync(Newtonsoft.Json.JsonConvert.SerializeObject(responseWrapper));
            }
        }
    }
}

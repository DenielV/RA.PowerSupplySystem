﻿using RA.PowerSupplySystem.Api.Models;
using RA.PowerSupplySystem.Application.Exceptions;
using System.Net;

namespace RA.PowerSupplySystem.Api.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext httpContext, Exception ex)
        {
            HttpStatusCode statusCode = HttpStatusCode.InternalServerError;
            CustomProblemDetails problem = new();

            switch (ex)
            {
                case BadRequestException badRequestException:
                    statusCode = HttpStatusCode.BadRequest;
                    problem = new CustomProblemDetails
                    {
                        Title = badRequestException.Message,
                        Status = (int)statusCode,
                        Detail = badRequestException.InnerException?.Message,
                        Type = nameof(badRequestException),
                        Errors = badRequestException.ValidationErrors
                    };
                    break;
                //case NotFoundException notFoundException:
                //    statusCode = HttpStatusCode.NotFound;
                //    problem = new CustomProblemDetails
                //    {
                //        Title = notFoundException.Message,
                //        Status = (int)statusCode,
                //        Type = nameof(NotFoundException),
                //        Detail = notFoundException.InnerException?.Message,
                //    };
                //    break;
                default:
                    problem = new CustomProblemDetails
                    {
                        Title = ex.Message,
                        Status = (int)statusCode,
                        Detail = ex.StackTrace,
                        Type = nameof(HttpStatusCode.InternalServerError)
                    };
                    break;
            }

            httpContext.Response.StatusCode = (int)statusCode;
            await httpContext.Response.WriteAsJsonAsync(problem);
        }
    }
}

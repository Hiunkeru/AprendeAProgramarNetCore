using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AprendeNetCore2.Middleware
{
    public class EjemploMiddleware
    {

        private readonly RequestDelegate _next;

        public EjemploMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var originalRequestBody = context.Request.ContentType;

            Console.Write(originalRequestBody);

            await _next(context);

            Console.Write("Viene la respuesta");

        }


    }
}

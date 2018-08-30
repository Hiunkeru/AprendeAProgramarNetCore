using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendeNetCore2.Middleware
{
    public static class EjemploMiddlewareExtension
    {

        public static IApplicationBuilder UseEjemplo(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<EjemploMiddleware>();
        }

    }
}
